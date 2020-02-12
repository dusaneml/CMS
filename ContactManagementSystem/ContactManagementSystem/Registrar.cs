using ContactManagementSystemBl;
using ContactManagementSystemDal;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ContactManagementSystem
{
    public static  class Registrar
    {
        public static void Register()
        {
            //create container scope
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            //Register dependency
            container.Register<IRepositoryDal, RepositoryDal>(Lifestyle.Scoped);
            container.Register<IContactBl, ContactBl>(Lifestyle.Scoped);
            
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            

        }
    }
}