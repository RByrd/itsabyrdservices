using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace itsabyrdservices.Models
{
    public class Service
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Enter a description of the service, i.e. Oil Change, Replace Spark Plugs")]
        [DisplayName("Service")]
        public string Description { get; set; }

        [DisplayName("Suggested Interval miles/kilometers")]
        public int DistanceInterval { get; set; }

        [DisplayName("Suggested Interval months")]
        public int MonthInterval { get; set; }

    }
}