using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities.Concrete;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.CustomerManagerDTO;

namespace Business.AutoMapper
{
    public class CustomerManagerBusinessMapping : Profile
    {
        public CustomerManagerBusinessMapping()
        {
            CreateMap<CustomerManager, CreateCustomerManagerDTO>().ReverseMap();
            CreateMap<CustomerManager, UpdateCustomerManagerDTO>().ReverseMap();
            CreateMap<CustomerManager, GetCMDTO>().ReverseMap();
        }
    }
}
