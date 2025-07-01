using System.Reflection.Metadata.Ecma335;
using Core.Enums;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Education.Models.StudentVM
{
    public class GetStudentVM  :BasePersonVM
    {
        public Guid Id { get; set; }
        public required string? ImagePath { get; set; }

        public required double RegisterPrice { get; set; }

        public required string CourseName{ get; set; }

        public required string StudentStatus { get; set; }
        public required DateTime CreatedDate { get; set; }

        public required string UpdatedDate { get; set; }
        public required string Status { get; set; }
    }
}
