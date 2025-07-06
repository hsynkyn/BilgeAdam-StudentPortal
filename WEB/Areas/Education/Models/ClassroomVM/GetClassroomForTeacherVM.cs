namespace WEB.Areas.Education.Models.ClassroomVM
{
    public class GetClassroomForTeacherVM
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Size { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
