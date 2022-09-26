using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Intro()
        {
            return View();
        }
      
        public ActionResult Personaldetails()
        {
            ViewBag.Name = "Avijit Sarker Tonmoy";
            ViewBag.PermanentAddress = "Dhaka, Bangladesh";

            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
        public ActionResult Skill()
        {
            return View();
        }
    }
}