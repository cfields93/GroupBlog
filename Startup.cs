using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupBlog.Startup))]
namespace GroupBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
