using Core.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IUserRepository
    {
        //User Get İşlemleri
        Task<List<AppUser>> GetUsersAsync();
        Task<List<AppUser>> GetUsersHasRoleAsync(string roleName);
        Task<List<AppUser>> GetUsersHasNotRoleAsync(string roleName);
        Task<List<string>> GetUserNamesHasRoleAsync(string roleName);
        Task<AppUser?> FindUserByIdAsync(Guid userId);
        Task<AppUser?> FindUserByEmailAsync(string email);
        Task<AppUser?> FindUserByUsernameAsync(string userName);
        Task<AppUser?> FindUserByClaimsAsync(ClaimsPrincipal user);
        Task<Guid> GetUserIdByClaimsAsync(ClaimsPrincipal user);

        //Any
        Task<bool> AnyAsync(Expression<Func<AppUser, bool>> expression);

        //User-Role İşlemleri
        Task<IdentityResult> AddUserToRoleAsync(AppUser user, string roleName);
        Task<IdentityResult> RemoveUserFromRoleAsync(AppUser user, string roleName);
        Task<bool> IsUserInRoleAsync(AppUser user, string roleName);

        //User Create-Update İşlemleri
        Task<IdentityResult> CreateUserAsync(AppUser user,string password);
        Task<IdentityResult> UpdateUserAsync(AppUser user);
        Task<IdentityResult> ChangePassswordAsync(AppUser user, string oldPassword, string newPassword);
        Task<IdentityResult> ResetPasswordAsync(AppUser user, string token, string newPassword);

        //Token İşlemleri
        Task<string> GenerateTokenForResetPasswordAsync(AppUser user);
        Task<bool> IsTokenValidAsync(AppUser user, string token);

        //Authentication İşlemleri
        Task<SignInResult> LoginAsync(string userName, string password);
        Task LogoutAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}