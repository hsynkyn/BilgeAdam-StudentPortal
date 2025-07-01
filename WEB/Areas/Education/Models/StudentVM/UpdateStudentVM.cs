using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Education.Models.StudentVM
{
    public class UpdateStudentVM : BasePersonVM
    {
        public Guid Id { get; set; }
        public string? ImagePath { get; set; }

        public IFormFile? Image { get; set; }
        public required double RegisterPrice { get; set; }

        public Guid? ClassroomId { get; set; }
        public Guid? CourseId { get; set; }
        public Guid? TeacherId { get; set; }
    }
}
