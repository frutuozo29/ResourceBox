using ResourceBox.Application.AutoMapper;
using System.Web.Http;

namespace ResourceBox.WebApi
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
