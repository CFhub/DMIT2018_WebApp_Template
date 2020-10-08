using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMIT2018_WebApp_Template.Startup))]
namespace DMIT2018_WebApp_Template
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
