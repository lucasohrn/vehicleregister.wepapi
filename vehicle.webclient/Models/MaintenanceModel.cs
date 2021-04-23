using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vehicle.webclient.Models
{
    public class MaintenanceModel
    {
        public string Description { get; set; }
        public float Cost { get; set; }
        public string PlateNo { get; set; }
        public int IsCompleted { get; set; }
        public DateTime DateTimeOfService { get; set; }
    }

    public class CreateMaintenanceModel
    {
        [Required]
        [Display(Name = "What kind of maintenance is included:")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Cost:")]
        public float Cost { get; set; }

        [Required]
        [Display(Name = "License plate number:")]
        public string PlateNo { get; set; }

        [Required]
        [Display(Name = "Is this service done?:")]
        public int IsCompleted { get; set; }

        [Required]
        [Display(Name = "Date of service:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateTimeOfService { get; set; }
    }
}