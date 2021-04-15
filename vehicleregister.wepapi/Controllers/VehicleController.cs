using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vehicle.domain.Interfaces;
using vehicle.domain.Vehicle;
using vehicle.dto;
using vehicle.repository;

namespace vehicleregister.wepapi.Controllers
{
    public class VehicleController : ApiController
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            this._vehicleRepository = vehicleRepository;
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

        [HttpGet]
        [Route("api/getvehicle")]
        public IHttpActionResult GetVehicle(string plateNo)
        {
            _vehicleRepository.GetByPlate(plateNo);
            return Ok();
        }
    }
}
