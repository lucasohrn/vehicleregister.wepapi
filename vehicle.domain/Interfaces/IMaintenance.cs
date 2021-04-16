using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle.domain.Interfaces
{
    public interface IMaintenance
    {
        int MaintenanceID { get; }
        string Description { get; }
        float Cost { get; }
        int VehicleID { get; }
        int IsCompleted { get; }
        DateTime DateTimeOfService { get; }
    }
}
