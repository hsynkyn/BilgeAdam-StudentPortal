using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities.Concrete;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.TeacherDTO;

namespace Business.AutoMapper
{
    public class TeacherBusinessMapping : Profile
    {
        public TeacherBusinessMapping()
        {
            CreateMap<Teacher, CreateTeacherDTO>().ReverseMap();
            CreateMap<Teacher, GetTeacherDTO>().ReverseMap();
            CreateMap<Teacher, UpdateTeacherDTO>().ReverseMap();
            CreateMap<GetTeacherForSelectListDTO, Teacher>().ReverseMap().ForMember(dest => dest.FullName, src => src.MapFrom(z=> z.FirstName + " " + z.LastName));


        }
    }
}
