using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pregunta10REST_API.Startup))]
namespace Pregunta10REST_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
