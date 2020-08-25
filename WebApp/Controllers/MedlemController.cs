using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {

	public class MedlemController : Controller {

		public IActionResult MedlemsListe() {
			return View();
		}

		public IActionResult RegistrerMedlem() {
			return View();
		}
	}
}