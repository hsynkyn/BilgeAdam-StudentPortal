using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class CustomerManager : BasePerson
    {
        [Required]
        public DateOnly HireDate { get; set; }
    }
}
