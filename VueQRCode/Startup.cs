using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VueQRCode.Startup))]
namespace VueQRCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
