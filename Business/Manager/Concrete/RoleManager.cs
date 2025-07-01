using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Manager.Interface;
using Core.Enums;
using Core.IdentityEntities;
using Core.Interface;
using DTO.Concrete.RoleDTO;

namespace Business.Manager.Concrete
{
    public class RoleManager(IRoleRepository roleRepository, IMapper mapper) : IRoleManager
    {
        private readonly IRoleRepository _roleRepository = roleRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<bool> AddRoleAsync(CreateRoleDTO role)
        {
            var entity = _mapper.Map<AppRole>(role);
            var result = await _roleRepository.AddRoleAsync(entity);
            return result.Succeeded;
        }

        public async Task<bool> UpdateRoleAsync(UpdateRoleDTO role)
        {
            var entity = await _roleRepository.GetRoleAsync(role.Id);
            if(entity == null)
                return false;
            _mapper.Map(role, entity);


            var result = await _roleRepository.UpdateRoleAsync(entity);
            return result.Succeeded;
        }

        public async Task<bool> DeleteRoleAsync(Guid roleId)
        {
            var role = await _roleRepository.GetRoleAsync(roleId);
            if (role == null)
                return false;
            var result = await _roleRepository.DeleteRoleAsync(role);
            return result.Succeeded;
        }

        public async Task<bool> AnyRoleById(Guid roleId)
        => await _roleRepository.AnyAsync(x => x.Id == roleId && x.Status != Status.Passive);

        public async Task<bool> AnyRoleNameAsync(string roleName)
         => await _roleRepository.AnyAsync(x => x.Name == roleName && x.Status != Status.Passive);

        public async Task<bool> AnyRoleNameAsync(string roleName, Guid roleId)
        => await _roleRepository.AnyAsync(x => x.Id == roleId && x.Status != Status.Passive);


        public async Task<T?> GetRoleByIdAsync<T>(Guid roleId)
        {
            var role = await _roleRepository.GetRoleAsync(roleId);
            if (role == null)
                return default;

            var roleDto = _mapper.Map<T>(role);
            return roleDto;
        }

        public async Task<List<GetRoleDTO>> GetRolesAsync()
        {
            var roles = await _roleRepository.GetRolesAsync();
            if (roles.Count == 0)
                return [];

            var dto = _mapper.Map<List<GetRoleDTO>>(roles);
            return dto;
        }

        public async Task<bool> AnyUserInRole(Guid roleId)
        => await _roleRepository.AnyUserInRole(roleId);
    }
}
