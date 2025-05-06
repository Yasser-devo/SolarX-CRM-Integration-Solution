using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Xrm.Sdk;
using SolarXCrmIntegration.Services;
using System.Web.Http.Dependencies;
using Unity.WebApi;
using Unity;




namespace SolarXCrmIntegration
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
            var container = new UnityContainer();
            container.RegisterType<IOpportunityServices, OpportunityServices>();
            container.RegisterType<ICrmService, CrmService>();

            config.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}
