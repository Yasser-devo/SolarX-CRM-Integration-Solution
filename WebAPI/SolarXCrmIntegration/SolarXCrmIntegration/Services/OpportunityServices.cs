using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Xrm.Sdk;
using SolarXCrmIntegration.Models;

namespace SolarXCrmIntegration.Services
{
    public class OpportunityServices : IOpportunityServices
    {
        private readonly ICrmService _crmService;
        public OpportunityServices(ICrmService crmService)
        {
            _crmService= crmService;
        }

        public void CreateNewCrmOpportunity(Opportunity opportunity)
        {
            Entity newOpportunity = new Entity("yasser_opportunityy");
            newOpportunity["yasser_opportunityname"] = opportunity.Name;
            newOpportunity["yasser_description"] = opportunity.Description;
            _crmService.GetOrgService().Create(newOpportunity);


        }
    }
}