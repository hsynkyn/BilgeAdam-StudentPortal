using Core.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class AppUserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            var users = new List<AppUser>
            {
                new AppUser
                {
                    Id = Guid.Parse("a0000001-0000-0000-0000-000000000001"),
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = hasher.HashPassword(null!, "123")
                },
 
                // Students
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000001"), HasFirstPasswordChanged = true, UserName = "ahmet1", NormalizedUserName = "AHMET1", Email = "ahmet1@mail.com", NormalizedEmail = "AHMET1@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000002"), HasFirstPasswordChanged = true, UserName = "busra2", NormalizedUserName = "BUSRA2", Email = "busra2@mail.com", NormalizedEmail = "BUSRA2@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000003"), HasFirstPasswordChanged = true, UserName = "can3", NormalizedUserName = "CAN3", Email = "can3@mail.com", NormalizedEmail = "CAN3@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000004"), HasFirstPasswordChanged = true, UserName = "deniz4", NormalizedUserName = "DENIZ4", Email = "deniz4@mail.com", NormalizedEmail = "DENIZ4@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000005"), HasFirstPasswordChanged = true, UserName = "emre5", NormalizedUserName = "EMRE5", Email = "emre5@mail.com", NormalizedEmail = "EMRE5@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123*") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000006"), HasFirstPasswordChanged = true, UserName = "fatma6", NormalizedUserName = "FATMA6", Email = "fatma6@mail.com", NormalizedEmail = "FATMA6@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123*") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000007"), HasFirstPasswordChanged = true, UserName = "gokhan7", NormalizedUserName = "GOKHAN7", Email = "gokhan7@mail.com", NormalizedEmail = "GOKHAN7@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000008"), HasFirstPasswordChanged = true, UserName = "hale8", NormalizedUserName = "HALE8", Email = "hale8@mail.com", NormalizedEmail = "HALE8@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000009"), HasFirstPasswordChanged = true, UserName = "ismail9", NormalizedUserName = "ISMAIL9", Email = "ismail9@mail.com", NormalizedEmail = "ISMAIL9@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000010"), HasFirstPasswordChanged = true, UserName = "jale10", NormalizedUserName = "JALE10", Email = "jale10@mail.com", NormalizedEmail = "JALE10@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000011"), HasFirstPasswordChanged = true, UserName = "kaan11", NormalizedUserName = "KAAN11", Email = "kaan11@mail.com", NormalizedEmail = "KAAN11@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000012"), HasFirstPasswordChanged = true, UserName = "leyla12", NormalizedUserName = "LEYLA12", Email = "leyla12@mail.com", NormalizedEmail = "LEYLA12@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000013"), HasFirstPasswordChanged = true, UserName = "mert13", NormalizedUserName = "MERT13", Email = "mert13@mail.com", NormalizedEmail = "MERT13@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000014"), HasFirstPasswordChanged = true, UserName = "nazli14", NormalizedUserName = "NAZLI14", Email = "nazli14@mail.com", NormalizedEmail = "NAZLI14@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("b0000001-0000-0000-0000-000000000015"), HasFirstPasswordChanged = true, UserName = "onur15", NormalizedUserName = "ONUR15", Email = "onur15@mail.com", NormalizedEmail = "ONUR15@MAIL.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
 
                // Teachers
                new AppUser { Id = Guid.Parse("c0000001-0000-0000-0000-000000000003"), HasFirstPasswordChanged = true, UserName = "mehmet", NormalizedUserName = "MEHMET", Email = "mehmet@example.com", NormalizedEmail = "MEHMET@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("c0000001-0000-0000-0000-000000000004"), HasFirstPasswordChanged = true, UserName = "elif", NormalizedUserName = "ELIF", Email = "elif@example.com", NormalizedEmail = "ELIF@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("c0000001-0000-0000-0000-000000000001"), HasFirstPasswordChanged = true, UserName = "ali", NormalizedUserName = "ALI", Email = "ali@example.com", NormalizedEmail = "ALI@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("c0000001-0000-0000-0000-000000000002"), HasFirstPasswordChanged = true, UserName = "ayse", NormalizedUserName = "AYSE", Email = "ayse@example.com", NormalizedEmail = "AYSE@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
 
                // Customer Managers
                new AppUser { Id = Guid.Parse("d0000001-0000-0000-0000-000000000001"), HasFirstPasswordChanged = true, UserName = "zeynep", NormalizedUserName = "ZEYNEP", Email = "zeynep.yilmaz@example.com", NormalizedEmail = "ZEYNEP.YILMAZ@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("d0000001-0000-0000-0000-000000000002"), HasFirstPasswordChanged = true, UserName = "burak", NormalizedUserName = "BURAK", Email = "burak.koc@example.com", NormalizedEmail = "BURAK.KOC@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") },
                new AppUser { Id = Guid.Parse("d0000001-0000-0000-0000-000000000003"), HasFirstPasswordChanged = true, UserName = "derya", NormalizedUserName = "DERYA", Email = "derya.ates@example.com", NormalizedEmail = "DERYA.ATES@EXAMPLE.COM", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString("D"), PasswordHash = hasher.HashPassword(null!, "123") }
            };

            builder.HasData(users);
        }

    }
}