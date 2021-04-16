using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace vehicle.webclient.Models
{
    public class WebApiEndpoints : IWebApiEndpoints
    {
        private string HostName => ConfigurationManager.AppSettings["HostName"];
        public string GetVehicles => HostName + "api/vehicles";

        public string CreateVehicles => HostName + "api/vehicle";
    }
}