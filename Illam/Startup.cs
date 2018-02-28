using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Illam.Startup))]
namespace Illam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
