using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace DTO.Concrete.RoleDTO
{
    public class GetRoleDTO 
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public required string UpdatedDate { get; set; }
        public required string Status { get; set; }
    }
}
