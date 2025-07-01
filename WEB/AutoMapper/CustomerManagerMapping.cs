using AutoMapper;
using Core.Entities.Concrete;
using Core.Extensions;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.CustomerManagerDTO;
using WEB.Areas.Admin.Models.CustomerManagerVM;

namespace WEB.AutoMapper
{
    public class CustomerManagerMapping : Profile
    {
        public CustomerManagerMapping()
        {
            CreateMap<GetCustomerManagerVM, CustomerManager>().ReverseMap()
               .ForMember(
               dest => dest.Status,
               src => src.MapFrom(z => z.Status.GetDisplayName()))
               .ForMember(dest => dest.UpdatedDate, src => src.MapFrom(z => z.UpdatedDate.HasValue ? z.UpdatedDate.Value.ToString() : " - "));

            CreateMap<CreateCustomerManagerVM, CreateCustomerManagerDTO>().ReverseMap();
            CreateMap<UpdateCustomerManagerVM, UpdateCustomerManagerDTO>().ReverseMap();
        }
    }
}
