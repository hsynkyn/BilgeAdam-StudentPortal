using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete.AccountDTO
{
    public class ResetPasswordDTO
    {
        public required string Token { get; set; }
        public required string Email { get; set; }
        public required string NewPassword { get; set; }
    }
}
