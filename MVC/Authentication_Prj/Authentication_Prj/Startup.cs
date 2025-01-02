using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authentication_Prj.Startup))]
namespace Authentication_Prj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
