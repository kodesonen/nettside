using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Interfaces;
using WebApp.DbHandler.Models;
using WebApp.Models.Courses;

namespace WebApp.Controllers
{
    public class CourseController : Controller
    {
        private ICourseHandler CourseHandler;
        private IUserHandler uh;

        public CourseController(ICourseHandler _ch, IUserHandler uh)
        {
            this.CourseHandler = _ch;
            this.uh = uh;
        }

		[HttpGet]
        [Route("kurs")]
        public IActionResult Index()
        {
            List<Course> CourseList = CourseHandler.LoadAll();
            return View(CourseList);
        }

		[HttpGet]
        [Route("kurs/{id}")]
        public IActionResult KursSide(int id)
        {
            List<Module> ModuleList = CourseHandler.GetModulesByCourseId(id);
            List<ModuleViewModel> model = new List<ModuleViewModel>();

            foreach (var mod in ModuleList)
            {
                ModuleViewModel vm = new ModuleViewModel();
                vm.CourseId = id;
                vm.courseName = CourseHandler.GetCourseNameById(id);
                var usr = uh.GetUserById(vm.AuthorName);
                vm.AuthorName = "Unknown";

                if (usr != null) vm.AuthorName = usr.UserName;
                vm.module = mod;
                model.Add(vm);
            }
			
            return View(model);
        }

		[HttpGet]
        [Route("kurs/side/{id}")]
        public IActionResult ModulSide(int id)
        {
            Module model = CourseHandler.GetModuleById(id);
            return View(model);
        }
    }
}
