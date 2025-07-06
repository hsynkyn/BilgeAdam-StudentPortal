using AutoMapper;
using Business.Manager.Interface;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.ClassroomDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB.Areas.Education.Models.ClassroomVM;
using Core.Enums;
using Microsoft.EntityFrameworkCore;
using DTO.Concrete.TeacherDTO;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace WEB.Areas.Education.Controllers
{
    [Area("Education")]
    [Authorize(Roles = "Admin,CustomerManager")]
    public class ClassroomsController(IClassroomManager classroomManager, IMapper mapper, ITeacherManager teacherManager) : Controller
    {
        private readonly IClassroomManager _classroomManager = classroomManager;
        private readonly IMapper _mapper = mapper;
        private readonly ITeacherManager _teacherManager = teacherManager;


        public async Task<IActionResult> Index()
        {
            var model = await _classroomManager.GetFilteredListAsync
                (
                    select: x => _mapper.Map<GetClassroomVM>(x),
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(x => x.CreatedDate),
                    join: x => x.Include(z => z.Teacher!)

                    // ! => NFT(Null Forgiving Operator): Bir verinin null gelmeyeceğini sen biliyorsun ama ide bilmiyor. Bu yüzden buranın null gelmeyeceğini garanti ediyorum anlamında ünlem işareti kullanıyoruz.
                    );
            return View(model);
        }



        public async Task<IActionResult> CreateClassroom()
        {
            ViewBag.Teachers = new SelectList
                (
                    await _teacherManager.GetByDefaultsAsync<GetTeacherForSelectListDTO>(x => x.Status != Status.Passive), "Id", "FullName"
                );
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateClassroom(CreateClassroomVM model)
        {
            ViewBag.Teachers = new SelectList
                (
                    await _teacherManager.GetByDefaultsAsync<GetTeacherForSelectListDTO>(x => x.Status != Status.Passive), "Id", "FullName"
                );

           
               

            var dto = _mapper.Map<CreateClassroomDTO>(model);
            var result = await _classroomManager.AddAsync(dto);

            if (!result)
            {
                TempData["Error"] = "Sınıf oluşturulamadı!";
                return View(model);
            }

            TempData["Success"] = "Sınıf başarılı bir şekilde kaydedildi!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateClassroom(string id)
        {
            ViewBag.Teachers = new SelectList
                (
                    await _teacherManager.GetByDefaultsAsync<GetTeacherForSelectListDTO>(x => x.Status != Status.Passive), "Id", "FullName"
                );


            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Sınıf bulunamamıştır!!";
                return RedirectToAction(nameof(Index));
            }

            var classroomDto = await _classroomManager.GetByIdAsync<UpdateClassroomDTO>(entityId);
            if (classroomDto == null)
            {
                TempData["Error"] = "Sınıf bulunamamıştır!!";
                return RedirectToAction("Index");
            }

            var teacher = await _teacherManager.GetByIdAsync<GetTeacherForSelectListDTO>(classroomDto.TeacherId);
            ViewBag.Teachers = new SelectList
                (
                    await _teacherManager.GetByDefaultsAsync<GetTeacherForSelectListDTO>(x => x.Status != Status.Passive), "Id", "FullName", teacher
                );

            var model = _mapper.Map<UpdateClassroomVM>(classroomDto);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateClassroom(UpdateClassroomVM model)
        {
            var teacher = await _teacherManager.GetByIdAsync<GetTeacherForSelectListDTO>((Guid)model.TeacherId!);
            ViewBag.Teachers = new SelectList
                (
                    await _teacherManager.GetByDefaultsAsync<GetTeacherForSelectListDTO>(x => x.Status != Status.Passive), "Id", "FullName", teacher
                );



            var entity = await _classroomManager.GetByIdAsync<UpdateClassroomDTO>(model.Id);

            if (entity == null)
            {
                TempData["Error"] = "Sınıf bulunamadı!!";
                return View(model);
            }

            _mapper.Map(model, entity);

            var result = await _classroomManager.UpdateAsync(entity, entity.Id);

            if (!result)
            {
                TempData["Error"] = "Sınıf güncellenemedi!";
                return View(model);

            }

            TempData["Success"] = "Sınıf başarılı bir şekilde güncellendi!";
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> DeleteClassroom(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Sınıf bulunamamıştır!!";

            }
            else
            {

                var hasStudentCheck = await _classroomManager.AnyAsync(x=>x.Id == entityId && x.Status != Status.Passive && x.Students.Where(z=> z.Status != Status.Passive).Count() > 0);

                if (hasStudentCheck)
                    TempData["Error"] = "Bu sınıfta öğrenciler kayıtlıdır. Silinemez!";
                else
                {
                    var result = await _classroomManager.DeleteAsync(entityId);
                    if (!result)
                    {
                        TempData["Error"] = "Sınıf silinememiştir!";

                    }
                    else
                    {
                        TempData["Success"] = "Sınıf başarı ile silinmiştir";

                    }
                }
            }

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> GetClassroomsByTeacherId(string teacherId)
        {
            var guidResult = Guid.TryParse(teacherId, out Guid entityId);

            if (!guidResult)
            {
                TempData["Error"] = "Sınıf bulunamamıştır!!";

            }
            else
            {
                var teachers = await _classroomManager.GetByDefaultsAsync<GetClassroomForSelectListDTO>(x => x.TeacherId == entityId && x.Status != Status.Passive);
                return Json(teachers);
            }
            return NotFound();
        }
    }
}

