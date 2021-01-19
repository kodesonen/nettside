using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Interfaces;
using WebApp.DbHandler.Models;
using WebApp.Models.Admin;
using WebApp.Helpers;

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
					CourseHandler.Update(model);
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
			else
				return RedirectToAction("ViewCourses");

			/* Get all course modules */
			List<Module> moduleList = CourseHandler.GetAllModulesById(id);
			return View(moduleList);
		}

		[HttpGet]
		[Route("admin/kursbehandler/endre-modul")]
		public IActionResult EditModule(int kurs, int modul) {
			/* Check if the ID attributes are unset */
			if (kurs == 0 || modul == 0)
				return RedirectToAction("ViewCourses");

			/* Check if course name is null or invalid */
			var courseName = CourseHandler.GetCourseNameById(kurs);
			if (courseName != null)
				ViewBag.CourseName = courseName;
			else
				return RedirectToAction("ViewCourses");

			/* Check if module name is null or invalid */
			var moduleName = CourseHandler.GetModuleNameById(modul);
			if (moduleName != null)
				ViewBag.ModuleName = moduleName;
			else
				return RedirectToAction("ViewCourses");

			return View();
		}
	}
}