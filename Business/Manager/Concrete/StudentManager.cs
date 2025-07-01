using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Manager.Interface;
using Core.Entities.Concrete;
using Core.Interface;

namespace Business.Manager.Concrete
{
    public class StudentManager(IStudentRepository service,IMapper mapper) : BaseManager<IStudentRepository, Student>(service,mapper), IStudentManager
    {
        private readonly IStudentRepository _service = service;
        public override async Task<bool> DeleteAsync(Guid id)
        {
            var student = await _service.GetByIdAsync(id);
            if (student == null) 
                return false;

            student.ImagePath = null;
            return await _service.DeleteAsync(student);
        }
    }
}
