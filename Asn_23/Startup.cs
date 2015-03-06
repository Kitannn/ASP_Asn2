using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asn_23.Startup))]
namespace Asn_23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
