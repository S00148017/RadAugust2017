using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rad301August2017.Startup))]
namespace Rad301August2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
