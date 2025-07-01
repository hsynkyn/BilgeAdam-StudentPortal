using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete.CustomerManagerDTO
{
    public class GetCMDTO
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
