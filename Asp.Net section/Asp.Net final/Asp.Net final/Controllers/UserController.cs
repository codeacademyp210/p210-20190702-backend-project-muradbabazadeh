using Asp.Net_final.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_final.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        Fit2GoEntities db = new Fit2GoEntities();
        public ActionResult UsersList()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }


        public ActionResult AddUsers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUsers(User user, HttpPostedFileBase Photo)
        {
            if (Photo != null)
            {
                string fileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Photo.FileName;
                user.Image = fileName;
                Photo.SaveAs(Path.Combine(Server.MapPath("~"), "Uploads", fileName));
            }
            using (Fit2GoEntities db = new Fit2GoEntities())
            {
                user.StatusId = 4;
                user.Country = "Azerbaijan";
               
                db.Users.Add(user);
                db.SaveChanges();

            }
           
           

            return View();
        }
        public ActionResult Payments()
        {
            return View();
        }




    }
}