using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.CourseDTO
{
    public class UpdateCourseDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int TotalHour { get; set; }
        public required string Description { get; set; }
    }
}
