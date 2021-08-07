using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjectUI.Models.Classes
{
    public class Home
    {
        [Key]
        public int ID { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
    }
}