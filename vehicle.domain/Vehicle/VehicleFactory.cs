using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle.domain.Interfaces;

namespace vehicle.domain.Vehicle
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(
            string plateNo,
            string model,
            string brand,
            string vehicleType,
            float serviceWeight,
            DateTime dateInTrafficFirstTime,
            int serviceIsBooked,
            float yearlyFee)
        {
            switch (serviceWeight)
            {
                case float n when (n <= 1800):
                    return new LightPassengerCar(plateNo, model, brand, vehicleType, serviceWeight, dateInTrafficFirstTime, serviceIsBooked, yearlyFee);
                case float n when (n >= 1800 && n <= 2500):
                    return new MediumSizedPassengerCar(plateNo, model, brand, vehicleType, serviceWeight, dateInTrafficFirstTime, serviceIsBooked, yearlyFee);
                default:
                    return new HeavyVehicle(plateNo, model, brand, vehicleType, serviceWeight, dateInTrafficFirstTime, serviceIsBooked, yearlyFee);
            }
        }
    }
}
