using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System.Configuration;

namespace SolarXCrmIntegration.Services
{
    public static class CrmServiceHelper
    {
        public static IOrganizationService GetService()
        {
            try
            {
                string clientId = ConfigurationManager.AppSettings["ClientId"];
                string clientSecret = ConfigurationManager.AppSettings["ClientSecret"];
                string organizationUrl = ConfigurationManager.AppSettings["OrganizationUrl"];
                string tenantId = ConfigurationManager.AppSettings["TenantId"];

                string connectionString = $@"
                AuthType=ClientSecret;
                ClientId={clientId};
                ClientSecret={clientSecret};
                Url={organizationUrl};
                TenantId={tenantId};
                
             ";

                CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);
                if (!crmServiceClient.IsReady)
                {
                    throw new Exception("Connection to Crm Faild: " + crmServiceClient.LastCrmError);
                }
                return (IOrganizationService)crmServiceClient.OrganizationServiceProxy ?? crmServiceClient;

            }
            catch (Exception ex)
            {
                throw new Exception("Error while creating crm service : " + ex.Message);
            }





        }
    }
}