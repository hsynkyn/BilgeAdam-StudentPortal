using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities.Concrete;
using DTO.Concrete.StudentDTO;

namespace Business.AutoMapper
{
    public class StudentBusinessMapping : Profile
    {
        public StudentBusinessMapping()
        {
            CreateMap<Student, CreateStudentDTO>().ReverseMap();
            CreateMap<Student, GetStudentDTO>().ReverseMap();
            CreateMap<Student, StudentDetailDTO>().ReverseMap();
            CreateMap<Student, UpdateStudentDTO>().ReverseMap();

            CreateMap<GetStudentForClassroomDTO, Student>().ReverseMap().ForMember(x => x.FullName, opt => opt.MapFrom(x => x.FirstName + " " + x.LastName)).ForMember(x => x.Average, opt => opt.MapFrom(x => x.Average.HasValue ? x.Average.ToString() : " - "));

            CreateMap<StudentDetailDTO, Student>().ReverseMap().ForMember(x => x.ClassroomName, opt => opt.MapFrom(x => x.Classroom!.Name)).ForMember(x => x.CourseName, opt => opt.MapFrom(x => x.Classroom!.Teacher!.Course!.Name));

        }
    }
}
