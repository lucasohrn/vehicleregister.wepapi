using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using vehicle.domain.Interfaces;
using vehicle.domain.Vehicle;
using vehicle.repository.interfaces;

namespace vehicle.repository.repos
{
    public class AzureSqlDataStorage : IVehicleRepository, IMaintenanceRepository
    {
        private readonly VehicleDBDataContext datacontext;
        public AzureSqlDataStorage()
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

        public void Create(IMaintenance maintenance)
        {
            Maintenance new_maintenance = new Maintenance
            {
                Description = maintenance.Description,
                Cost = maintenance.Cost,
                VehicleID = maintenance.VehicleID,
                IsCompleted = maintenance.IsCompleted,
                DateTimeOfService = maintenance.DateTimeOfService
            };

            this.datacontext.Maintenances.InsertOnSubmit(new_maintenance);
            this.datacontext.SubmitChanges();
        }

        public void Delete(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMaintenance> GetAllMaintenances()
        {
            var maintenances = new List<IMaintenance>();
            foreach (var entity in datacontext.Maintenances.ToList())
            {
                IMaintenance maintenance = MaintenanceFactory.CreateMaintenance(
                    entity.Description,
                    ((float)entity.Cost),
                    ((int)entity.IsCompleted),
                    ((int)entity.VehicleID),
                    ((DateTime)entity.DateTimeOfService));

                maintenances.Add(maintenance);
            }
            return maintenances;
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

                if (entity.PlateNo == plateNo.ToUpper())
                    return vehicle;
            }

            throw new NotImplementedException();
        }

        public IMaintenance GetMaintenance(int maintenanceId)
        {
            foreach (var entity in datacontext.Maintenances.ToList())
            {
                IMaintenance maintenance = MaintenanceFactory.CreateMaintenance(
                    entity.Description,
                    ((float)entity.Cost),
                    ((int)entity.IsCompleted),
                    ((int)entity.VehicleID),
                    ((DateTime)entity.DateTimeOfService));

                if (entity.MaintenanceID == maintenanceId)
                    return maintenance;
            }

            throw new NotImplementedException();
        }

        public IVehicle Update(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public IMaintenance Update(IMaintenance maintenance)
        {
            throw new NotImplementedException();
        }
    }
}
