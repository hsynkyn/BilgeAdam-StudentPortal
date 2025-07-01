using AutoMapper;
using Core.Entities.Concrete;
using Core.Extensions;
using DTO.Concrete.TeacherDTO;
using DTO.Concrete.UserDTO;
using WEB.Areas.Education.Models.TeacherVM;

namespace WEB.AutoMapper
{
    public class TeacherMapping : Profile
    {
        public TeacherMapping()
        {
            CreateMap<GetCustomerManagerVM, Teacher>().ReverseMap()
                .ForMember(
                dest => dest.Status,
                src => src.MapFrom(z => z.Status.GetDisplayName()))
                .ForMember(
                dest => dest.CourseName,
                src => src.MapFrom(z => z.Course!.Name))
                .ForMember(dest => dest.UpdatedDate, src => src.MapFrom(z => z.UpdatedDate.HasValue ? z.UpdatedDate.Value.ToString() : " - "));

            CreateMap<CreateTeacherVM, CreateTeacherDTO>().ReverseMap();            
            CreateMap<UpdateTeacherVM, UpdateTeacherDTO>().ReverseMap();
            
        }
    }
}
