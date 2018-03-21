using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(invFM.Startup))]
namespace invFM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
