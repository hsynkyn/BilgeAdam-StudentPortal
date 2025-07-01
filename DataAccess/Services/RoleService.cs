using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;
using Core.IdentityEntities;
using Core.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class RoleService(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager) : IRoleRepository
    {
        private readonly RoleManager<AppRole> _roleManager = roleManager;
        private readonly UserManager<AppUser> _userManager = userManager;

        public async Task<IdentityResult> AddRoleAsync(AppRole role) => await _roleManager.CreateAsync(role);

        public async Task<IdentityResult> UpdateRoleAsync(AppRole role)
        {
            role.UpdatedDate = DateTime.Now;
            role.Status = Status.Modified;
            return await _roleManager.UpdateAsync(role);
        }

        public async Task<IdentityResult> DeleteRoleAsync(AppRole role)
        {
            role.DeletedDate = DateTime.Now;
            role.Status = Status.Passive;
            return await _roleManager.UpdateAsync(role);
        }

        public async Task<AppRole?> GetRoleAsync(Guid roleId)
        => await _roleManager.Roles.FirstOrDefaultAsync(x=>x.Id == roleId && x.Status != Status.Passive);

       
        public async Task<List<AppRole>> GetRolesAsync()
        => await _roleManager.Roles.Where(x=> x.Status != Status.Passive).ToListAsync();


        public async Task<bool> AnyAsync(Expression<Func<AppRole,bool>> expression)
        => await _roleManager.Roles.AnyAsync(expression);

        public async Task<bool> AnyUserInRole(Guid roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId.ToString()); 
            if (role == null) 
                return false;
            var anyUsersInRole = await _userManager.GetUsersInRoleAsync(role.Name!);
            return anyUsersInRole.Any();

        }
    }
}
