using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shiraki.Dr_Sox.Startup))]
namespace Shiraki.Dr_Sox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
