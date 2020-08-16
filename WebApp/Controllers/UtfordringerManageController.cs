using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {

	[Route("admin/utfordringer/[action]")]
	public class UtfordringerManageController : Controller {

		//Singuklar
		public IActionResult EndreUtfordring() {
			return View();
		}

		//plural
		public IActionResult EndreUtfordringer() {
			return View();
		}
	}
}