using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_crud.Startup))]
namespace Mvc_crud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
