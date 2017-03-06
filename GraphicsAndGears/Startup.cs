using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GraphicsAndGears.Startup))]
namespace GraphicsAndGears
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
