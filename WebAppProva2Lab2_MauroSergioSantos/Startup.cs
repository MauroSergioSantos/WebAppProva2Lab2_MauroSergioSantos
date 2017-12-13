using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProva2Lab2_MauroSergioSantos.Startup))]
namespace WebAppProva2Lab2_MauroSergioSantos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
