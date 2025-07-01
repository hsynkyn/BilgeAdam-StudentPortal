using AutoMapper;
using Business.Manager.Interface;
using Core.Enums;
using DTO.Concrete.RoleDTO;
using Microsoft.AspNetCore.Mvc;
using WEB.Areas.Admin.Models.RoleVM;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController(IRoleManager roleManager, IMapper mapper, IUserManager userManager) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var dto = await roleManager.GetRolesAsync();
            var model = mapper.Map<List<GetRoleVM>>(dto);
            return View(model);
        }


        public IActionResult CreateRole() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(CreateRoleVM model)
        {

            var checkName = await roleManager.AnyRoleNameAsync(model.Name!);

            if (checkName)
            {
                TempData["Error"] = "Bu rol zaten kayıtlıdır!!";
                return View(model);
            }

            var dto = mapper.Map<CreateRoleDTO>(model);
            var result = await roleManager.AddRoleAsync(dto);

            if (!result)
            {
                TempData["Error"] = "Role oluşturulamadı!";
                return View(model);
            }

            TempData["Success"] = "Rol başarılı bir şekilde kaydedildi!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateRole(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Rol bulunamamıştır!!";
                return RedirectToAction(nameof(Index));
            }

            var roleDto = await roleManager.GetRoleByIdAsync<UpdateRoleDTO>(entityId);
            if (roleDto == null)
            {
                TempData["Error"] = "Rol bulunamamıştır!!";
                return RedirectToAction("Index");
            }

            var model = mapper.Map<UpdateRoleVM>(roleDto);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateRole(UpdateRoleVM model)
        {

            var nameCheck = await roleManager.AnyRoleNameAsync(model.Name!);
            if (nameCheck)
            {
                TempData["Error"] = "Böyle bir rol bulunmaktadır!!";
                return View(model);
            }


            var entity = await roleManager.GetRoleByIdAsync<UpdateRoleDTO>(model.Id);


            if (entity == null)
            {
                TempData["Error"] = "Rol bulunamadı!!";
                return View(model);
            }

            mapper.Map(model, entity);

            var result = await roleManager.UpdateRoleAsync(entity);

            if (!result)
            {
                TempData["Error"] = "Rol güncellenemedi!";
                return View(model);

            }

            TempData["Success"] = "Rol başarılı bir şekilde güncellendi!";
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Rol bulunamamıştır!!";

            }
            else
            {
                var hasUserCheck = await roleManager.AnyUserInRole(entityId);

                if (hasUserCheck)
                {
                    TempData["Error"] = "Bu rola ait kullanıcılar vardır. Silinemez!";

                }
                else
                {

                    var result = await roleManager.DeleteRoleAsync(entityId);
                    if (!result)
                    {
                        TempData["Error"] = "Rol silinememiştir!";

                    }
                    else
                    {
                        TempData["Success"] = "Rol başarı ile silinmiştir";

                    }
                }

            }

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> AssignToRole(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);
            if (!guidResult)
            {
                TempData["Error"] = "Rol bulunamamıştır";
                return RedirectToAction(nameof(Index));
            }

            var role = await roleManager.GetRoleByIdAsync<GetRoleDTO>(entityId);

            if (role == null)
            {
                TempData["Error"] = "Rol bulunamamıştır!";
                return RedirectToAction(nameof(Index));
            }

            var hasRole = await userManager.GetUsersHasRoleAsync(role.Name);
            var hasNotRole = await userManager.GetUsersHasNotRoleAsync(role.Name);

            var model = new AssignToRoleVM()
            {
                RoleName = role.Name,
                HasRole = mapper.Map<List<GetUserForRoleVM>>(hasRole),
                HasNotRole = mapper.Map<List<GetUserForRoleVM>>(hasNotRole)
            };

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignToRole(AssignToRoleVM model)
        {
            await using var transaction = await userManager.BeginTransactionAsync();
            try
            {

                foreach (var userId in model.AddIds)
                {
                    var result = await userManager.AddUserToRoleAsync(Guid.Parse(userId), model.RoleName);

                    if (result.Succeeded) continue;

                    TempData["Error"] = "İşlem başarısız!!";
                    return View(model);

                }

                foreach (var userId in model.DeleteIds)
                {
                    var result = await userManager.RemoveUserFromRoleAsync(Guid.Parse(userId), model.RoleName);

                    if (result.Succeeded) continue;

                    await transaction.RollbackAsync();
                    TempData["Error"] = "İşlem başarısız!!";
                    return View(model);


                }

                await transaction.CommitAsync();
                TempData["Success"] = "İşlem başarılıdır";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                await transaction.RollbackAsync();
                TempData["Error"] = "İşlem başarısız!!";
                return View(model);
            }

        }

    }
}
