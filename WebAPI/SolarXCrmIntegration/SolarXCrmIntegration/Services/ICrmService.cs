using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Xrm.Sdk;

namespace SolarXCrmIntegration.Services
{
    public interface ICrmService
    {
        IOrganizationService GetOrgService();
    }
}