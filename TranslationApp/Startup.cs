using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranslationApp.Startup))]
namespace TranslationApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
