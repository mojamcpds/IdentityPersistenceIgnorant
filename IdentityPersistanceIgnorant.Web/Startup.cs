using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityPersistanceIgnorant.Web.Startup))]
namespace IdentityPersistanceIgnorant.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
