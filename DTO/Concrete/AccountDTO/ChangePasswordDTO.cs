using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete.AccountDTO
{
    public class ChangePasswordDTO
    {
        public Guid Id { get; set; }
        public required string OldPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}
