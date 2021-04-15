using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle.domain.Interfaces
{
    public interface IVehicle
    {
        int VehcileID { get; }
        string PlateNo { get; }
        string Model { get; }
        string Brand { get; }
        string VehicleType { get; }
        float ServiceWeight { get; }
        DateTime DateInTrafficFirstTime { get; }
        int ServiceIsBooked { get; }
    
        float YearlyFee { get; }

    }
}
