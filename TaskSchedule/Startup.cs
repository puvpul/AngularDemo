using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskSchedule.Startup))]
namespace TaskSchedule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
