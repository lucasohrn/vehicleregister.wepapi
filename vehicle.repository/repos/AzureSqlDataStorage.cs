using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.repository.repos
{
    public class AzureSqlDataStorage : IVehicleRepository
    {
        public void Create(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void Delete(int plateNo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public IVehicle GetByPlate(string plateNo)
        {
            throw new NotImplementedException();
        }

        public IVehicle Update(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
