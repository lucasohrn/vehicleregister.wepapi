using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using vehicleregister.wepapi.Provider;

[assembly: OwinStartup(typeof(vehicleregister.wepapi.App_Start.Startup1))]

namespace vehicleregister.wepapi.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            var newtonProvider = new OAuthWebApiAuthorizationServerProvider();
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = newtonProvider
            };

            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

        }
    }
}
