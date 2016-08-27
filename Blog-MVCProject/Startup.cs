using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog_MVCProject.Startup))]
namespace Blog_MVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
