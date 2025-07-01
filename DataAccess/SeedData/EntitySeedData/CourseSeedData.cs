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
    public class CourseSeedData : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData
                (
                new Course
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Yapay Zeka",
                    TotalHour = 120,
                    Description = "Yapay Zeka Eğitimi"
                },
            new Course
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Web Programlama",
                TotalHour = 100,
                Description = ".Net Core MVC"
            }
                );
        }
    }
}
