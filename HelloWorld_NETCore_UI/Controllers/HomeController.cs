using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld_NETCore_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ProductList() 
        {
            return View("../Products/ProductList");
        }
        public ActionResult Ejercicio4()
        {
            return View();
        }
    }
}
