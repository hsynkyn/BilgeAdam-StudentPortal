using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Interface;
using DataAccess.Context;

namespace DataAccess.Services
{
    public class StudentService(AppDbContext context) : BaseService<Student>(context), IStudentRepository
    {
    }
}
