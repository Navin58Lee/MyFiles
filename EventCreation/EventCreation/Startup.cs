using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventCreation.Startup))]
namespace EventCreation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
