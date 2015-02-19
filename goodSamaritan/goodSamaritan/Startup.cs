using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(goodSamaritan.Startup))]
namespace goodSamaritan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
