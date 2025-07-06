using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.ClassroomDTO
{
    public class GetClassroomForTeacherDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Size { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
