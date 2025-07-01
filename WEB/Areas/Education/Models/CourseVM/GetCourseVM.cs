using Core.Enums;

namespace WEB.Areas.Education.Models.CourseVM
{
    public class GetCourseVM
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int TotalHour { get; set; }
        public DateTime CreatedDate { get; set; }
        public required string UpdatedDate { get; set; }
        public required string Status { get; set; }

        public required string Description { get; set; }
    }
}

