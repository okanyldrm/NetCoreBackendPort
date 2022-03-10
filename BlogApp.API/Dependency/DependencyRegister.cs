using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.DataAccess.Abstract;



namespace BlogApp.API.Dependency
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EventManager>().As<IEventService>().InstancePerDependency();
            builder.RegisterType<ChartManager>().As<IChartService>().InstancePerDependency();
            builder.RegisterType<AuthManager>().As<IAuthService>().InstancePerDependency();
           
        }
    }
}
