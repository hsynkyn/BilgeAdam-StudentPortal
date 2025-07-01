using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public abstract class BasePerson : BaseEntity
    {
        public Guid AppUserId { get; set; }


        [MaxLength(100)]
        [MinLength(2)]
        [Required]
        public required string FirstName { get; set; }

        [MaxLength(100)]
        [MinLength(2)]
        [Required]
        public required string LastName { get; set; }

        [EmailAddress]
        [Required]
        public required string Email { get; set; }

        [Required]
        public DateOnly Birthdate { get; set; }
    }
}
