using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using vehicle.dto;
using vehicle.webclient.Models;

namespace vehicle.webclient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebApiEndpoints _endpoints;
        public HomeController()
        {
            _endpoints = new WebApiEndpoints();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowCreateVehicle()
        {
            return View();

        }

        public ActionResult CreateVehicle(CreateVehicleModel vehicle)
        {
            if (vehicle.PlateNo != null)
            {
                var vehicleRequest = new VehicleDTO()
                {
                    PlateNo = vehicle.PlateNo,
                    Model = vehicle.Model,
                    Brand = vehicle.Brand,
                    VehicleType = vehicle.VehicleType,
                    ServiceWeight = vehicle.ServiceWeight,
                    DateInTrafficFirstTime = vehicle.DateInTrafficFirstTime,
                    ServiceIsBooked = vehicle.ServiceIsBooked
                };
                
                string jsonregistercar = JsonConvert.SerializeObject(vehicleRequest);
                var httpcontent = new StringContent(jsonregistercar, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {
                    var response = client.PostAsync(new Uri("https://localhost:44379/api/vehicle"), httpcontent).Result;
                }
            }
            return View();
        }

        public ActionResult GetList()
        {
            var vehicles = new List<VehicleListModel>();
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44379/api/getvehicles").Result;
                if (response != null)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var vehicleResponse = JsonConvert.DeserializeObject<GetAllVehiclesResponseDTO>(jsonString);


                    foreach (var vehicle in vehicleResponse.Vehicles)
                    {
                        var vehicleListModel = new VehicleListModel
                        {
                            PlateNo = vehicle.PlateNo,
                            Model = vehicle.Model,
                            Brand = vehicle.Brand,
                            VehicleType = vehicle.VehicleType,
                            ServiceWeight = vehicle.ServiceWeight,
                            DateInTrafficFirstTime = vehicle.DateInTrafficFirstTime,
                            ServiceIsBooked = vehicle.ServiceIsBooked

                        };
                        vehicles.Add(vehicleListModel);
                    }
                    ViewBag.Vehicles = vehicles;
                }
            }

            return View(vehicles);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}