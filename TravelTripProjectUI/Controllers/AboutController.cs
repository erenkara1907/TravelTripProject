using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectUI.Models.Classes.Contexts;

namespace TravelTripProjectUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var values = c.Abouts.ToList();
            return View(values);
        }
    }
}