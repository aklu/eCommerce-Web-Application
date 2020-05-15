using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappyPaws.Startup))]
namespace HappyPaws
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
