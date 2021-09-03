using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vehicle.domain.Interfaces;
using vehicle.domain.Vehicle;
using vehicle.dto;
using vehicle.dto.MaintenanceDTO;
using vehicle.repository;
using vehicle.repository.interfaces;
using vehicle.repository.repos;

namespace vehicleregister.wepapi.Controllers
{
    public class VehicleController : ApiController
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMaintenanceRepository _maintenanceRepository;

        public VehicleController(IVehicleRepository vehicleRepository, IMaintenanceRepository maintenanceRepository)
        {
            this._vehicleRepository = vehicleRepository;
            this._maintenanceRepository = maintenanceRepository;
        }

        [HttpPost]
        [Route("api/maintenance")]
        public IHttpActionResult CreateMaintenance(CreateMaintenanceRequestDTO request)
        {
            IMaintenance maintenance = MaintenanceFactory.CreateMaintenance(
                request.Description,
                request.Cost,
                request.PlateNo,
                request.IsCompleted,
                request.DateTimeOfService);


            this._maintenanceRepository.Create(maintenance);
            return Ok();
        }

        [HttpGet]
        [Route("api/getmaintenances")]
        public IHttpActionResult GetMaintenances()
        {
            var response = new GetAllMaintenancesResponseDTO();
            foreach (var maintenance in _maintenanceRepository.GetAllMaintenances())
            {
                response.Maintenances.Add(new MaintananceDTO()
                {
                    Description = maintenance.Description,
                    Cost = maintenance.Cost,
                    PlateNo = maintenance.PlateNo,
                    IsCompleted = maintenance.IsCompleted,
                    DateTimeOfService = maintenance.DateTimeOfService
                });
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("api/vehicle")]
        public IHttpActionResult CreateVehicle(CreateVehicleRequestDTO request)
        {
            IVehicle vehicle = VehicleFactory.CreateVehicle(
                request.PlateNo,
                request.Model,
                request.Brand,
                request.VehicleType,
                request.ServiceWeight,
                request.DateInTrafficFirstTime,
                request.ServiceIsBooked,
                request.YearlyFee);


            this._vehicleRepository.Create(vehicle);
            return Ok();
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("api/getvehicles")]
        public IHttpActionResult GetVehicles()
        {
            var response = new GetAllVehiclesResponseDTO();
            foreach (var vehicle in _vehicleRepository.GetAllVehicles())
            {
                response.Vehicles.Add(new VehicleDTO()
                {
                    PlateNo = vehicle.PlateNo,
                    Model = vehicle.Model,
                    Brand = vehicle.Brand,
                    VehicleType = vehicle.VehicleType,
                    ServiceWeight = vehicle.ServiceWeight,
                    DateInTrafficFirstTime = vehicle.DateInTrafficFirstTime,
                    ServiceIsBooked = vehicle.ServiceIsBooked,
                    YearlyFee = vehicle.YearlyFee
                });
            }

            return Ok(response);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("api/getvehicle")]
        public IHttpActionResult GetVehicle(string plateNo)
        {
            var selectedVehicle = _vehicleRepository.GetByPlate(plateNo);
            return Ok(selectedVehicle);
        }

        [HttpGet]
        [Route("api/getmaintenance")]
        public IHttpActionResult GetMaintenance(int maintenanceId)
        {
            var selectedMaintenance = _maintenanceRepository.GetMaintenance(maintenanceId);
            return Ok(selectedMaintenance);
        }
    }
}
