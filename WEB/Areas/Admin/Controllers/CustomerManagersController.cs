using AutoMapper;
using Business.Manager.Interface;
using Core.Enums;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.CustomerManagerDTO;
using DTO.Concrete.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB.Areas.Admin.Models.CustomerManagerVM;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CustomerManagersController(ICMManager customerManager, IMapper mapper, IUserManager userManager,IEmailSender emailSender) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = await customerManager.GetFilteredListAsync
                (
                    select: x => mapper.Map<GetCustomerManagerVM>(x),
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(x => x.CreatedDate)


                    // ! => NFT(Null Forgiving Operator): Bir verinin null gelmeyeceğini sen biliyorsun ama ide bilmiyor. Bu yüzden buranın null gelmeyeceğini garanti ediyorum anlamında ünlem işareti kullanıyoruz.
                    );
            return View(model);
        }

        public IActionResult CreateCustomerManager()
        => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomerManager(CreateCustomerManagerVM model)
        {


            //using burayı dispose eder.
            //dispose etmek işi bittikten sonra nesnein silinmesi anlamına gelir. 
            await using var transactionCM = await customerManager.BeginTransactionAsync();
            await using var transactionUser = await userManager.BeginTransactionAsync();

            try
            {
                var createUserDTO = mapper.Map<CreateUserDTO>(model);
                var createIdentityResult = await userManager.CreateUserAsync(createUserDTO);

                if (!createIdentityResult.Succeeded)
                {
                    TempData["Error"] = "Müşteri Yöneticisi hesabı açılamadı!";
                    return View(model);
                }

                var roleResult = await userManager.AddUserToRoleAsync(model.Email!, "customerManager");

                if (!roleResult.Succeeded)
                {
                    await transactionUser.RollbackAsync();
                    TempData["Error"] = "Müşteri Yöneticisi role eklenemedi!";
                    return View(model);
                }


                var dto = mapper.Map<CreateCustomerManagerDTO>(model);
                var result = await customerManager.AddAsync(dto);

                if (!result)
                {
                    await transactionCM.RollbackAsync();
                    TempData["Error"] = "Müşteri Yöneticisi oluşturulamadı!";
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
                await transactionCM.CommitAsync();

                TempData["Success"] = "Müşteri Yöneticisi başarılı bir şekilde kaydedildi!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                await transactionUser.RollbackAsync();
                await transactionCM.RollbackAsync();
                TempData["Error"] = "Bir hata oluştu!";
                return View(model);
            }
        }
        

        public async Task<IActionResult> UpdateCustomerManager(string id)
        {


            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Müşteri Yöneticisi bulunamamıştır!!";
                return RedirectToAction(nameof(Index));
            }

            var customerDto = await customerManager.GetByIdAsync<UpdateCustomerManagerDTO>(entityId);
            if (customerDto == null)
            {
                TempData["Error"] = "Müşteri Yöneticisi bulunamamıştır!!";
                return RedirectToAction("Index");
            }
                   

            var model = mapper.Map<UpdateCustomerManagerVM>(customerDto);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCustomerManager(UpdateCustomerManagerVM model)
        {
            var entity = await customerManager.GetByIdAsync<UpdateCustomerManagerDTO>(model.Id);

            if (entity == null)
            {
                TempData["Error"] = "Müşteri Yöneticisi bulunamadı!!";
                return View(model);
            }

            mapper.Map(model, entity);

            var result = await customerManager.UpdateAsync(entity, entity.Id);

            if (!result)
            {
                TempData["Error"] = "Müşteri Yöneticisi güncellenemedi!";
                return View(model);

            }

            TempData["Success"] = "Müşteri Yöneticisi başarılı bir şekilde güncellendi!";
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> DeleteCustomerManager(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Müşteri Yöneticisi bulunamamıştır!!";

            }
            else
            {

                var result = await customerManager.DeleteAsync(entityId);
                if (!result)
                {
                    TempData["Error"] = "Müşteri Yöneticisi silinememiştir!";

                }
                else
                {
                    TempData["Success"] = "Müşteri Yöneticisi başarı ile silinmiştir";

                }


            }

            return RedirectToAction(nameof(Index));

        }
    }
}
