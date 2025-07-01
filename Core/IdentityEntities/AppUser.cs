using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace Core.IdentityEntities
{
    public class AppUser : IdentityUser<Guid>
    {
        public bool HasFirstPasswordChanged { get; set; }
    }
}
