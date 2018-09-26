using Microsoft.Owin;
using Owin;
using System;



[assembly: OwinStartupAttribute(typeof(chatbots2.Startup))]
namespace chatbots2
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            //Any connection or hub wire up and configuration should go here
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}