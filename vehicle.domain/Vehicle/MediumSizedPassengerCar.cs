using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.domain.Vehicle
{
    public class MediumSizedPassengerCar : IVehicle
    {
        int vehicleId { get; set; }
        string plateNo { get; set; }
        string model { get; set; }
        string brand { get; set; }
        string vehicleType { get; set; }
        float serviceWeight { get; set; }
        DateTime dateInTrafficFirstTime { get; set; }
        int serviceIsBooked { get; set; }

        float yearlyFee { get; set; }

        public string PlateNo => plateNo;

        public string Model => model;

        public string Brand => brand;

        public string VehicleType => vehicleType;

        public float ServiceWeight => serviceWeight;

        public DateTime DateInTrafficFirstTime => dateInTrafficFirstTime;

        public int ServiceIsBooked => serviceIsBooked;

        public float YearlyFee => yearlyFee;

        public int VehcileID => vehicleId;

        public MediumSizedPassengerCar(
            string plateNo,
            string model,
            string brand,
            string vehicleType,
            float serviceWeight,
            DateTime dateInTrafficFirstTime,
            int serviceIsBooked,
            float yearlyFee)
        {
            this.plateNo = plateNo;
            this.model = model;
            this.brand = brand;
            this.vehicleType = vehicleType;
            this.serviceWeight = serviceWeight;
            this.dateInTrafficFirstTime = dateInTrafficFirstTime;
            this.serviceIsBooked = serviceIsBooked;
            this.yearlyFee = 20000;
        }
    }
}
