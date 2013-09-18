using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace itsabyrdservices.Models
{
    public class ServiceLog
    {
        public int ServiceLogID { get; set; }

        public virtual Service Service { get; set; }

        [Required()]
        [DataType(DataType.Date)]
        [DisplayName("Service Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy")]
        public DateTime ServiceDate { get; set; }

        [DisplayName("Odometer Reading")]
        public int OdometerReading { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set;  }

    }
}