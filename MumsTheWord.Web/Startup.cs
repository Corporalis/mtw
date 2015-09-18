using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MumsTheWord.Web.Startup))]
namespace MumsTheWord.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
