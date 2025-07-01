using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Abstract
{
    public abstract class BasePersonDTO : BaseDTO
    {
        public Guid AppUserId { get; set; }
        public required string FirstName { get; set; }


        public required string LastName { get; set; }


        public required string Email { get; set; }


        public DateOnly Birthdate { get; set; }
    }
}
