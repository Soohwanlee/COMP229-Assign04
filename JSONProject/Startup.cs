using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSONProject.Startup))]
namespace JSONProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
