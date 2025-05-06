using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolarXCrmIntegration.Models;

namespace SolarXCrmIntegration.Services
{
    public interface IOpportunityServices
    {
        void CreateNewCrmOpportunity(Opportunity opportunity);
    }
}