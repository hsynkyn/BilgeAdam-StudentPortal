namespace WEB.Areas.Education.Models.ClassroomVM
{
    public class GetClassroomVM
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }


        public DateOnly StartDate { get; set; }


        public DateOnly EndDate { get; set; }


        public required string TeacherName { get; set; }

        public DateTime CreatedDate { get; set; }
        public required string UpdatedDate { get; set; }
        public required string Status { get; set; }
    }
}
