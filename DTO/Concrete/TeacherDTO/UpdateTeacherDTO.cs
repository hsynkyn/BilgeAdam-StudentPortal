using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.TeacherDTO
{
    public class UpdateTeacherDTO : BasePersonDTO
    {
        public Guid Id { get; set; }
        public DateOnly HireDate { get; set; }

        public Guid CourseId { get; set; }
    }
}
