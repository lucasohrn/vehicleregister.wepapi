using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vehicle.webclient.Models
{
    public interface IWebApiEndpoints
    {
        string GetVehicles { get; }
        string CreateVehicles { get; }
    }
}