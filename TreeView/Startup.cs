using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreeView.Startup))]
namespace TreeView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
