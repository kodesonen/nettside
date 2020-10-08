using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DatabaseHandler.Dataset;
using DatabaseHandler.Handlers;
using DatabaseHandler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        #region ctor
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        #endregion ctor

        #region error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion error

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Om-oss")]
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [Route("Utfordringer")]
        [HttpGet]
        public IActionResult Challenges()
        {
            List<Challenge> ChallengesList = HandleChallenges.GetAllChallenges();
            return View(ChallengesList);
        }
    }
}
