using AutoMapper;
using Core.Entities.Concrete;
using Core.Extensions;
using DTO.Concrete.ClassroomDTO;
using DTO.Concrete.TeacherDTO;
using WEB.Areas.Education.Models.ClassroomVM;
using WEB.Areas.Education.Models.TeacherVM;

namespace WEB.AutoMapper
{
    public class ClassroomMapping : Profile
    {
        public ClassroomMapping()
        {
            CreateMap<GetClassroomVM, Classroom>().ReverseMap()
                .ForMember(
                dest => dest.Status,
                src => src.MapFrom(z => z.Status.GetDisplayName()))
                .ForMember(dest=>dest.TeacherName, src =>src.MapFrom(z=>z.Teacher!.FirstName + " " + z.Teacher.LastName))
                .ForMember(dest => dest.UpdatedDate, src => src.MapFrom(z => z.UpdatedDate.HasValue ? z.UpdatedDate.Value.ToString() : " - "));

            CreateMap<CreateClassroomVM, CreateClassroomDTO>().ReverseMap();
            CreateMap<UpdateClassroomVM, UpdateClassroomDTO>().ReverseMap();
        }
    }
}
