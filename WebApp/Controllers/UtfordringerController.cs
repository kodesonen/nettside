using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class UtfordringerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}