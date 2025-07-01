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
    public class CMManager(ICustomerManagerRepository service, IMapper mapper) : BaseManager<ICustomerManagerRepository, CustomerManager>(service, mapper), ICMManager
    {
    }
}
