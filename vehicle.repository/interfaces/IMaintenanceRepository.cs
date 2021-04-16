using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.repository.interfaces
{
    public interface IMaintenanceRepository
    {
        void Create(IMaintenance maintenance);
        IMaintenance GetMaintenance(int maintenanceId);
        IEnumerable<IMaintenance> GetAllMaintenances();
        IMaintenance Update(IMaintenance maintenance);
        void Delete(int maintenanceId);
    }
}
