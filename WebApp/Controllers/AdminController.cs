using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("admin/kursbehandler")]
        public IActionResult ManageCourses()
        {
            return View();
        }
    }
}
