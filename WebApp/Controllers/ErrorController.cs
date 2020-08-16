using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {

	public class ErrorController : Controller {

		[Route("404")]
		public IActionResult NotFound() {
			return View();
		}
	}
}