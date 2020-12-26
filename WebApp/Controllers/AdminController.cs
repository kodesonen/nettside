using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Interfaces;
using WebApp.DbHandler.Models;
using WebApp.Models.Admin;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        private ICourseHandler CourseHandler;
        public AdminController(ICourseHandler _ch)
        {
            this.CourseHandler = _ch;
        }

        [HttpGet]
        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("admin/kursbehandler")]
        public IActionResult ViewCourses()
        {
            List<Course> CourseList = CourseHandler.LoadAll();
            return View(CourseList);
        }

        [HttpGet]
        [Route("admin/kursbehandler/nytt-kurs")]
        public IActionResult NewCourse()
        {
            return View();
        }

        [HttpPost]
        [Route("admin/kursbehandler/nytt-kurs")]
        public IActionResult NewCourse(NewCourseModel model)
        {
            if (ModelState.IsValid)
            {
                CourseHandler.AddNewCourse(model);
                TempData["StatusMessage"] = StatusMessage.Success("Hurra!", "Du har lagt til et nytt kurs.");
            }
            else
            {
                TempData["StatusMessage"] = StatusMessage.Error("Oops!", "Vennligst fyll ut alle tekstfelt!");
            }
            return RedirectToAction("NewCourse");
        }

        [HttpGet]
        [Route("admin/kursbehandler/behandle-kurs")]
        public IActionResult ManageCourse(int id)
        {
            /* Check if ID attribute is unset */
            if (id == 0) return RedirectToAction("ViewCourses");

            /* Check if course name is null or invalid */
            var courseName = CourseHandler.GetCourseNameById(id);
            if (courseName != null) ViewBag.CourseName = courseName; 
            else return RedirectToAction("ViewCourses");

            /* Get all course modules */
            List<Module> moduleList = CourseHandler.GetAllModulesById(id);
            return View(moduleList);
        }
    }
}
