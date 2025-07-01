using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.IdentityEntities;
using DTO.Concrete.AccountDTO;
using DTO.Concrete.UserDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;

namespace Business.Manager.Interface
{
    public interface IUserManager
    {
        //User Get İşlemleri
        Task<List<GetUserForRoleDTO>> GetUsersHasRoleAsync(string roleName);
        Task<List<GetUserForRoleDTO>> GetUsersHasNotRoleAsync(string roleName);
        Task<List<string>> GetUserNamesHasRoleAsync(string roleName);
        Task<GetUserDTO?> FindUserByIdAsync(Guid userId);
        Task<GetUserDTO?> FindUserByEmailAsync(string email);
        Task<GetUserDTO?> FindUserByUsernameAsync(string userName);
        Task<T?> FindUserByClaimsAsync<T>(ClaimsPrincipal user);
        Task<Guid> GetUserIdByClaimsAsync(ClaimsPrincipal user);

        //Any
        Task<bool> AnyAsync(Expression<Func<AppUser, bool>> expression);

        //User-Role İşlemleri
        Task<IdentityResult> AddUserToRoleAsync(Guid userId, string roleName);
        Task<IdentityResult> AddUserToRoleAsync(string email, string roleName);
        Task<IdentityResult> RemoveUserFromRoleAsync(Guid userId, string roleName);
        Task<bool> IsUserInRoleAsync(string userName, string roleName);

        //User Create-Update İşlemleri
        Task<IdentityResult> CreateUserAsync(CreateUserDTO user);
        Task<IdentityResult> UpdateUserAsync(EditUserDTO user);
        Task<IdentityResult> UpdateUserAsync(GetUserDTO user);
        Task<IdentityResult> ChangePassswordAsync(ChangePasswordDTO dto);
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordDTO dto);

        //Token İşlemleri
        Task<string> GenerateTokenForResetPasswordAsync(string email);
        Task<bool> IsTokenValidAsync(string email, string token);

        //Authentication İşlemleri
        Task<SignInResult> LoginAsync(LoginDTO dto);
        Task LogoutAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
