using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pregunta7Login.Startup))]
namespace Pregunta7Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
