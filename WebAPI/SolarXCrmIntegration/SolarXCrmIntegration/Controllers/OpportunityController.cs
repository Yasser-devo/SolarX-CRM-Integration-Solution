using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.Xrm.Sdk;
using SolarXCrmIntegration.Models;
using SolarXCrmIntegration.Services;

namespace SolarXCrmIntegration.Controllers
{
    public class OpportunityController:ApiController
    {
        private readonly IOpportunityServices _opportunityServices;
        public OpportunityController(IOpportunityServices opportunityServices)
        {
           _opportunityServices=opportunityServices;
        }

        [HttpPost]
        [Route ("api/opportunity/create")]
        public IHttpActionResult CreateOpportunity([FromBody]Opportunity opportunity)
        {
            try
            {
                _opportunityServices.CreateNewCrmOpportunity(opportunity);
                
                return Ok("Opportunity Created succsessfully");
            }
            catch(Exception ex)
            {
                return InternalServerError(new Exception("error happend while creating Opp " + ex.Message));
            }
        }
    }
}