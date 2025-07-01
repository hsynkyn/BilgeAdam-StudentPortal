using Autofac;
using AutoMapper;
using Business.AutoMapper;
using Business.Manager.Concrete;
using Business.Manager.Interface;
using Core.Interface;
using DataAccess.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using WEB.AutoMapper;

namespace WEB.Autofac
{
    public class AutofacModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BaseService<>).Assembly).AsClosedTypesOf(typeof(IBaseRepository<>)).InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(BaseManager<,>).Assembly).AsClosedTypesOf(typeof(IBaseManager<,>)).InstancePerLifetimeScope();

            builder.RegisterType<RoleService>().As<IRoleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoleManager>().As<IRoleManager>().InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserManager>().As<IUserManager>().InstancePerLifetimeScope();

            //Autofac işlemlerinden sonra Mapping işlemimizi konfigüre ediyoruz.
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CourseMapping());
                mc.AddProfile(new TeacherMapping());
                mc.AddProfile(new ClassroomMapping());
                mc.AddProfile(new CustomerManagerMapping());
                mc.AddProfile(new StudentMapping());
                mc.AddProfile(new RoleMapping());
                mc.AddProfile(new UserMapping());


                mc.AddProfile(new CourseBusinessMapping());
                mc.AddProfile(new TeacherBusinessMapping());
                mc.AddProfile(new ClassroomBusinnessMapping());
                mc.AddProfile(new CustomerManagerBusinessMapping());
                mc.AddProfile(new StudentBusinessMapping());
                mc.AddProfile(new RoleBusinessMapping());
                mc.AddProfile(new UserBusinessMapping());


            });
            IMapper mapper = mappingConfig.CreateMapper();
            builder.RegisterInstance(mapper);

            builder.RegisterType<EmailSenderManager>().As<IEmailSender>().InstancePerLifetimeScope();

        }
    }
}
