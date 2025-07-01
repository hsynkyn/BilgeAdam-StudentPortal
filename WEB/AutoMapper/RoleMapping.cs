using AutoMapper;
using DTO.Concrete.RoleDTO;
using WEB.Areas.Admin.Models.RoleVM;

namespace WEB.AutoMapper
{
    public class RoleMapping : Profile
    {
        public RoleMapping()
        {
            CreateMap<GetRoleDTO, GetRoleVM>().ReverseMap();
            CreateMap<CreateRoleDTO, CreateRoleVM>().ReverseMap();
            CreateMap<UpdateRoleDTO, UpdateRoleVM>().ReverseMap();

        }
    }
}
