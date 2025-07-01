using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Concrete.RoleDTO;

namespace Business.Manager.Interface
{
    public interface IRoleManager
    {
        Task<List<GetRoleDTO>> GetRolesAsync();
        Task<T?> GetRoleByIdAsync<T>(Guid roleId);
        Task<bool> AnyUserInRole(Guid roleId);
        Task<bool> AnyRoleNameAsync(string roleName);
        Task<bool> AnyRoleNameAsync(string roleName, Guid roleId);
        Task<bool> AnyRoleById(Guid roleId);
        Task<bool> AddRoleAsync(CreateRoleDTO role);
        Task<bool> UpdateRoleAsync(UpdateRoleDTO role);
        Task<bool> DeleteRoleAsync(Guid roleId);


    }
}
