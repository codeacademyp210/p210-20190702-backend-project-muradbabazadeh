using Asp.Net_final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_final.Controllers
{
    public class HomeController : Controller
    {
        Fit2GoEntities db = new Fit2GoEntities();
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult ClubInfo()
        {

            return View();
        }
        public ActionResult Packages()
        {
            return View();
        }
        public ActionResult Coupons()
        {
            return View();
        }
        public ActionResult ClassCalendar()
        {
            return View();
        }
    }
}