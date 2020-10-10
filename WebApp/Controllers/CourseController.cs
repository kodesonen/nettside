using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        [Route("Kurs")]        
        public IActionResult Index()
        {
            return View();
        }
    }
}
