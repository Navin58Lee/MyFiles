using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mv_Two.Startup))]
namespace Mv_Two
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
