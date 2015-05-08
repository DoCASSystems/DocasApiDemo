using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(docas_api_demo.Startup))]
namespace docas_api_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
