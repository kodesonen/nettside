using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ChallengesController : Controller
    {
        [HttpGet]
        [Route("Utfordringer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
