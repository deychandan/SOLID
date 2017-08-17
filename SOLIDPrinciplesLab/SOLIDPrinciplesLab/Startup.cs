using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOLIDPrinciplesLab.Startup))]
namespace SOLIDPrinciplesLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
