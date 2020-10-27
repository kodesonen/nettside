using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Interfaces;
using WebApp.DbHandler.Models;

namespace WebApp.Controllers
{
    public class CourseController : Controller
    {
        private ICourseHandler CourseHandler;
        public CourseController(ICourseHandler _ch)
        {
            this.CourseHandler = _ch;
        }

        [HttpGet]
        [Route("Kurs")]
        public IActionResult Index()
        {
            List<Course> CourseList = CourseHandler.LoadAll();
            return View(CourseList);
        }
    }
}
