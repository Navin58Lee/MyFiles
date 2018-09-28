using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New1.Startup))]
namespace New1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
