using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.ClassroomDTO
{
    public class CreateClassroomDTO : BaseDTO
    {
        public required string Name { get; set; }

      

        public DateOnly StartDate { get; set; }

     
        public DateOnly EndDate { get; set; }

    
        public Guid TeacherId { get; set; }
    }
}
