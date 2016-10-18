using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ircib1.Startup))]
namespace ircib1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
