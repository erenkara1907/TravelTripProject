using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjectUI.Models.Classes
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string AddressOpen { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Map { get; set; }
    }
}