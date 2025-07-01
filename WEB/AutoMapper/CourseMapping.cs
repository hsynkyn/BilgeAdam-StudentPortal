using AutoMapper;
using Core.Entities.Concrete;
using Core.Extensions;
using DTO.Concrete.CourseDTO;
using WEB.Areas.Education.Models.CourseVM;

namespace WEB.AutoMapper
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<GetCourseVM, Course>().ReverseMap()
                .ForMember(
                dest => dest.Status, 
                src => src.MapFrom(z => z.Status.GetDisplayName()))
                .ForMember(dest => dest.UpdatedDate, src => src.MapFrom(z => z.UpdatedDate.HasValue ? z.UpdatedDate.Value.ToString() : " - "));

            CreateMap<CreateCourseVM, CreateCourseDTO>().ReverseMap();
            CreateMap<UpdateCourseVM, UpdateCourseDTO>().ReverseMap();
        }
    }
}
