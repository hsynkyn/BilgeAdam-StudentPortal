using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.UserDTO
{
    public class GetUserDTO
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }

        public bool HasFirstPasswordChanged { get; set; }
    }
}
