using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FactCliente.Startup))]
namespace FactCliente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
