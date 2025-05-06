using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SolarXCrmIntegration.Models
{
    public class Opportunity
    {
        [Required]
        public string Name {get;set;}
        public string Description { get;set;}

    }
}