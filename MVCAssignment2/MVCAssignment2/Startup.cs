using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAssignment2.Startup))]
namespace MVCAssignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
