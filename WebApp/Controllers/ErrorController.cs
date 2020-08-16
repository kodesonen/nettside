using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {

	[Route("Error/[action]")]
	public class ErrorController : Controller {

		[Route("~404")]
		[HttpGet]
		public IActionResult NotFound() {
			return View();
		}
	}
}