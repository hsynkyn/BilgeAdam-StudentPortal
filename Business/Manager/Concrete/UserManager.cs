using AutoMapper;
using Business.Manager.Interface;
using Core.Extensions;
using Core.IdentityEntities;
using Core.Interface;
using DTO.Concrete.AccountDTO;
using DTO.Concrete.UserDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager.Concrete
{
    public class UserManager(IUserRepository userRepository, IMapper mapper) : IUserManager
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IMapper _mapper = mapper;             


        #region User Get İşlemleri
        public async Task<T?> FindUserByClaimsAsync<T>(ClaimsPrincipal user)
        {
            var userEntity = await _userRepository.FindUserByClaimsAsync(user);
            if (userEntity == null)
                return default;
            return _mapper.Map<T>(userEntity);
        }

        public async Task<GetUserDTO?> FindUserByEmailAsync(string email)
        {
            var userEntity = await _userRepository.FindUserByEmailAsync(email);
            if (userEntity == null)
                return default;

            return _mapper.Map<GetUserDTO>(userEntity);
        }

        public async Task<GetUserDTO?> FindUserByIdAsync(Guid userId)
        {
            var userEntity = await _userRepository.FindUserByIdAsync(userId);
            if (userEntity == null)
                return default;

            return _mapper.Map<GetUserDTO>(userEntity);
        }

        public async Task<GetUserDTO?> FindUserByUsernameAsync(string userName)
        {
            var userEntity = await _userRepository.FindUserByUsernameAsync(userName);
            if (userEntity == null)
                return default;

            return _mapper.Map<GetUserDTO>(userEntity);
        }

        public async Task<Guid> GetUserIdByClaimsAsync(ClaimsPrincipal user)
            => await _userRepository.GetUserIdByClaimsAsync(user);

        public async Task<List<string>> GetUserNamesHasRoleAsync(string roleName)
            => await _userRepository.GetUserNamesHasRoleAsync(roleName);

        public async Task<List<GetUserForRoleDTO>> GetUsersHasNotRoleAsync(string roleName)
        {
            var userEntity = await _userRepository.GetUsersHasNotRoleAsync(roleName);
            return _mapper.Map<List<GetUserForRoleDTO>>(userEntity);
        }

        public async Task<List<GetUserForRoleDTO>> GetUsersHasRoleAsync(string roleName)
        {
            var userEntity = await _userRepository.GetUsersHasRoleAsync(roleName);
            return _mapper.Map<List<GetUserForRoleDTO>>(userEntity);
        }
        #endregion

        #region Any
        public async Task<bool> AnyAsync(Expression<Func<AppUser, bool>> expression) => await _userRepository.AnyAsync(expression);
        #endregion

        #region User-Role İşlemleri
        public async Task<IdentityResult> AddUserToRoleAsync(Guid userId, string roleName)
        {
            var user = await _userRepository.FindUserByIdAsync(userId);
            if (user == null)
                return IdentityResult.Failed();
            var result = await _userRepository.AddUserToRoleAsync(user, roleName);
            return result;
        }

        public async Task<IdentityResult> AddUserToRoleAsync(string email, string roleName)
        {
            var user = await _userRepository.FindUserByEmailAsync(email);
            if (user == null)
                return IdentityResult.Failed();
            var result = await _userRepository.AddUserToRoleAsync(user, roleName);
            return result;
        }



        public async Task<IdentityResult> RemoveUserFromRoleAsync(Guid userId, string roleName)
        {
            var user = await _userRepository.FindUserByIdAsync(userId);
            if (user == null)
                return IdentityResult.Failed();

            var result = await _userRepository.RemoveUserFromRoleAsync(user, roleName);
            return result;
        }

        public async Task<bool> IsUserInRoleAsync(string userName, string roleName)
        {
            var user = await _userRepository.FindUserByUsernameAsync(userName);
            if (user == null)
                return false;

            var result = await _userRepository.IsUserInRoleAsync(user, roleName);
            return result;
        }
        #endregion

        #region User Create-Update İşlemleri
        public async Task<IdentityResult> CreateUserAsync(CreateUserDTO user)
        {
            var userEntity = new AppUser();
            string password = GeneratePassword();
            userEntity.UserName = GenerateUsername(user.FirstName, user.LastName);
            userEntity.Email = user.Email;
            return await _userRepository.CreateUserAsync(userEntity,password);
        }

        private string GenerateUsername(string firstName, string lastName)
        {
            // Hüseyin Kayan => huseyin.kayan olarak değiştiriyor.

            var firstNameUpdate = firstName.ChangeChars();
            var lastNameUpdate = lastName.ChangeChars();

            return $"{firstNameUpdate}.{lastNameUpdate}";
        }

        private string GeneratePassword(int length =12)
        {
            const string lowerCase = "abcdefghijklmnopqrstuvxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "!Q#$%&.*()-+=<>?-_";
            string allChars = lowerCase + upperCase + digits + specialChars;

            var random = new Random();
            var password = new char[length];

            password[0]= lowerCase[random.Next(lowerCase.Length)];
            password[1]= upperCase[random.Next(lowerCase.Length)];
            password[2]= digits[random.Next(lowerCase.Length)];
            password[3]= specialChars[random.Next(lowerCase.Length)];

            for (int i = 4; i < length; i++) 
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }
            return new string(password);

        }

        public async Task<IdentityResult> UpdateUserAsync(EditUserDTO user)
        {
            var userEntity = await _userRepository.FindUserByIdAsync(user.Id);
            if (userEntity == null)
                return IdentityResult.Failed();
            _mapper.Map(user, userEntity);

            return await _userRepository.UpdateUserAsync(userEntity);
        }

        public async Task<IdentityResult> UpdateUserAsync(GetUserDTO user)
        {
            var userEntity = await _userRepository.FindUserByIdAsync(user.Id);
            if (userEntity == null)
                return IdentityResult.Failed();
            _mapper.Map(user, userEntity);

            return await _userRepository.UpdateUserAsync(userEntity);
        }

        public async Task<IdentityResult> ChangePassswordAsync(ChangePasswordDTO dto)
        {
            var userEntity = await _userRepository.FindUserByIdAsync(dto.Id);
            if (userEntity == null)
                return IdentityResult.Failed();
            return await _userRepository.ChangePassswordAsync(userEntity, dto.OldPassword, dto.NewPassword);
        }

        public async Task<IdentityResult> ResetPasswordAsync(ResetPasswordDTO dto)
        {
            var userEntity = await _userRepository.FindUserByEmailAsync(dto.Email);
            if (userEntity == null)
                return IdentityResult.Failed();
            return await _userRepository.ResetPasswordAsync(userEntity, dto.Token, dto.NewPassword);
        }

        #endregion

        #region Token İşlemleri
        public async Task<string> GenerateTokenForResetPasswordAsync(string email)
        {
            var userEntity = await _userRepository.FindUserByEmailAsync(email);
            if (userEntity == null)
                return string.Empty;
            return await _userRepository.GenerateTokenForResetPasswordAsync(userEntity);

        }

        public async Task<bool> IsTokenValidAsync(string email, string token)
        {
            var userEntity = await _userRepository.FindUserByEmailAsync(email);
            if (userEntity == null)
                return false;

            return await _userRepository.IsTokenValidAsync(userEntity, token);
        }
        #endregion

        #region Authentication İşlemleri
        public async Task<SignInResult> LoginAsync(LoginDTO dto)
            => await _userRepository.LoginAsync(dto.Username, dto.Password);

        public async Task LogoutAsync()
            => await _userRepository.LogoutAsync();
        #endregion

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _userRepository.BeginTransactionAsync();
    }
}