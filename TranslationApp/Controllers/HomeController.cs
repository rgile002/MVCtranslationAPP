using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranslationApp.Helpers;
using TranslationApp.Models;

namespace TranslationApp.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person per)
        {
            //TODO add person to database
            return View();
        }
        public ActionResult SetCulture(string culture)
        {
            culture = CultureHelper.GetImplementedCulture(culture);

            HttpCookie cookie = Request.Cookies["_Culture"];

            if(cookie != null)
            {
                cookie.Value = culture;

            }
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }

        
    }
}