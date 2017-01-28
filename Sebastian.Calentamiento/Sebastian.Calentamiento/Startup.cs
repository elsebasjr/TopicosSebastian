using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sebastian.Calentamiento.Startup))]
namespace Sebastian.Calentamiento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
