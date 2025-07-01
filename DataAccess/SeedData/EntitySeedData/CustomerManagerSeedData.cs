using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.EntitySeedData
{
    public class CustomerManagerSeedData : IEntityTypeConfiguration<CustomerManager>
    {
        public void Configure(EntityTypeBuilder<CustomerManager> builder)
        {
            builder.HasData
            (
                new CustomerManager
                {
                    Id = Guid.Parse("e0000001-0000-0000-0000-000000000001"),
                    AppUserId = Guid.Parse("d0000001-0000-0000-0000-000000000001"), // Zeynep
                    FirstName = "Zeynep",
                    LastName = "Yılmaz",
                    Email = "zeynep.yilmaz@example.com",
                    Birthdate = new DateOnly(1990, 4, 15),
                    HireDate = new DateOnly(2022, 1, 10)
                },
                new CustomerManager
                {
                    Id = Guid.Parse("e0000001-0000-0000-0000-000000000002"),
                    AppUserId = Guid.Parse("d0000001-0000-0000-0000-000000000002"), // Burak
                    FirstName = "Burak",
                    LastName = "Koç",
                    Email = "burak.koc@example.com",
                    Birthdate = new DateOnly(1988, 9, 25),
                    HireDate = new DateOnly(2021, 11, 5)
                },
                new CustomerManager
                {
                    Id = Guid.Parse("e0000001-0000-0000-0000-000000000003"),
                    AppUserId = Guid.Parse("d0000001-0000-0000-0000-000000000003"), // Derya
                    FirstName = "Derya",
                    LastName = "Ateş",
                    Email = "derya.ates@example.com",
                    Birthdate = new DateOnly(1992, 6, 30),
                    HireDate = new DateOnly(2023, 3, 1)
                }
            );
        }
    }

}