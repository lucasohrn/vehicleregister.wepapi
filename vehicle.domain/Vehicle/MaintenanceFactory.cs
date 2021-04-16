using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.domain.Vehicle
{
    public static class MaintenanceFactory
    {
        public static IMaintenance CreateMaintenance(
            string description,
            float cost,
            int vehicleId,
            int isCompleted,
            DateTime dateTimeOfService)
        {
            return new MaintenanceService(description, cost, vehicleId, isCompleted, dateTimeOfService);
        }
    }
}
