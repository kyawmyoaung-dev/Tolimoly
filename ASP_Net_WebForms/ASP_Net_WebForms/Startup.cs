using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Net_WebForms.Startup))]
namespace ASP_Net_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
