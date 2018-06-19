using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(apcc.Startup))]
namespace apcc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
