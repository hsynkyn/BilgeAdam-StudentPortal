using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities.Concrete;
using DTO.Concrete.CourseDTO;

namespace Business.AutoMapper
{
    public class CourseBusinessMapping : Profile
    {
        public CourseBusinessMapping()
        {
            CreateMap<Course, CreateCourseDTO>().ReverseMap();
            CreateMap<Course, UpdateCourseDTO>().ReverseMap();
            CreateMap<Course, GetCourseForSelectListDTO>().ReverseMap();
        }
    }
}
