using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chatbots2.Startup))]
namespace chatbots2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
