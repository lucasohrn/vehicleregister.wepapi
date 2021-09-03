using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using vehicle.dto;
using vehicle.dto.MaintenanceDTO;
using vehicle.webclient.Models;
using System.Configuration;
using System.Net.Http.Headers;

namespace vehicle.webclient.Controllers
{
    public class UserIdentity
    {
        public string UserName { get; set; }
        public string Token { get; set; }
    }

    public class GetTokenResponseDTO
    {
        public IList<UserIdentity> Identity { get; set; } = new List<UserIdentity>();
    }

    public class HomeController : Controller
    {
        private readonly IWebApiEndpoints _endpoints;
        public HomeController()
        {
            _endpoints = new WebApiEndpoints();
        }

        private string GetToken(string username, string password)
        {
            var url = ConfigurationManager.AppSettings["HostName"];

            using (var _httpClient = new HttpClient())
            {
                var userDict = new Dictionary<string, string>
                        {
                            {"userName", username },
                            {"password", password },
                            {"grant_type", "password" }
                        };
                var content = new FormUrlEncodedContent(userDict);
                var response = _httpClient.PostAsync(url + "token", content).Result;
                var jsonstring = response.Content.ReadAsStringAsync().Result;
                var tokenstring = JsonConvert.DeserializeObject<TokenDTO>(jsonstring);

                if (response.IsSuccessStatusCode)
                    return tokenstring.access_token;

                else
                    return null;
            }
        }

        public ActionResult UserLogIn(string username, string password)
        {
            Session["token"] = null;
            string token = null;
            token = GetToken(username, password);
            if (string.IsNullOrEmpty(token))
                return null;
                

            var ui = new UserIdentity
            {
                UserName = username,
                Token = token
            };

            var usersLoggedIn = new List<UserIdentity>();
            usersLoggedIn.Add(ui);
            Session["BearerToken"] = usersLoggedIn;
            Session["token"] = token;

            return View("LoginSucces");
        }

        public ActionResult ShowIndex()
        {
            return View();
        }

        public ActionResult Index(LogInModel logIn)
        {
            if (logIn.Username != null || logIn.Password != null)
            {
                string Username = logIn.Username;
                string Password = logIn.Password;
                if (UserLogIn(Username, Password) != null)
                    return RedirectToAction("GetList", "Home");
                else
                    return RedirectToAction("Index", "Home");
            }


            //Först:
            //Logga in
            //Authenticated = yes / no
            //Roles
            // key value
            //Authorization  bearer xxxxxxxxxx

            //string jsonregistercar = JsonConvert.SerializeObject(vehicleRequest);
            //var httpcontent = new StringContent(jsonregistercar, Encoding.UTF8, "application/json");
            //using (HttpClient client = new HttpClient())
            //{
            //    var response = client.PostAsync(url + "api/vehicle", httpcontent).Result;
            //}
            //UserLogIn();


            return View();
        }

        public ActionResult ShowCreateVehicle()
        {
            return View();
        }

        public ActionResult CreateVehicle(CreateVehicleModel vehicle)
        {
            //var token = Session["BearerToken"].ToString();

            var url = ConfigurationManager.AppSettings["HostName"];

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
                    var response = client.PostAsync(url + "api/vehicle", httpcontent).Result;
                }
            }
            return View();
        }

        public ActionResult CreateMaintenance(CreateMaintenanceModel maintenance)
        {
            var url = ConfigurationManager.AppSettings["HostName"];

            if (maintenance.PlateNo != null)
            {
                var maintenanceRequest = new MaintananceDTO()
                {
                    Description = maintenance.Description,
                    Cost = maintenance.Cost,
                    PlateNo = maintenance.PlateNo,
                    IsCompleted = maintenance.IsCompleted,
                    DateTimeOfService = maintenance.DateTimeOfService
                };

                string jsonregistercar = JsonConvert.SerializeObject(maintenanceRequest);
                var httpcontent = new StringContent(jsonregistercar, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {
                    var response = client.PostAsync(url + "api/maintenance", httpcontent).Result;
                }
            }
            return View();
        }

        public ActionResult GetList()
        {
            var url = ConfigurationManager.AppSettings["HostName"];
            var vehicles = new List<VehicleListModel>();
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "token");
                //client.DefaultRequestHeaders.Add("Authorization", Session["Bearer " + "token"].ToString());
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session["token"].ToString());

                var response = client.GetAsync(new Uri(url + "api/getvehicles")).Result;
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