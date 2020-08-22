using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {

	[Route("admin/utfordringer/[action]")]
	public class UtfordringerManageController : Controller {

		//Singular
		[HttpGet]
		public IActionResult EndreUtfordring() {
			return View();
		}

		//plural
		[HttpGet]
		public IActionResult EndreUtfordringer() {
			return View();
		}
	}
}