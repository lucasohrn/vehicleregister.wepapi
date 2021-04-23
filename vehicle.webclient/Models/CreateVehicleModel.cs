using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vehicle.webclient.Models
{
    public class CreateVehicleModel
    {
        [Required]
        [Display(Name = "Licence plate:")]
        [StringLength(6, ErrorMessage = "Not a valid Swedish plate number!")]
        public string PlateNo { get; set; }

        [Required]
        [Display(Name = "Vehicle Model:")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Vehicle Brand:")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Type of car:")]
        public string VehicleType { get; set; }

        [Required]
        [Display(Name = "Vehicle weight:")]
        [Range(0, 650000, ErrorMessage = "sorry this viecle is not leagal on the road")]
        public float ServiceWeight { get; set; }


        [Required]
        [Display(Name = "First day in traffic:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateInTrafficFirstTime { get; set; }

        [Required]
        [Display(Name = "Is service booked?")]
        public int ServiceIsBooked { get; set; }
    }
}