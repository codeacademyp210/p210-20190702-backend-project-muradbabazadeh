using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_final.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
       
        public ActionResult CourseSchedule()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Rooms()
        {
            return View();
        }
        public ActionResult Trainers()
        {
            return View();
        }
    }
}