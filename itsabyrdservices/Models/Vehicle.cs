using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace itsabyrdservices.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        [DisplayName("Picture")]
        public byte[] PhotoFile { get; set; }

        [Required(ErrorMessage = "Enter a description of your vehicle, i.e. Make, Model, Year")]
        public string Description { get; set; }

        public virtual Owner User { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        
        [DisplayName("Service Log")]      
        public virtual List<ServiceLog> Services { get; set; }

        [DisplayName("Fuel Log")]
        public virtual List<FuelPurchase> FuelPurchases { get; set; }
        


    }
}