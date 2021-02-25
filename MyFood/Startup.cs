using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFood.Startup))]
namespace MyFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
