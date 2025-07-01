using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class Course : BaseEntity
    {
        public Course()
        {
            Teachers = [];
        }

        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public required string Name { get; set; }

        public int TotalHour { get; set; }


        [Required]
        [MaxLength(200)]
        [MinLength(3)]
        public required string Description { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
