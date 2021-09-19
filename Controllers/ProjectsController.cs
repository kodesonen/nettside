using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        [Route("prosjekter")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("prosjekter/kodesonens-nettside")]
        public IActionResult ProjectPage()
        {
            return View();
        }
    }
}
