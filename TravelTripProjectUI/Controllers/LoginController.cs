using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProjectUI.Models.Classes;
using TravelTripProjectUI.Models.Classes.Contexts;

namespace TravelTripProjectUI.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Admin admin)
        {
            var information = c.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (information != null)
            {
                FormsAuthentication.SetAuthCookie(information.UserName, false);
                Session["UserName"] = information.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}