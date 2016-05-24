using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Korpa387.Startup))]
namespace Korpa387
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
