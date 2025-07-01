using Core.Enums;
using Core.IdentityEntities;
using Core.Interface;
using DataAccess.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppIdentityDbContext appIdentityDbContext) : IUserRepository
    {
        private readonly UserManager<AppUser> _userManager = userManager;
        private readonly SignInManager<AppUser> _signInManager = signInManager;
        private readonly AppIdentityDbContext _context = appIdentityDbContext;


        #region Any
        public async Task<bool> AnyAsync(Expression<Func<AppUser, bool>> expression) => await _userManager.Users.AnyAsync(expression);
        #endregion

        #region User Get İşlemleri
        public async Task<Guid> GetUserIdByClaimsAsync(ClaimsPrincipal user)
        {
            var userEntity = await _userManager.GetUserAsync(user);
            if (userEntity == null)
                return default;
            return userEntity.Id;
        }

        public async Task<List<string>> GetUserNamesHasRoleAsync(string roleName)
        {
            var users = await GetUsersHasRoleAsync(roleName);
            return users.Select(x => x.UserName).ToList()!;
        }

        public async Task<List<AppUser>> GetUsersAsync()
            => await _userManager.Users.ToListAsync();

        public async Task<List<AppUser>> GetUsersHasNotRoleAsync(string roleName)
        {
            var users = await GetUsersAsync();
            var userNameHasNotRol = new List<AppUser>();

            foreach (var user in users)
            {
                if (!await _userManager.IsInRoleAsync(user, roleName))
                    userNameHasNotRol.Add(user);
            }

            return userNameHasNotRol;
        }

        public async Task<List<AppUser>> GetUsersHasRoleAsync(string roleName)
        {
            var users = await GetUsersAsync();
            var userNameHasRol = new List<AppUser>();

            foreach (var user in users)
            {
                if (await _userManager.IsInRoleAsync(user, roleName))
                    userNameHasRol.Add(user);
            }

            return userNameHasRol;
        }

        public async Task<AppUser?> FindUserByClaimsAsync(ClaimsPrincipal user)
        {
            var userEntity = await _userManager.GetUserAsync(user);
            if (userEntity == null)
                return default;

            return userEntity;
        }
        public async Task<AppUser?> FindUserByEmailAsync(string email)
        {
            var normalizedEmail = _userManager.NormalizeEmail(email);

            var userEntity = await _userManager.Users.FirstOrDefaultAsync(x => x.NormalizedEmail == normalizedEmail);
            if (userEntity == null)
                return default;

            return userEntity;
        }

        public async Task<AppUser?> FindUserByIdAsync(Guid userId)
        {
            var userEntity = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (userEntity == null)
                return default;

            return userEntity;
        }

        public async Task<AppUser?> FindUserByUsernameAsync(string userName)
        {
            var normalizedUsername = _userManager.NormalizeName(userName);
            var userEntity = await _userManager.Users.FirstOrDefaultAsync(x => x.NormalizedUserName == normalizedUsername);
            if (userEntity == null)
                return default;

            return userEntity;
        }
        #endregion

        #region User-Role İşlemleri
        public async Task<IdentityResult> AddUserToRoleAsync(AppUser user, string roleName)
        => await _userManager.AddToRoleAsync(user, roleName);        

        public async Task<IdentityResult> RemoveUserFromRoleAsync(AppUser user, string roleName)
        => await _userManager.RemoveFromRoleAsync(user, roleName);

        public async Task<bool> IsUserInRoleAsync(AppUser user, string roleName)
        =>
           await _userManager.IsInRoleAsync(user, roleName);

        #endregion

        #region User Create-Update İşlemleri
        public async Task<IdentityResult> CreateUserAsync(AppUser user, string password)
        => await _userManager.CreateAsync(user,password);

        public async Task<IdentityResult> UpdateUserAsync(AppUser user)
        => await _userManager.UpdateAsync(user);

        public async Task<IdentityResult> ChangePassswordAsync(AppUser user, string oldPassword, string newPassword)
        => await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);

        public async Task<IdentityResult> ResetPasswordAsync(AppUser user, string token, string newPassword)
        => await _userManager.ResetPasswordAsync(user, token, newPassword);
        #endregion

        #region Token İşlemleri
        public async Task<string> GenerateTokenForResetPasswordAsync(AppUser user)
        => await _userManager.GeneratePasswordResetTokenAsync(user);

        public async Task<bool> IsTokenValidAsync(AppUser user, string token)
        {

            var tokenProvider = _userManager.Options.Tokens.PasswordResetTokenProvider;
            return await _userManager.VerifyUserTokenAsync(user, tokenProvider,"ResetPassword",token);
        }
        #endregion

        #region Authentication İşlemleri
        public async Task<SignInResult> LoginAsync(string userName, string password)
        => await _signInManager.PasswordSignInAsync(userName,password,false,false);

        public async Task LogoutAsync()
        => await _signInManager.SignOutAsync();
        #endregion

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();
             
        
    }
}