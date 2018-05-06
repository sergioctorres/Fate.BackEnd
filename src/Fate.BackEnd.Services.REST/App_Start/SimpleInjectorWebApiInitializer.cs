[assembly: WebActivator.PostApplicationStartMethod(typeof(Fate.BackEnd.Services.REST.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace Fate.BackEnd.Services.REST.App_Start
{
    using System.Web.Http;
    using Fate.BackEnd.Infra.CrossCutting.IoC;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using SimpleInjector.Lifestyles;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            SimpleInjectorBootStrapper.Register(container);
        }
    }
}