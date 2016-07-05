using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BGLTechnicalTest.Startup))]
namespace BGLTechnicalTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
