using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle.dto.MaintenanceDTO
{
    public class CreateMaintenanceRequestDTO : ICreateMaintenance
    {
        public int MaintenanceID { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public string PlateNo { get; set; }
        public int IsCompleted { get; set; }
        public DateTime DateTimeOfService { get; set; }
    }

    public interface ICreateMaintenance
    {
        string Description { get; set; }
        string PlateNo { get; set; }
        int IsCompleted { get; set; }
        DateTime DateTimeOfService { get; set; }
    }
}
