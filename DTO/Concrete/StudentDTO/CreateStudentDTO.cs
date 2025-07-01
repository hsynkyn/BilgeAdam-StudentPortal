using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Abstract;
using Microsoft.AspNetCore.Http;

namespace DTO.Concrete.StudentDTO
{
    public class CreateStudentDTO : BasePersonDTO
    {

        public string? ImagePath { get; set; }

        public double RegisterPrice { get; set; }

        public Guid ClassroomId { get; set; }
    }
}
