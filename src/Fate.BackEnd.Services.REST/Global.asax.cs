using Fate.BackEnd.Application.AutoMapper;
using System.Web.Http;

namespace Fate.BackEnd.Services.REST
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
