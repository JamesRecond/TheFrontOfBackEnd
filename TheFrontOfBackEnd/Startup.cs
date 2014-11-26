using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheFrontOfBackEnd.Startup))]
namespace TheFrontOfBackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
