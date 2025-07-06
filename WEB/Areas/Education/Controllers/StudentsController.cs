using AutoMapper;
using Business.Manager.Interface;
using Core.Entities.Concrete;
using Core.Enums;
using DTO.Concrete.ClassroomDTO;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.StudentDTO;
using DTO.Concrete.TeacherDTO;
using DTO.Concrete.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB.Areas.Education.Models.ClassroomVM;
using WEB.Areas.Education.Models.StudentVM;
using WEB.Areas.Education.Models.TeacherVM;

namespace WEB.Areas.Education.Controllers
{
    [Area("Education")]
    public class StudentsController(
                                    IStudentManager studentManager,
                                    IMapper mapper,
                                    IClassroomManager classroomManager,
                                    ICourseManager courseManager,
                                    ITeacherManager teacherManager, IUserManager userManager, IEmailSender emailSender) : Controller
    {
        private readonly string _uploadImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img");
        private readonly string _uploadProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");


        [Authorize(Roles = "Admin,CustomerManager")]
        public async Task<IActionResult> Index()
        {
            var model = await studentManager.GetFilteredListAsync
                (
                    select: x => mapper.Map<GetStudentVM>(x),
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(x => x.CreatedDate),
                    join: x => x.Include(z => z.Classroom!).ThenInclude(z => z.Teacher!).ThenInclude(z => z.Course!)

                // ! => NFT(Null-Forgiving Operator): Bir verinin null gelmeyeceğini sen biliyosun ama ide bilmiyor. Bu yüzden buranın null gelmeyeceğini garanti ediyorum anlamında ünlem işareti kullanıyoruz.
                );
            return View(model);
        }


        [Authorize(Roles = "Admin,CustomerManager")]
        public async Task<IActionResult> CreateStudent()
        {
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name"
                );

            return View();
        }

        [Authorize(Roles = "Admin,CustomerManager")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent(CreateStudentVM model)
        {
            ViewBag.Courses = new SelectList
                 (
                     await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name"
                 );

            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Aşağıdaki kurallara uyunuz!";
                return View(model);
            }

            //using burayı dispose eder.
            //dispose etmek işi bittikten sonra nesnein silinmesi anlamına gelir. 
            await using var transactionStudent = await studentManager.BeginTransactionAsync();
            await using var transactionUser = await userManager.BeginTransactionAsync();

            try
            {
                var createUserDTO = mapper.Map<CreateUserDTO>(model);
                var createIdentityResult = await userManager.CreateUserAsync(createUserDTO);

                if (!createIdentityResult.Succeeded)
                {
                    TempData["Error"] = "Öğrenci hesabı açılamadı!";
                    return View(model);
                }

                var roleResult = await userManager.AddUserToRoleAsync(model.Email!, "student");
                if (!roleResult.Succeeded)
                {
                    await transactionUser.RollbackAsync();
                    TempData["Error"] = "Öğrenci role eklenemedi!";
                    return View(model);
                }

                string? savedImagePath = null;
                if (model.Image != null && model.Image.Length > 0)
                {
                    var fileName = Guid.NewGuid() + "" + model.FirstName + "" + model.LastName + Path.GetExtension(model.Image.FileName);
                    var uploadPath = Path.Combine(_uploadImagePath, fileName);
                    Directory.CreateDirectory(Path.GetDirectoryName(uploadPath)!);
                    using (var stream = new FileStream(uploadPath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                        stream.Close();
                    }
                    savedImagePath = fileName;
                }

                model.ImagePath = savedImagePath;

                var dto = mapper.Map<CreateStudentDTO>(model);

                var result = await studentManager.AddAsync(dto);

                if (!result)
                {
                    if (!string.IsNullOrEmpty(savedImagePath) && System.IO.File.Exists(savedImagePath))
                    {
                        System.IO.File.Delete(savedImagePath);
                    }
                    await transactionStudent.RollbackAsync();
                    TempData["Error"] = "Öğrenci oluşturulamadı!";
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
                await transactionStudent.CommitAsync();

                TempData["Success"] = "Öğrenci başarılı bir şekilde kaydedildi!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                await transactionUser.RollbackAsync();
                await transactionStudent.RollbackAsync();
                TempData["Error"] = "Bir hata oluştu!";
                return View(model);
            }
        }


        [Authorize(Roles = "Admin,CustomerManager")]
        public async Task<IActionResult> UpdateStudent(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);
            if (!guidResult)
            {
                TempData["Error"] = "Öğrenci bulunamamıştır!";
                return RedirectToAction(nameof(Index));
            }

            var studentDto = await studentManager.GetByIdAsync<UpdateStudentDTO>(entityId);

            if (studentDto == null)
            {
                TempData["Error"] = "Öğrenci bulunamamıştır!";
                return RedirectToAction(nameof(Index));
            }

            var classroom = await classroomManager.GetByIdAsync<GetClassroomForSelectListDTO>(studentDto.ClassroomId);

            var teacher = await teacherManager.GetByIdAsync<GetTeacherForSelectListDTO>(classroom!.TeacherId);

            var course = await courseManager.GetByIdAsync<GetCourseForSelectListDTO>(teacher!.CourseId);

            ViewBag.Courses = new SelectList
               (
                   await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name", course
               );

            var model = mapper.Map<UpdateStudentVM>(studentDto);
            model.ClassroomId = classroom.Id;
            model.TeacherId = teacher.Id;
            model.CourseId = course!.Id;
            return View(model);
        }


        [Authorize(Roles = "Admin,CustomerManager")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateStudent(UpdateStudentVM model)
        {
            ViewBag.Courses = new SelectList
                (
                    await courseManager.GetByDefaultsAsync<GetCourseForSelectListDTO>(x => x.Status != Status.Passive), "Id", "Name", model.CourseId
                );



            var entity = await studentManager.GetByIdAsync<UpdateStudentDTO>(model.Id);
            if (entity == null)
            {
                TempData["Error"] = "Öğrenci bulunamadı!";
                return View(model);
            }

            string? savedImagePath = model.ImagePath;
            if (model.Image != null && model.Image.Length > 0)
            {
                var fileName = Guid.NewGuid() + "" + model.FirstName + "" + model.LastName + Path.GetExtension(model.Image.FileName);
                var uploadPath = Path.Combine(_uploadImagePath, fileName);
                Directory.CreateDirectory(Path.GetDirectoryName(uploadPath)!);
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                    stream.Close();
                }
                savedImagePath = fileName;
            }

            mapper.Map(model, entity);
            entity.ImagePath = savedImagePath;

            var result = await studentManager.UpdateAsync(entity, entity.Id);

            if (!result)
            {
                if (!string.IsNullOrEmpty(savedImagePath) && System.IO.File.Exists(Path.Combine(_uploadImagePath, savedImagePath)))
                {
                    System.IO.File.Delete(Path.Combine(_uploadImagePath, savedImagePath));
                }

                TempData["Error"] = "Öğrenci güncellenemedi!";
                return View(model);
            }

            if (entity.ImagePath != model.ImagePath && !string.IsNullOrEmpty(model.ImagePath) && System.IO.File.Exists(Path.Combine(_uploadImagePath, model.ImagePath)))
            {
                System.IO.File.Delete(Path.Combine(_uploadImagePath, model.ImagePath));
            }

            TempData["Success"] = "Öğrenci başarılı bir şekilde güncellendi!";
            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Admin,CustomerManager")]
        public async Task<IActionResult> DeleteStudent(string id)
        {
            var guidResult = Guid.TryParse(id, out Guid entityId);
            if (!guidResult)
            {
                TempData["Error"] = "Öğrenci bulunamamıştır!";
            }
            else
            {
                var studentDto = await studentManager.GetByIdAsync<UpdateStudentDTO>(entityId);

                if (studentDto == null)
                {
                    TempData["Error"] = "Öğrenci bulunamamıştır!";
                    return RedirectToAction(nameof(Index));
                }

                var result = await studentManager.DeleteAsync(entityId);

                if (!result)
                    TempData["Error"] = "Öğrenci silinememiştir!";
                else
                {

                    if (!string.IsNullOrEmpty(studentDto.ImagePath) && System.IO.File.Exists(Path.Combine(_uploadImagePath, studentDto.ImagePath)))
                        System.IO.File.Delete(Path.Combine(_uploadImagePath, studentDto.ImagePath));
                    TempData["Success"] = "Öğrenci başarılı bir şekilde silinmiştir!";
                }
            }

            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Admin,CustomerManager, Student, Teacher")]
        public async Task<IActionResult> StudentDetail(string? id)
        {
            var userId = await userManager.GetUserIdByClaimsAsync(User);
            var dto = await studentManager.GetByDefaultAsync<StudentDetailDTO>(x => (id != null ? x.Id == Guid.Parse(id) : x.AppUserId == userId) && x.Status != Status.Passive, x => x.Include(z => z.Classroom!).ThenInclude(z => z.Teacher!).ThenInclude(z => z.Course!));

            var model = mapper.Map<StudentDetailVM>(dto);
            return View(model);


        }

        [Authorize(Roles = "Admin,CustomerManager, Student")]
        public async Task<IActionResult> SendProject(StudentDetailVM model)
        {
            var student = await studentManager.GetByIdAsync<StudentDetailDTO>(model.Id);
            if (student == null) return NotFound();
            if (model.Project != null && model.Project.Length > 0)
            {
                var fileName = Guid.NewGuid() + "_" + student.FirstName + "_" + student.LastName + "_" +
                               model.ProjectName + Path.GetExtension(model.Project.FileName);
                var uploadPath = Path.Combine(_uploadProjectPath, fileName);
                Directory.CreateDirectory(Path.GetDirectoryName(uploadPath)!);
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    await model.Project.CopyToAsync(stream);
                    stream.Close();
                }

                student.ProjectPath = fileName;

                var result = await studentManager.UpdateAsync(student, student.Id);
                if (!result)
                {
                    TempData["Error"] = "Yükleme yapılamadı!";
                    return RedirectToAction(nameof(StudentDetail), student);
                }

                TempData["Success"] = "Proje yüklendi!";
            }
            return RedirectToAction(nameof(StudentDetail), student);
        }

        [Authorize(Roles = "Admin,CustomerManager, Student, Teacher")]
        public FileResult Download(string filePath)
        {
            string uploadDir = Path.Combine(_uploadProjectPath, filePath);
            byte[] fileBytes = System.IO.File.ReadAllBytes(uploadDir);

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filePath);

        }

        [Authorize(Roles = "Admin,CustomerManager, Teacher")]
        public async Task<IActionResult> UpdateStudentExams(StudentDetailVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            }
            else
            {
                var dto = await studentManager.GetByIdAsync<StudentDetailDTO>(model.Id);


                if (dto == null)
                    TempData["Error"] = "Öğrenci bulunamadı";
                else
                {
                    mapper.Map(model, dto);
                    var result = await studentManager.UpdateAsync(dto, dto.Id);
                    if (!result)
                        TempData["Error"] = "Notlar güncellenemedi!!";
                    else
                        TempData["Success"] = "Notlar güncellendi!!";

                }
            }

            return RedirectToAction(nameof(StudentDetail), model);

        }

    }
}