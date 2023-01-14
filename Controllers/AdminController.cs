using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Interfaces;
using WebApp.DbHandler.Models;
using WebApp.Models.Admin;
using WebApp.Helpers;
using System.Diagnostics;

namespace WebApp.Controllers {

	public class AdminController : Controller {
		private ICourseHandler CourseHandler;

		public AdminController(ICourseHandler _ch) {
			this.CourseHandler = _ch;
		}

		[HttpGet]
		[Route("admin")]
		public IActionResult Index() {
			return View();
		}

		[HttpGet]
		[Route("admin/kursbehandler")]
		public IActionResult ViewCourses() {
			List<Course> CourseList = CourseHandler.LoadAll();
			return View(CourseList);
		}

		/*
		 *
		 * Nytt kurs
		 *
		 */

		[HttpGet]
		[Route("admin/kursbehandler/nytt-kurs")]
		public IActionResult NewCourse() {
			return View();
		}

		//Måtte endre en del her, blir problematisk med to "identiske" modeller med en property i forskjell
		[HttpPost]
		[Route("admin/kursbehandler/nytt-kurs/{id?}")]
		public IActionResult NewCourse(Course model) {
			Console.WriteLine($"Model Id == {model.Id}");
			if (model.Id == 0) {
				//NYTT KURS
				if (ModelState.IsValid) {
					CourseHandler.AddNewCourse(model);
					TempData["StatusMessage"] = StatusMessage.Success("Hurra!", "Du har lagt til et nytt kurs.");
				} else {
					TempData["StatusMessage"] = StatusMessage.Error("Oops!", "Vennligst fyll ut alle tekstfelt!");
				}
			} else {
				if (ModelState.IsValid) {
					CourseHandler.UpdateCourse(model);
					TempData["StatusMessage"] = StatusMessage.Success("Hurra!", "Kurset ble oppdatert");
				} else {
					TempData["StatusMessage"] = StatusMessage.Error("Oops!", "Noe gikk galt!");
				}
				Console.WriteLine("Oppdatert!");
				return RedirectToAction("ManageCourse", model.Id);
			}
			return RedirectToAction("NewCourse");
		}

		/*
		 *
		 * Rediger kurs
		 *
		 */

		[HttpGet]
		[Route("admin/kursbehandler/nytt-kurs/{id}")]
		public IActionResult NewCourse(int id) {
			var course = CourseHandler.GetCourseById(id);
			return View(course);
		}

		//[HttpPost]
		//[Route("admin/kursbehandler/nytt-kurs/{id}")]
		//private IActionResult NewCourse(Course model) {
		//	if (ModelState.IsValid) {
		//		CourseHandler.Update(model);
		//		TempData["StatusMessage"] = StatusMessage.Success("Hurra!", "Kurset ble oppdatert");
		//	} else {
		//		TempData["StatusMessage"] = StatusMessage.Error("Oops!", "Noe gikk galt!");
		//	}
		//	Console.WriteLine("Oppdatert!");
		//	return RedirectToAction("ManageCourse", model.Id);
		//}

		[HttpGet]
		[Route("admin/kursbehandler/behandle-kurs")]
		public IActionResult ManageCourse(int id) {
			/* Check if ID attribute is unset */
			if (id == 0)
				return RedirectToAction("ViewCourses");

			/* Check if course name is null or invalid */
			var courseName = CourseHandler.GetCourseNameById(id);
			if (courseName != null)
				ViewBag.CourseName = courseName;
			//else
			//return RedirectToAction("ViewCourses");
			//Kommenterte ut det ovenfor ettersom enkelte kurs ikke har navn og det er greit å få slettet dem
			//- Stian

			/* Get all course modules */
			List<Module> moduleList = CourseHandler.GetModulesByCourseId(id);
			ViewBag.CourseId = id;
			return View(moduleList);
		}

		[HttpGet]
		[Route("admin/kursbehandler/endre-modul")]
		public IActionResult EditModule(int kurs, int modul) {
			Module model;
			//Bruker denne inten for å legge til ny modul
			//Den kan endres men må også endres i ManageCourse.cshtml
			//Regner med vi ikke skal ha 69000 moduler
			if (modul == 69420) {
				var m = CourseHandler.GetModulesByCourseId(kurs);
				int lastIndex = m.Count() - 1 > 0 ? m.Count() - 1 : 0;
				Console.WriteLine(lastIndex);

				model = new Module() {
					CourseId = kurs,
					Chapter = lastIndex > 0 ? m[lastIndex].Chapter : 1,
					SubChapter = lastIndex > 0 ? m[lastIndex].SubChapter + 1 : 1,
					update = false
				};
				return View(model);
			} else {
				model = CourseHandler.GetModuleById(modul);
			}

			model.update = true;
			return View(model);
		}

		[HttpPost]
		[Route("admin/kursbehandler/endre-modul")]
		public IActionResult EditModule(Module m) {
			//Oppdater tid
			Console.WriteLine(m.update);
			if (m.update) {
				DateTime _date = DateTime.Now;
				var _dateString = _date.ToString("dd-MM-yyyy");
				DateTime d;
				if (DateTime.TryParseExact(_dateString, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d)) {
					m.Updated = d;
				}
				var updateResult = CourseHandler.UpdateModule(m);
				if (updateResult) {
					Module module = CourseHandler.GetModulesByCourseId(m.Id).FirstOrDefault();
					TempData["Message"] = "Update successful";
					m.update = true;
					return RedirectToAction("ManageCourse", new { id = m.CourseId });
				}
				TempData["Message"] = "Update failed";
			} else {
				//Legg inn published dato
				DateTime _date = DateTime.Now;
				var _dateString = _date.ToString("dd-MM-yyyy");
				DateTime d;
				if (DateTime.TryParseExact(_dateString, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d)) {
					m.Published = d;
				}
				CourseHandler.AddNewModule(m);
			}
			m.update = true;
			return RedirectToAction("ManageCourse", new { id = m.CourseId });
		}
	}
}