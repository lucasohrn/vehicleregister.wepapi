using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using vehicle.repository;
using vehicle.repository.repos;

namespace vehicleregister.wepapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void RegisterSimpleInjector(HttpConfiguration config)
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            // Register your types, for instance using the scoped lifestyle:
            //container.Register<IVehicleRepository, LocalSqlDataStorage>(Lifestyle.Scoped);
            container.Register<IMaintenanceRepository, LocalSqlDataStorage>(Lifestyle.Scoped);
            container.Register<IVehicleRepository, LocalSqlDataStorage>(Lifestyle.Scoped);
            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
