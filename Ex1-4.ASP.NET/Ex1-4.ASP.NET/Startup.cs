using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ex1_4.ASP.NET.Startup))]
namespace Ex1_4.ASP.NET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
