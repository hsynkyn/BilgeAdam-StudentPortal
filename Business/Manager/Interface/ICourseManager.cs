using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Interface;

namespace Business.Manager.Interface
{
    public interface ICourseManager : IBaseManager<ICourseRepository, Course>
    {
    }
}
