using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(itsabyrdservices.Startup))]
namespace itsabyrdservices
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
