using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AboutController : Controller
    {
        [HttpGet]
        [Route("om-oss")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("vilkaar-og-personvern")]
        public IActionResult Terms()
        {
            return View();
        }

        [HttpGet]
        [Route("discord")]
        public IActionResult Discord()
        {
            return Redirect("https://discord.gg/vUBkfNG");
        }
    }
}
