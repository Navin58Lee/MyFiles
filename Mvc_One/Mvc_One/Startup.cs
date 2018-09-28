using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_One.Startup))]
namespace Mvc_One
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
