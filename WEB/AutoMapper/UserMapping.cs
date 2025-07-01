using AutoMapper;
using DTO.Concrete.AccountDTO;
using DTO.Concrete.CourseDTO;
using DTO.Concrete.UserDTO;
using WEB.Areas.Admin.Models.CustomerManagerVM;
using WEB.Areas.Admin.Models.RoleVM;
using WEB.Areas.Education.Models.StudentVM;
using WEB.Areas.Education.Models.TeacherVM;
using WEB.Models.ViewModels.AccountVM;

namespace WEB.AutoMapper
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<LoginVM, LoginDTO>().ReverseMap();
            CreateMap<EditUserVM, EditUserDTO>().ReverseMap();
            CreateMap<ChangePasswordVM, ChangePasswordDTO>().ReverseMap();
            CreateMap<ResetPasswordVM, ResetPasswordDTO>().ReverseMap();
            CreateMap<GetUserForRoleVM, GetUserForRoleDTO>().ReverseMap();


            CreateMap<CreateTeacherVM, CreateUserDTO>().ReverseMap();
            CreateMap<CreateStudentVM, CreateUserDTO>().ReverseMap();
            CreateMap<CreateCustomerManagerVM, CreateUserDTO>().ReverseMap();
        }
    }
}
