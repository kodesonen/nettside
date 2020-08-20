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

namespace WebApp.Controllers {

	public class HomeController : Controller {
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) {
			_logger = logger;
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Index() {
			return View();
		}

		public IActionResult About() {
			return View();
		}

		public IActionResult Challenges() {
			List<Challenge> ChallengesList = HandleChallenges.GetAllChallenges();
			return View(ChallengesList);
		}
	}
}