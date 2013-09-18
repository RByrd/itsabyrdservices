using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace itsabyrdservices.Models
{
    public class FuelPurchase
    {
        public int FuelPurchaseID { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Purchase Date")]
        [DisplayFormat(DataFormatString="{0:MM/dd/yy}")]
        public DateTime PurchaseDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:F1")]
        [DisplayName("Mileage")]
        public string Mileage { get; set; }

        [DisplayName("Amount Gallons/liters")]
        [DisplayFormat(DataFormatString="{0:F")]
        public decimal PurchaseAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C")]
        public decimal Cost { get; set; }

        [DisplayName("Fill Up")]
        public Boolean Fillup { get; set; }

        public virtual Vehicle Vehicle { get; set; }


    }
}