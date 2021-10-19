using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using System.Web.Mvc;

namespace _02_Hello_World_MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Hello"] = "Bienvenido compañero";
            return View();
        }
        public string Avu() 
        {
            return "Avu";
        }
    }
}