using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTest.Startup))]
namespace GitTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
