using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.TeacherDTO
{
    public class CreateTeacherDTO : BasePersonDTO
    {
        public DateOnly HireDate { get; set; }

        public Guid CourseId { get; set; }
    }
}
