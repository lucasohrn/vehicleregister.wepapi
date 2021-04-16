using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vehicle.webclient.Models
{
    public class VehicleListModel
    {
        public int VehcileID { get; set; }
        public string PlateNo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string VehicleType { get; set; }
        public float ServiceWeight { get; set; }
        public DateTime DateInTrafficFirstTime { get; set; }
        public int ServiceIsBooked { get; set; }
    }
}