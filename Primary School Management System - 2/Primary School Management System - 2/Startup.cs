using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Primary_School_Management_System___2.Startup))]
namespace Primary_School_Management_System___2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
