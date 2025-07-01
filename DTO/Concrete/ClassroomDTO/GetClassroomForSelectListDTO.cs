using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.ClassroomDTO
{
    public class GetClassroomForSelectListDTO : BaseDTO
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public Guid TeacherId { get; set; }
    }
}
