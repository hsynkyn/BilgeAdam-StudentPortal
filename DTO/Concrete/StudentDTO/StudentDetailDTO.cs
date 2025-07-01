using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;
using DTO.Abstract;

namespace DTO.Concrete.StudentDTO
{
    public class StudentDetailDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public required string Email { get; set; }
        public double? Exam1 { get; set; }
        public double? Exam2 { get; set; }
        public double? ProjectExam { get; set; }
        public double? Average { get; set; }
        public string? ProjectPath { get; set; }
        public string? ProjectName { get; set; }
        public string? ImagePath { get; set; }
        public double RegisterPrice { get; set; }
        public Guid ClassroomId { get; set; }
        public required string ClassroomName { get; set; }
        public required string CourseName { get; set; }
        public StudentStatus StudentStatus { get; set; }
    }
}
