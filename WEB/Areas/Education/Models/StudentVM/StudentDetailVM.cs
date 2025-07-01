using System.ComponentModel.DataAnnotations;
using Core.Enums;

namespace WEB.Areas.Education.Models.StudentVM
{
    public class StudentDetailVM
    {
        public Guid Id { get; set; }

        [Display(Name = "Ad")]
        public required string FirstName { get; set; }

        [Display(Name = "Soyad")]
        public required string LastName { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateOnly BirthDate { get; set; }

        [Display(Name = "E-Mail")]
        public required string Email { get; set; }

        [Display(Name = "1. Sınav")]
        public double? Exam1 { get; set; }

        [Display(Name = "2. Sınav")]
        public double? Exam2 { get; set; }

        [Display(Name = "Proje Sınavı")]
        public double? ProjectExam { get; set; }

        [Display(Name = "Ortalama")]
        public double? Average { get; set; }

        public string? ProjectPath { get; set; }

        [Display(Name = "Proje Dosyası Yükleme")]
        public IFormFile? Project { get; set; }

        [Display(Name = "Proje Adı")]
        public string? ProjectName { get; set; }
        public string? ImagePath { get; set; }

        [Display(Name = "Kayıt Ücreti")]
        public double RegisterPrice { get; set; }

        public Guid ClassroomId { get; set; }

        [Display(Name = "Sınıf Adı")]
        public required string ClassroomName { get; set; }

        [Display(Name ="Kurs Adı")]
        public required string CourseName { get; set; }

        [Display(Name = "Öğrenci Durumu")]
        public required string StudentStatus { get; set; }

    }
}
