using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.IdentityEntities;
using DTO.Concrete.UserDTO;

namespace Business.AutoMapper
{
    public class UserBusinessMapping : Profile
    {
        public UserBusinessMapping()
        {
            CreateMap<AppUser, GetUserDTO>().ReverseMap();
            CreateMap<AppUser, GetUserForRoleDTO>().ReverseMap();
            CreateMap<AppUser, EditUserDTO>().ReverseMap();
        }
    }
}
