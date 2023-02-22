using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AZUREMUSIC.Startup))]

namespace AZUREMUSIC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
