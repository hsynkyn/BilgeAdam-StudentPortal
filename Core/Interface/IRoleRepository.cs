using System.Linq.Expressions;
using Core.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace Core.Interface
{
    public interface IRoleRepository
    {
        Task<List<AppRole>> GetRolesAsync();
        Task<AppRole?> GetRoleAsync(Guid roleId);
        Task<bool> AnyUserInRole(Guid roleId);
        Task<bool> AnyAsync(Expression<Func<AppRole,bool>> expression);
        Task<IdentityResult> AddRoleAsync(AppRole role);
        Task<IdentityResult> UpdateRoleAsync(AppRole role);
        Task<IdentityResult> DeleteRoleAsync(AppRole role);


    }
}
