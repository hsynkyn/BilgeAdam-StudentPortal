using AutoMapper;
using Business.Manager.Concrete;
using Business.Manager.Interface;
using Core.Enums;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.TeacherDTO;
using DTO.Concrete.UserDTO;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB.Areas.Education.Models.CourseVM;
using WEB.Areas.Education.Models.TeacherVM;

namespace WEB.Areas.Education.Controllers
{
    [Area("Education")]
    public class TeachersController(ITeacherManager teacherManager, IMapper mapper, ICourseManager courseManager, IUserManager userManager, IEmailSender emailSender) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var model = await teacherManager.GetFilteredListAsync
                (
                    select: x => mapper.Map<GetCustomerManagerVM>(x),
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(x => x.CreatedDate),
                    join: x => x.Include(z => z.Course!)

                    // ! => NFT(Null Forgiving Operator): Bir verinin null gelmeyeceğini sen biliyorsun ama ide bilmiyor. Bu yüzden buranın null gelmeyeceğini garanti ediyorum anlamında ünlem işareti kullanıyoruz.
                    );
            return View(model);
        }


        public async Task<IActionResult> CreateTeacher()
        {
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name"
                );
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTeacher(CreateTeacherVM model)
        {
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name"
                );


            //using burayı dispose eder.
            //dispose etmek işi bittikten sonra nesnein silinmesi anlamına gelir. 
            await using var transactionTeacher = await teacherManager.BeginTransactionAsync();
            await using var transactionUser = await userManager.BeginTransactionAsync();

            try
            {

                var createUserDTO = mapper.Map<CreateUserDTO>(model);
                var createIdentityResult = await userManager.CreateUserAsync(createUserDTO);
                if (!createIdentityResult.Succeeded)
                {
                    TempData["Error"] = "Eğitmen hesabı açılamadı!";
                    return View(model);
                }


                var roleResult = await userManager.AddUserToRoleAsync(model.Email!, "teacher");
                if (!roleResult.Succeeded)
                {
                    await transactionUser.RollbackAsync();
                    TempData["Error"] = "Eğitmen role eklenemedi!";
                    return View(model);
                }



                var dto = mapper.Map<CreateTeacherDTO>(model);
                var result = await teacherManager.AddAsync(dto);
                if (!result)
                {
                    await transactionTeacher.RollbackAsync();
                    TempData["Error"] = "Öğretmen oluşturulamadı!";
                    return View(model);
                }


                var user = await userManager.FindUserByEmailAsync(model.Email!);
                var token = await userManager.GenerateTokenForResetPasswordAsync(model.Email!);

                var callBackUrl = Url.Action("CreatePassword", "Account", new
                {
                    area = string.Empty,
                    token,
                    email = model.Email
                }, Request.Scheme);

                var message = $"<p>Kullancıı Adınız: {user!.UserName}</p><br />" +
                    $"<p>Şifre Oluşturma Bağlantısı: {callBackUrl}</p>";
                await emailSender.SendEmailAsync(model.Email!, "Yeni Şifre Oluşturma", message);

                await transactionUser.CommitAsync();
                await transactionTeacher.CommitAsync();

                TempData["Success"] = "Öğretmen başarılı bir şekilde kaydedildi!";
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                await transactionUser.RollbackAsync();
                await transactionTeacher.RollbackAsync();
                TempData["Error"] = "Bir hata oluştu!";
                return View(model);
            }
        }

        public async Task<IActionResult> UpdateTeacher(string id)
        {
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name"
                );


            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Öğretmen bulunamamıştır!!";
                return RedirectToAction(nameof(Index));
            }

            var teacherDto = await teacherManager.GetByIdAsync<UpdateTeacherDTO>(entityId);
            if (teacherDto == null)
            {
                TempData["Error"] = "Öğretmen bulunamamıştır!!";
                return RedirectToAction("Index");
            }

            var course = await courseManager.GetByIdAsync<GetCourseForSelectListDTO>(teacherDto.CourseId);
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name", course
                );

            var model = mapper.Map<UpdateTeacherVM>(teacherDto);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTeacher(UpdateTeacherVM model)
        {
            var course = await courseManager.GetByIdAsync<GetCourseForSelectListDTO>((Guid)model.CourseId!);
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name", course
                );



            var entity = await teacherManager.GetByIdAsync<UpdateTeacherDTO>(model.Id);

            if (entity == null)
            {
                TempData["Error"] = "Öğretmen bulunamadı!!";
                return View(model);
            }

            mapper.Map(model, entity);

            var result = await teacherManager.UpdateAsync(entity, entity.Id);

            if (!result)
            {
                TempData["Error"] = "Öğretmen güncellenemedi!";
                return View(model);

            }

            TempData["Success"] = "Öğretmen başarılı bir şekilde güncellendi!";
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> DeleteTeacher(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Öğretmen bulunamamıştır!!";

            }
            else
            {

                var hasCheckClassroom = await teacherManager.AnyAsync(x => x.Id == entityId && x.Status != Status.Passive && x.Classrooms.Where(z => z.Status != Status.Passive).Count() > 0);

                if (hasCheckClassroom)
                {
                    TempData["Error"] = "Bu eğitmenin aktif sınıfı vardır. Silinemez!";
                }

                else
                {
                    var result = await teacherManager.DeleteAsync(entityId);
                    if (!result)
                    {
                        TempData["Error"] = "Öğretmen silinememiştir!";

                    }
                    else
                    {
                        TempData["Success"] = "Öğretmen başarı ile silinmiştir";

                    }
                }


            }

            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> GetTeachersByCourseId(string courseId)
        {
            var guidResult = Guid.TryParse(courseId, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Öğretmen bulunamamıştır!!";

            }
            else
            {
                var teachers = await teacherManager.GetByDefaultsAsync<GetTeacherForSelectListDTO>(x => x.CourseId == entityId && x.Status != Status.Passive);
                return Json(teachers);
            }
            return NotFound();
        }
    }
}

