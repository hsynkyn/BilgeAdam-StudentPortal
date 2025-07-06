using AutoMapper;
using Core.Entities.Concrete;
using Core.Enums;
using Core.Extensions;
using DTO.Concrete.StudentDTO;
using WEB.Areas.Education.Models.StudentVM;

namespace WEB.AutoMapper
{
    public class StudentMapping : Profile
    {
        public StudentMapping()
        {
            CreateMap<GetStudentVM, Student>().ReverseMap()
                .ForMember(
                dest => dest.Status,
                src => src.MapFrom(z => z.Status.GetDisplayName()))
                .ForMember(
                dest => dest.StudentStatus,
                src => src.MapFrom(z => z.StudentStatus.GetDisplayName()))
                .ForMember(
                dest => dest.CourseName,
                src => src.MapFrom(z => z.Classroom!.Teacher!.Course!.Name))
                .ForMember(dest => dest.UpdatedDate, src => src.MapFrom(z => z.UpdatedDate.HasValue ? z.UpdatedDate.Value.ToString() : " - "));

            CreateMap<CreateStudentVM, CreateStudentDTO>().ReverseMap();
            CreateMap<UpdateStudentVM, UpdateStudentDTO>().ReverseMap();

            CreateMap<StudentDetailDTO, StudentDetailVM>()
             .ForMember(x => x.StudentStatus,
                 opt => opt.MapFrom(x => x.StudentStatus.GetDisplayName()));

            CreateMap<StudentDetailVM, StudentDetailDTO>()
                .ForMember(x => x.StudentStatus,
                    opt => opt.MapFrom(x => x.StudentStatus.GetEnumValueFromDisplayName<StudentStatus>()));

            CreateMap<GetStudentForClassroomVM, GetStudentForClassroomDTO>().ReverseMap().ForMember(x => x.StudentStatus,
                 opt => opt.MapFrom(x => x.StudentStatus.GetDisplayName()));
        }
    }
}
