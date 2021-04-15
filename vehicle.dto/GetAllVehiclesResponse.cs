using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle.dto
{
    public class VehicleDTO
    {
        //public int VehicleID { get; set; }
        public string PlateNo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string VehicleType { get; set; }
        public float ServiceWeight { get; set; }
        public DateTime DateInTrafficFirstTime { get; set; }
        public int ServiceIsBooked { get; set; }
        public float YearlyFee { get; set; }
    }

    public class GetAllVehiclesResponseDTO
    {
        public IList<VehicleDTO> Vehicles { get; set; } = new List<VehicleDTO>();
    }
}
