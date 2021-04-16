using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.repository.interfaces
{
    public interface IVehicleRepository
    {
        void Create(IVehicle vehicle);
        IVehicle GetByPlate(string plateNo);
        IEnumerable<IVehicle> GetAllVehicles();
        IVehicle Update(IVehicle vehicle);
        void Delete(int plateNo);
    }
}
