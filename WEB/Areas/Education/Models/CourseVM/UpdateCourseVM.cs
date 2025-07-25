﻿using System.ComponentModel.DataAnnotations;

namespace WEB.Areas.Education.Models.CourseVM
{
    public class UpdateCourseVM
    {
        public Guid Id { get; set; }

        [Display(Name = "Kurs Adı")]
        public string? Name { get; set; }

        [Display(Name = "Toplam Saat")]
        public int? TotalHour { get; set; }

        [Display(Name = "Sınıf Açıklaması")]
        public string? Description { get; set; }
    }
}
