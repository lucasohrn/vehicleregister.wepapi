using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.domain.Vehicle
{
    public class MaintenanceService : IMaintenance
    {
        int maintenanceId { get; set; }
        string description { get; set; }
        float cost { get; set; }
        int vehicleId { get; set; }
        int isCompleted { get; set; }
        DateTime dateTimeOfService { get; set; }

        public int MaintenanceID => maintenanceId;

        public string Description => description;

        public float Cost => cost;

        public int VehicleID => vehicleId;

        public int IsCompleted => isCompleted;

        public DateTime DateTimeOfService => dateTimeOfService;

        public MaintenanceService(
            string description,
            float cost,
            int vehicleId,
            int isCompleted,
            DateTime dateTimeOfService)
        {
            this.description = description;
            this.cost = cost;
            this.vehicleId = vehicleId;
            this.isCompleted = isCompleted;
            this.dateTimeOfService = dateTimeOfService;
        }
    }
}
