using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectUI.Models.Classes;
using TravelTripProjectUI.Models.Classes.Contexts;

namespace TravelTripProjectUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        BlogComment blogComment = new BlogComment();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(5).OrderByDescending(x => x.ID).ToList();
            return View(values);
        }

        public PartialViewResult BlogPartial()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult BlogPartial2()
        {
            var values = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(values);
        }

        public PartialViewResult Top10Partial()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial4()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial5()
        {
            var values = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(values);
        }
    }
}