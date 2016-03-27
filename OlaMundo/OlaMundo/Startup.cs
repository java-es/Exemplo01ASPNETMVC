using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OlaMundo.Startup))]
namespace OlaMundo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
