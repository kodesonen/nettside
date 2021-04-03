using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Interfaces;
using WebApp.DbHandler.Models;
using WebApp.Models.User;

namespace WebApp.Controllers
{
    public class ProfileController : Controller
    {
        private IUserHandler UserHandler;
        private ICourseHandler CourseHandler;
        public ProfileController(IUserHandler _uh, ICourseHandler _ch)
        {
            this.UserHandler = _uh;
            this.CourseHandler = _ch;
        }

        [HttpGet]
        [Route("profil/{id}")]
        public IActionResult Index(string id)
        {
            /* Try to find the user based on ID */
            User user = UserHandler.GetUserById(id);

            /* If user was not found, try again with URL name */
            if (user == null) user = UserHandler.GetUserByUrlName(id);

            /* Proceed if the user was found */
            if (user != null)
            {
                ProfileModel profileModel = new ProfileModel
                {
                    Name = user.FullName,
                    Description = user.Description,
                    StaffPosition = user.StaffPosition,
                    Website = user.Website,
                    LinkedIn = user.LinkedIn,
                    GitHub = user.GitHub,
                    University = user.University,
                    Study = user.Study,
                    WrittenCourses = CourseHandler.GetAllCoursesByUserId(user.Id),
                    WrittenModules = CourseHandler.GetAllModulesByUserId(user.Id)
                };

                return View(profileModel);
            }
            else return RedirectToAction("Index", "Home");
        }
    }
}
