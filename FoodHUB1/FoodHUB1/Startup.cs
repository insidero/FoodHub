using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodHUB1.Startup))]
namespace FoodHUB1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
