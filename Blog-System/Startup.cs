using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog_System.Startup))]
namespace Blog_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
