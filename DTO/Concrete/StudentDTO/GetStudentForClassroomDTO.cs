using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace DTO.Concrete.StudentDTO
{
    public class GetStudentForClassroomDTO
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string Average { get; set; }
        public StudentStatus StudentStatus { get; set; }
    }
}
