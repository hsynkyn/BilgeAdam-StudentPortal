using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class Classroom : BaseEntity
    {
        public Classroom()
        {
            Students = [];
        }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public required string Name { get; set; }


        [Required]
        public DateOnly StartDate { get; set; }

        [Required]
        public DateOnly EndDate { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        public Teacher? Teacher { get; set; }

        public List<Student> Students { get; set; }
    }
}
