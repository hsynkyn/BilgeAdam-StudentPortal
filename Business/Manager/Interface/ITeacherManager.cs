using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Interface;
using DTO.Concrete.TeacherDTO;

namespace Business.Manager.Interface
{
    public interface ITeacherManager : IBaseManager<ITeacherRepository, Teacher>
    {
        Task<GetTeacherForSelectListDTO> GetTeacherByClassroomId(Guid classroomId);

    }
}
