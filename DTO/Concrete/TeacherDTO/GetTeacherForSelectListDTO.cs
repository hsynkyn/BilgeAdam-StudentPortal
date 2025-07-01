using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;

namespace DTO.Concrete.TeacherDTO
{
    public class GetTeacherForSelectListDTO : BaseDTO
    {

        public Guid Id { get; set; }
        public required string FullName { get; set; }

        public Guid CourseId { get; set; }
    }
}
