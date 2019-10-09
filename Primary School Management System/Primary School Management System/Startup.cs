using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Primary_School_Management_System.Startup))]
namespace Primary_School_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
