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
    public class StudentSeedData : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000001"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000001"), // Ahmet
                        FirstName = "Ahmet",
                        LastName = "Yıldız",
                        Email = "ahmet1@mail.com",
                        Birthdate = new DateOnly(2000, 5, 10),
                        Exam1 = 70,
                        Exam2 = 80,
                        ProjectExam = 90,
                        RegisterPrice = 1500,
                        ClassroomId = Guid.Parse("c1000000-0000-0000-0000-000000000001"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000002"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000002"), // Büşra
                        FirstName = "Büşra",
                        LastName = "Demir",
                        Email = "busra2@mail.com",
                        Birthdate = new DateOnly(1999, 3, 15),
                        Exam1 = 60,
                        Exam2 = 75,
                        ProjectExam = 85,
                        RegisterPrice = 1450,
                        ClassroomId = Guid.Parse("c1000000-0000-0000-0000-000000000001"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000003"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000003"), // Can
                        FirstName = "Can",
                        LastName = "Kara",
                        Email = "can3@mail.com",
                        Birthdate = new DateOnly(2001, 8, 20),
                        Exam1 = 55,
                        Exam2 = 65,
                        ProjectExam = 75,
                        RegisterPrice = 1350,
                        ClassroomId = Guid.Parse("c1000000-0000-0000-0000-000000000001"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000004"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000004"), // Deniz
                        FirstName = "Deniz",
                        LastName = "Aydın",
                        Email = "deniz4@mail.com",
                        Birthdate = new DateOnly(2000, 11, 5),
                        Exam1 = 45,
                        Exam2 = 50,
                        ProjectExam = 70,
                        RegisterPrice = 1400,
                        ClassroomId = Guid.Parse("c1000000-0000-0000-0000-000000000001"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000005"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000005"), // Emre
                        FirstName = "Emre",
                        LastName = "Aslan",
                        Email = "emre5@mail.com",
                        Birthdate = new DateOnly(2000, 6, 1),
                        Exam1 = 85,
                        Exam2 = 90,
                        ProjectExam = 95,
                        RegisterPrice = 1600,
                        ClassroomId = Guid.Parse("c1000000-0000-0000-0000-000000000001"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000006"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000006"), // Fatma
                        FirstName = "Fatma",
                        LastName = "Çelik",
                        Email = "fatma6@mail.com",
                        Birthdate = new DateOnly(2000, 1, 10),
                        Exam1 = 50,
                        Exam2 = 55,
                        ProjectExam = 60,
                        RegisterPrice = 1250,
                        ClassroomId = Guid.Parse("c2000000-0000-0000-0000-000000000002"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000007"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000007"), // Gökhan
                        FirstName = "Gökhan",
                        LastName = "Şimşek",
                        Email = "gokhan7@mail.com",
                        Birthdate = new DateOnly(1999, 12, 15),
                        Exam1 = 65,
                        Exam2 = 70,
                        ProjectExam = 75,
                        RegisterPrice = 1300,
                        ClassroomId = Guid.Parse("c2000000-0000-0000-0000-000000000002"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000008"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000008"), // Hale
                        FirstName = "Hale",
                        LastName = "Yalçın",
                        Email = "hale8@mail.com",
                        Birthdate = new DateOnly(2001, 2, 25),
                        Exam1 = 90,
                        Exam2 = 95,
                        ProjectExam = 100,
                        RegisterPrice = 1700,
                        ClassroomId = Guid.Parse("c2000000-0000-0000-0000-000000000002"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000009"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000009"), // İsmail
                        FirstName = "İsmail",
                        LastName = "Öztürk",
                        Email = "ismail9@mail.com",
                        Birthdate = new DateOnly(2000, 4, 3),
                        Exam1 = 70,
                        Exam2 = 65,
                        ProjectExam = 80,
                        RegisterPrice = 1500,
                        ClassroomId = Guid.Parse("c2000000-0000-0000-0000-000000000002"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000010"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000010"), // Jale
                        FirstName = "Jale",
                        LastName = "Bilgin",
                        Email = "jale10@mail.com",
                        Birthdate = new DateOnly(2000, 9, 9),
                        Exam1 = 60,
                        Exam2 = 60,
                        ProjectExam = 65,
                        RegisterPrice = 1400,
                        ClassroomId = Guid.Parse("c2000000-0000-0000-0000-000000000002"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000011"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000011"), // Kaan
                        FirstName = "Kaan",
                        LastName = "Bozkurt",
                        Email = "kaan11@mail.com",
                        Birthdate = new DateOnly(2001, 5, 12),
                        Exam1 = 80,
                        Exam2 = 85,
                        ProjectExam = 75,
                        RegisterPrice = 1550,
                        ClassroomId = Guid.Parse("c3000000-0000-0000-0000-000000000003"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000012"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000012"), // Leyla
                        FirstName = "Leyla",
                        LastName = "Karaca",
                        Email = "leyla12@mail.com",
                        Birthdate = new DateOnly(2001, 1, 8),
                        Exam1 = 55,
                        Exam2 = 60,
                        ProjectExam = 70,
                        RegisterPrice = 1350,
                        ClassroomId = Guid.Parse("c3000000-0000-0000-0000-000000000003"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000013"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000013"), // Mert
                        FirstName = "Mert",
                        LastName = "Tunç",
                        Email = "mert13@mail.com",
                        Birthdate = new DateOnly(2001, 7, 17),
                        Exam1 = 65,
                        Exam2 = 50,
                        ProjectExam = 60,
                        RegisterPrice = 1250,
                        ClassroomId = Guid.Parse("c3000000-0000-0000-0000-000000000003"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000014"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000014"), // Nazlı
                        FirstName = "Nazlı",
                        LastName = "Kurt",
                        Email = "nazli14@mail.com",
                        Birthdate = new DateOnly(2000, 6, 30),
                        Exam1 = 75,
                        Exam2 = 85,
                        ProjectExam = 90,
                        RegisterPrice = 1600,
                        ClassroomId = Guid.Parse("c3000000-0000-0000-0000-000000000003"),
                        ProjectPath = "defaultProject.zip"
                    },
                    new Student
                    {
                        Id = Guid.Parse("dddddd00-0000-0000-0000-000000000015"),
                        AppUserId = Guid.Parse("b0000001-0000-0000-0000-000000000015"), // Onur
                        FirstName = "Onur",
                        LastName = "Yavuz",
                        Email = "onur15@mail.com",
                        Birthdate = new DateOnly(2001, 10, 10),
                        Exam1 = 90,
                        Exam2 = 90,
                        ProjectExam = 85,
                        RegisterPrice = 1650,
                        ClassroomId = Guid.Parse("c3000000-0000-0000-0000-000000000003"),
                        ProjectPath = "defaultProject.zip"
                    }
                );
        }
    }
}
