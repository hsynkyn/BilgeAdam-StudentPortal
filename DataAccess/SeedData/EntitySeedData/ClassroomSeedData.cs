using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData.EntitySeedData
{
    public class ClassroomSeedData : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasData
                (
                new Classroom
                {
                    Id = Guid.Parse("c1000000-0000-0000-0000-000000000001"),
                    Name = "A Blok 101",
                    
                    StartDate = new DateOnly(2024, 10, 1),
                    EndDate = new DateOnly(2025, 3, 1),
                    TeacherId = Guid.Parse("aaa00001-0000-0000-0000-000000000001") // Ali Yılmaz
                },
            new Classroom
            {
                Id = Guid.Parse("c2000000-0000-0000-0000-000000000002"),
                Name = "B Blok 202",
                
                StartDate = new DateOnly(2024, 9, 15),
                EndDate = new DateOnly(2025, 2, 15),
                TeacherId = Guid.Parse("aaa00003-0000-0000-0000-000000000003") // Mehmet Kaya
            },
            new Classroom
            {
                Id = Guid.Parse("c3000000-0000-0000-0000-000000000003"),
                Name = "C Blok 303",
                
                StartDate = new DateOnly(2024, 11, 1),
                EndDate = new DateOnly(2025, 4, 30),
                TeacherId = Guid.Parse("aaa00002-0000-0000-0000-000000000002") // Ayşe Demir
            }
                );
        }
    }
}
