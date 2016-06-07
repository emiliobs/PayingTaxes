using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayingTaxes.Startup))]
namespace PayingTaxes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
