using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuan3_ltweb.Startup))]
namespace tuan3_ltweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
