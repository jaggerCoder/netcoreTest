using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
<<<<<<< HEAD
=======
            string jagger="jj";
>>>>>>> 0626c70f5e0f06a8340e2874ee722a31e4cefdfd
            return View();
        }

        public IActionResult About()
        {

            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {

            return View();
        }
    }
}
