using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.CustomerManagerDTO
{
    public class UpdateCustomerManagerDTO : BasePersonDTO
    {
        public Guid Id { get; set; }
        public DateOnly HireDate { get; set; }
    }
}
