namespace WEB.Areas.Education.Models.StudentVM
{
    public class GetStudentForClassroomVM
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string Average { get; set; }
        public required string StudentStatus { get; set; }
    }
}
