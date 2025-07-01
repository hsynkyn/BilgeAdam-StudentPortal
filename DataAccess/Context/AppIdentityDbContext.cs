using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.IdentityEntities;
using DataAccess.SeedData.IdentitySeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : IdentityDbContext<AppUser, AppRole, Guid>(options)
    {
        static AppIdentityDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AppUserSeedData());
            builder.ApplyConfiguration(new AppRoleSeedData());
            builder.ApplyConfiguration(new UserRoleSeedData());

            //builder.Entity<AppRole>().Property(x => x.ConcurrencyStamp).IsConcurrencyToken(false);

        }
    }
}
