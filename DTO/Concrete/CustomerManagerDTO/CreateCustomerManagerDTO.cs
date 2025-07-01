using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.CourseDTO
{
    public class CreateCustomerManagerDTO : BasePersonDTO
    {
        public DateOnly HireDate { get; set; }
    }
}
