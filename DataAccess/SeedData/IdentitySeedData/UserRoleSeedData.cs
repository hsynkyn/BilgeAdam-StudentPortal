using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class UserRoleSeedData : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
           
            builder.HasData
                (
                new IdentityUserRole<Guid> { UserId = Guid.Parse("a0000001-0000-0000-0000-000000000001"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000001") },

    // Students
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000001"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000002"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000003"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000004"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000005"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000006"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000007"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000008"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000009"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000010"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000011"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000012"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000013"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000014"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("b0000001-0000-0000-0000-000000000015"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000002") },

    // Teachers
    new IdentityUserRole<Guid> { UserId = Guid.Parse("c0000001-0000-0000-0000-000000000001"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000003") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("c0000001-0000-0000-0000-000000000002"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000003") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("c0000001-0000-0000-0000-000000000003"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000003") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("c0000001-0000-0000-0000-000000000004"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000003") },

    // Customer Managers
    new IdentityUserRole<Guid> { UserId = Guid.Parse("d0000001-0000-0000-0000-000000000001"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000004") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("d0000001-0000-0000-0000-000000000002"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000004") },
    new IdentityUserRole<Guid> { UserId = Guid.Parse("d0000001-0000-0000-0000-000000000003"), RoleId = Guid.Parse("99999999-0000-0000-0000-000000000004") }

                );
        }
    }
}
