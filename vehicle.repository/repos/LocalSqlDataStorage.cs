using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;
using vehicle.domain.Vehicle;

namespace vehicle.repository.repos
{
    public class LocalSqlDataStorage : IVehicleRepository
    {
        private readonly VehicleDBDataContext datacontext;
        public LocalSqlDataStorage()
        {
            this.datacontext = new VehicleDBDataContext();
        }


        public void Create(IVehicle vehicle)
        {
            VehicleRegister new_vehicle = new VehicleRegister
            {
                PlateNo = vehicle.PlateNo,
                Model = vehicle.Model,
                Brand = vehicle.Brand,
                VehicleType = vehicle.VehicleType,
                ServiceWeight = vehicle.ServiceWeight,
                DateInTrafficFirstTime = vehicle.DateInTrafficFirstTime,
                ServiceIsBooked = vehicle.ServiceIsBooked,
                YearlyFee = vehicle.YearlyFee
            };

            this.datacontext.VehicleRegisters.InsertOnSubmit(new_vehicle);
            this.datacontext.SubmitChanges();
        }

        public void Delete(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> GetAllVehicles()
        {
            var vehicles = new List<IVehicle>();
            foreach (var entity in datacontext.VehicleRegisters.ToList())
            {
                IVehicle vehicle = VehicleFactory.CreateVehicle(
                    entity.PlateNo,
                    entity.Model,
                    entity.Brand,
                    entity.VehicleType,
                    ((float)entity.ServiceWeight),
                    entity.DateInTrafficFirstTime,
                    entity.ServiceIsBooked,
                    ((float)entity.YearlyFee));

                vehicles.Add(vehicle);
            }
            return vehicles;
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
