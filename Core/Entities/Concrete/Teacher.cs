using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class Teacher : BasePerson
    {
        public Teacher()
        {
            Classrooms = [];
        }
        [Required]
        public DateOnly HireDate { get; set; }

        [Required]
        public Guid CourseId { get; set; }

        public Course? Course { get; set; }

        public List<Classroom> Classrooms { get; set; }
    }
}
