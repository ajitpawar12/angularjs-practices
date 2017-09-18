using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular__demo.Startup))]
namespace Angular__demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
