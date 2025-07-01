using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.StudentDTO
{
    public class UpdateStudentDTO : BasePersonDTO
    {
        public Guid Id { get; set; }
        public string? ImagePath { get; set; }

        public double RegisterPrice { get; set; }

        public Guid ClassroomId { get; set; }
    }
}
