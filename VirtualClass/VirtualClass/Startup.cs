using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualClass.Startup))]
namespace VirtualClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
