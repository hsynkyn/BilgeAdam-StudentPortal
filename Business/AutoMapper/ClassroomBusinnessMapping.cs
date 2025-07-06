using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities.Concrete;
using DTO.Concrete.ClassroomDTO;


namespace Business.AutoMapper
{
    public class ClassroomBusinnessMapping : Profile
    {
        public ClassroomBusinnessMapping()
        {
            CreateMap<Classroom, CreateClassroomDTO>().ReverseMap();
            CreateMap<Classroom, UpdateClassroomDTO>().ReverseMap();
            CreateMap<Classroom, GetClassroomForSelectListDTO>().ReverseMap();
            CreateMap<GetClassroomForTeacherDTO, Classroom>().ReverseMap().ForMember(x => x.Size, opt => opt.MapFrom(x => x.Students.Count));
        }

    }
}
