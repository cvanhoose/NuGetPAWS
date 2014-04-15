using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NuGetPAWS.Web.Startup))]
namespace NuGetPAWS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
