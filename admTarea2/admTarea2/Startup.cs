using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admTarea2.Startup))]
namespace admTarea2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
