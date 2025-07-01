using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Interface;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class TeacherService(AppDbContext context) : BaseService<Teacher>(context), ITeacherRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<Teacher> GetTeacherByClassroomId(Guid classroomId)
        {
            var classroom = await _context.Classrooms.FirstOrDefaultAsync(x => x.Id == classroomId);

            var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == classroom!.TeacherId);
            return teacher!;
        }
    }
}
