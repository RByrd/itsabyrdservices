using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace itsabyrdservices.Models
{
    public class Owner
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage= "Enter your Log in User Name")]
        [DisplayName("User Name")]
        public String User_Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DisplayName("Vehicles")]
        public virtual List<Vehicle> Vehicle { get; set; }


    }
}