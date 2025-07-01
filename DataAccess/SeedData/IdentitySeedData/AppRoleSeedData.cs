using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.IdentityEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class AppRoleSeedData : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole { Id = Guid.Parse("99999999-0000-0000-0000-000000000001"), Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole { Id = Guid.Parse("99999999-0000-0000-0000-000000000002"), Name = "Student", NormalizedName = "STUDENT" },
                new AppRole { Id = Guid.Parse("99999999-0000-0000-0000-000000000003"), Name = "Teacher", NormalizedName = "TEACHER" },
                new AppRole { Id = Guid.Parse("99999999-0000-0000-0000-000000000004"), Name = "CustomerManager", NormalizedName = "CUSTOMERMANAGER" }
            );
        }
    }
}
