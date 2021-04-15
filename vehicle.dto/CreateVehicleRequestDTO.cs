using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle.dto
{
    public class CreateVehicleRequestDTO : ICreateVehicle
    {
        public int VehicleId { get; set; }
        public string PlateNo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string VehicleType { get; set; }
        public float ServiceWeight { get; set; }
        public DateTime DateInTrafficFirstTime { get; set; }
        public int ServiceIsBooked { get; set; }
        public float YearlyFee { get; set; }
    }

    public interface ICreateVehicle
    {
        string PlateNo { get; set; }
        string Model { get; set; }
        string Brand { get; set; }
        float ServiceWeight { get; set; }
    }
}
