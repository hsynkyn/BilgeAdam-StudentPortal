using AutoMapper;
using Business.Manager.Interface;
using Core.Enums;
using DTO.Concrete.CourseDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB.Areas.Education.Models.CourseVM;

namespace WEB.Areas.Education.Controllers
{
    [Area("Education")]

    [Authorize(Roles = "Admin,CustomerManager")]
    public class CoursesController(ICourseManager courseManager, IMapper mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = await courseManager.GetFilteredListAsync
                (
                    select: x => mapper.Map<GetCourseVM>(x),
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(x => x.CreatedDate)
                );
            return View(model);
        }


        public IActionResult CreateCourse() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse(CreateCourseVM model)
        {

            var checkName = await courseManager.AnyAsync(x=>x.Name == model.Name && x.TotalHour == model.TotalHour && x.Status != Status.Passive);

            if (checkName) 
            {
                TempData["Error"] = "Bu kurs zaten kayıtlıdır!!";
                return View(model);
            }

            var dto = mapper.Map<CreateCourseDTO>(model);
            var result = await courseManager.AddAsync(dto);

            if (!result)
            {
                TempData["Error"] = "Kurs oluşturulamadı!";
                return View(model);
            }

            TempData["Success"] = "Kurs başarılı bir şekilde kaydedildi!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateCourse(string id) 
        {            
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Kurs bulunamamıştır!!";
                return RedirectToAction(nameof(Index));
            }

            var courseDto = await courseManager.GetByIdAsync<UpdateCourseDTO>(entityId);
            if(courseDto == null)
            {
                TempData["Error"] = "Kurs bulunamamıştır!!";
                return RedirectToAction("Index");
            }

            var model = mapper.Map<UpdateCourseVM>(courseDto);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCourse(UpdateCourseVM model)
        {

            var nameCheck = await courseManager.AnyAsync(x=>x.Id != model.Id && x.Name == model.Name && x.TotalHour == model.TotalHour && x.Status != Status.Passive);
            if (nameCheck) 
            {
                TempData["Error"] = "Böyle bir kurs bulunmaktadır!!";
                return View(model);
            }            


            var entity = await courseManager.GetByIdAsync<UpdateCourseDTO>(model.Id);

            if (entity == null)
            {
                TempData["Error"] = "Kurs bulunamadı!!";
                return View(model);
            }

            mapper.Map(model, entity);

            var result = await courseManager.UpdateAsync(entity, entity.Id);

            if (!result) 
            {
                TempData["Error"] = "Kurs güncellenemedi!";
                return View(model);

            }

            TempData["Success"] = "Kurs başarılı bir şekilde güncellendi!";
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> DeleteCourse(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Kurs bulunamamıştır!!";
                
            }
            else
            {
                var hasTeacherCheck = await courseManager.AnyAsync(x=>x.Teachers.Where(x=>x.Status != Status.Passive).Count() > 0 && x.Id == entityId && x.Status != Status.Passive);

                if (hasTeacherCheck)
                {
                    TempData["Error"] = "Bu kursa ait eğitmenler vardır. Silinemez!";

                }
                else
                {

                    var result = await courseManager.DeleteAsync(entityId);
                    if (!result)
                    {
                        TempData["Error"] = "Kurs silinememiştir!";

                    }
                    else
                    {
                        TempData["Success"] = "Kurs başarı ile silinmiştir";

                    }
                }

            }

            return RedirectToAction(nameof(Index));

        }
    }
}
