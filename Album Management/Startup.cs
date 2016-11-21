using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Album_Management.Startup))]
namespace Album_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
