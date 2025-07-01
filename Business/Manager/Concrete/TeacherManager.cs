using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Manager.Interface;
using Core.Entities.Concrete;
using Core.Interface;
using DTO.Concrete.TeacherDTO;

namespace Business.Manager.Concrete
{
    public class TeacherManager(ITeacherRepository service, IMapper mapper) : BaseManager<ITeacherRepository, Teacher>(service, mapper), ITeacherManager
    {
        private readonly ITeacherRepository _service = service;

        private readonly IMapper _mapper = mapper;
        public async Task<GetTeacherForSelectListDTO> GetTeacherByClassroomId(Guid classroomId)
            
        {
            var teacher = await _service.GetTeacherByClassroomId(classroomId);
            var selectListTeacher = _mapper.Map<GetTeacherForSelectListDTO>(teacher);
            return selectListTeacher;
        }
        
    }
}
