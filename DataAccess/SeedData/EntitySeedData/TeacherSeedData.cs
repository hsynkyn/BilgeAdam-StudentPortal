using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData.EntitySeedData
{
    public class TeacherSeedData : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
            (
                new Teacher
                {
                    Id = Guid.Parse("aaa00001-0000-0000-0000-000000000001"),
                    AppUserId = Guid.Parse("c0000001-0000-0000-0000-000000000001"), // Ali
                    FirstName = "Ali",
                    LastName = "Yılmaz",
                    Email = "ali@example.com",
                    Birthdate = new DateOnly(1985, 6, 10),
                    HireDate = new DateOnly(2020, 1, 1),
                    CourseId = Guid.Parse("11111111-1111-1111-1111-111111111111")
                },
                new Teacher
                {
                    Id = Guid.Parse("aaa00002-0000-0000-0000-000000000002"),
                    AppUserId = Guid.Parse("c0000001-0000-0000-0000-000000000002"), // Ayşe
                    FirstName = "Ayşe",
                    LastName = "Demir",
                    Email = "ayse@example.com",
                    Birthdate = new DateOnly(1990, 3, 15),
                    HireDate = new DateOnly(2021, 2, 10),
                    CourseId = Guid.Parse("11111111-1111-1111-1111-111111111111")
                },
                new Teacher
                {
                    Id = Guid.Parse("aaa00003-0000-0000-0000-000000000003"),
                    AppUserId = Guid.Parse("c0000001-0000-0000-0000-000000000003"), // Mehmet
                    FirstName = "Mehmet",
                    LastName = "Kaya",
                    Email = "mehmet@example.com",
                    Birthdate = new DateOnly(1980, 8, 22),
                    HireDate = new DateOnly(2019, 9, 5),
                    CourseId = Guid.Parse("22222222-2222-2222-2222-222222222222")
                },
                new Teacher
                {
                    Id = Guid.Parse("aaa00004-0000-0000-0000-000000000004"),
                    AppUserId = Guid.Parse("c0000001-0000-0000-0000-000000000004"), // Elif
                    FirstName = "Elif",
                    LastName = "Aydın",
                    Email = "elif@example.com",
                    Birthdate = new DateOnly(1992, 11, 30),
                    HireDate = new DateOnly(2022, 5, 25),
                    CourseId = Guid.Parse("22222222-2222-2222-2222-222222222222")
                }
            );
        }
    }
}
