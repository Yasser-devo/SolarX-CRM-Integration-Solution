using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Microsoft.Xrm.Sdk;

namespace SolarXCrmIntegration.Services
{
    public class CrmService : ICrmService
    {
        public IOrganizationService GetOrgService()
        {
           return CrmServiceHelper.GetService();
        }
    }
}