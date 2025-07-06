using AutoMapper;
using Business.Manager.Interface;
using DTO.Concrete.AccountDTO;
using DTO.Concrete.CustomerManagerDTO;
using DTO.Concrete.StudentDTO;
using DTO.Concrete.TeacherDTO;
using DTO.Concrete.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using WEB.ActionFilters;
using WEB.Models.ViewModels.AccountVM;

namespace WEB.Controllers
{
    public class AccountController(IUserManager userManager, IStudentManager studentManager, ITeacherManager teacherManager, ICMManager cMManager, IMapper mapper) : Controller
    {
        private readonly IUserManager _userManager = userManager;
        private readonly IStudentManager _studentManager = studentManager;
        private readonly ITeacherManager _teacherManager = teacherManager;
        private readonly ICMManager _cMManager = cMManager;
        private readonly IMapper _mapper = mapper;

        public IActionResult Login() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {

            var dto = _mapper.Map<LoginDTO>(model);
            var result = await _userManager.LoginAsync(dto);

            if (!result.Succeeded)
            {
                TempData["Error"] = "Kullanıcı adı veya şifre yanlış!!";
                return View(model);
            }


            var appUser = await _userManager.FindUserByClaimsAsync<GetUserDTO>(User);

            // Kullanıcı admin ise
            if (await _userManager.IsUserInRoleAsync(appUser!.UserName, "admin"))
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }


            if (!appUser!.HasFirstPasswordChanged)
            {
                TempData["Error"] = "İlk kez giriş yaptığınız için Email'ine gelen linkten şifrenizi değiştiriniz!!";
                await _userManager.LogoutAsync();

                return RedirectToAction(nameof(Login));
            }

            // Kullanıcı öğrenci ise
            if (await _userManager.IsUserInRoleAsync(appUser!.UserName, "Student"))
            {
                return RedirectToAction("StudentDetail", "Students", new { area = "Education" });
            }

            // Kullanıcı öğretmen ise
            if (await _userManager.IsUserInRoleAsync(appUser!.UserName, "Teacher"))
            {
                return RedirectToAction("MyClassrooms", "Teachers", new { area = "Education" });
            }

            // Kullanıcı customermanager ise
            if (await _userManager.IsUserInRoleAsync(appUser!.UserName, "CustomerManager"))
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }

            return RedirectToAction("Index", "Home");


        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _userManager.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> EditUser()
        {
            var dto = await _userManager.FindUserByClaimsAsync<EditUserDTO>(User);
            if (dto == null)
            {
                TempData["Error"] = "Kullanıcı bulunamadı";
                return RedirectToAction(nameof(Login));

            }

            var model = _mapper.Map<EditUserVM>(dto);

            if (await _userManager.IsUserInRoleAsync(dto.Username, "admin"))
            {

                model.FirstName = "admin";
                model.LastName = "admin";

            }

            if (await _userManager.IsUserInRoleAsync(dto.Username, "student"))
            {
                var student = await _studentManager.GetByDefaultAsync<GetStudentDTO>(x => x.AppUserId == model.Id);
                if (student == null)
                {
                    TempData["Error"] = "Bu öğrencinin kaydı yok!";
                    return RedirectToAction(nameof(Login));
                }
                model.FirstName = student.FirstName;
                model.LastName = student.LastName;

            }
            if (await _userManager.IsUserInRoleAsync(dto.Username, "teacher"))
            {
                var teacher = await _studentManager.GetByDefaultAsync<GetTeacherDTO>(x => x.AppUserId == model.Id);
                if (teacher == null)
                {
                    TempData["Error"] = "Bu öğrencinin kaydı yok!";
                    return RedirectToAction(nameof(Login));
                }
                model.FirstName = teacher.FirstName;
                model.LastName = teacher.LastName;

            }

            if (await _userManager.IsUserInRoleAsync(dto.Username, "customerManager"))
            {
                var customerManager = await _cMManager.GetByDefaultAsync<GetCMDTO>(x => x.AppUserId == model.Id);
                if (customerManager == null)
                {
                    TempData["Error"] = "Bu müşteri yöneticinin kaydı yok!";
                    return RedirectToAction(nameof(Login));
                }
                model.FirstName = customerManager.FirstName;
                model.LastName = customerManager.LastName;

            }


            return View(model);
        }

        [Authorize]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(EditUserVM model)
        {

            var isUserNameUsed = await _userManager.AnyAsync(x => x.UserName == model.UserName && x.Id != model.Id);
            if (isUserNameUsed)
            {
                TempData["Error"] = "Bu kullanıcı adı kullanılmaktadır!";
                return RedirectToAction(nameof(EditUser));
            }

            var isEmailUsed = await _userManager.AnyAsync(x => x.Email == model.Email && x.Id != model.Id);
            if (!isEmailUsed)
            {
                TempData["Error"] = "Bu email kullanılmaktadır!!";
                return RedirectToAction(nameof(EditUser));
            }

            var dto = _mapper.Map<EditUserDTO>(model);
            var result = await _userManager.UpdateUserAsync(dto);

            if (!result.Succeeded)
            {
                TempData["Error"] = "Kullanıcı bilgileri güncellenemedi!!";
                return RedirectToAction(nameof(EditUser));
            }

            TempData["Success"] = "Kullanıcı bilgileri başarılı bir şekilde güncellendi!";
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> ChangePassword()
        {
            var userId = await _userManager.GetUserIdByClaimsAsync(User);
            var model = new ChangePasswordVM { Id = userId };

            return View(model);
        }

        [Authorize]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM model)
        {

            var dto = _mapper.Map<ChangePasswordDTO>(model);
            var result = await _userManager.ChangePassswordAsync(dto);

            if (!result.Succeeded)
            {
                TempData["Error"] = "Eski şifreniz hatalıdır!!";
                return View(model);
            }

            TempData["Success"] = "Şifreniz başarılı bir şekilde değiştirilmiştir. Yeni şifreniz ile giriş yapabilirsiniz!";
            await _userManager.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        [ValidateTokexExpiryFilter]
        public IActionResult CreatePassword(string email, string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                TempData["Error"] = "Token değeri boş olamaz!!";
                return BadRequest();
            }

            var model = new ResetPasswordVM
            {
                Email = email,
                Token = token
            };
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePassword(ResetPasswordVM model)
        {
            using var transactionUser = await _userManager.BeginTransactionAsync();

            try
            {
                var user = await _userManager.FindUserByEmailAsync(model.Email!);
                if (user == null)
                {
                    TempData["Error"] = "Kullanıcı bulunamadı!";
                    return View(model);
                }

                var dto = _mapper.Map<ResetPasswordDTO>(model);
                var result = await _userManager.ResetPasswordAsync(dto);

                if (!result.Succeeded)
                {
                    TempData["Error"] = "Şifreni oluşturulamadı!";
                    return View(model);
                }

                user.HasFirstPasswordChanged = true;
                var resultUserUpdate = await _userManager.UpdateUserAsync(user);
                if (!resultUserUpdate.Succeeded)
                {
                    await transactionUser.RollbackAsync();
                    TempData["Error"] = "Şifreni oluşturulamadı!";
                    return View(model);
                }

                await transactionUser.CommitAsync();
                TempData["Success"] = "Şifrenizi başarıyla oluşturdunuz. Yeni şifreniz ile birlikte giriş yapabilirsiniz!";
                return RedirectToAction(nameof(Login));
            }
            catch (Exception)
            {
                await transactionUser.RollbackAsync();
                TempData["Error"] = "Bir hata oluştu!";
                return View(model);
            }
        }


        public IActionResult AccessDenied() => View();
    }
}
