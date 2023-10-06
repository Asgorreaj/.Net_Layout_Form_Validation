using System;
using WebApplication11.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Signin(Signin s)
        {
            {
                return RedirectToAction("Index", "Home");
            }
            return View(s);
        }



        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Signup s)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Signin");
            }
            return View(s);
        }
    }
}