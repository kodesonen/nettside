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
        public ProfileController(IUserHandler _uh)
        {
            this.UserHandler = _uh;
        }

        [HttpGet]
        [Route("bruker/{id}")]
        public IActionResult Index(string id)
        {
            User user = UserHandler.GetUserById(id);

            if (user != null)
            {
                ProfileModel profileModel = new ProfileModel
                {
                    Name = user.UserName,
                    Description = user.Description,
                    StaffPosition = user.StaffPosition,
                    LinkedIn = user.LinkedIn,
                    GitHub = user.GitHub,
                    University = user.University,
                    Study = user.Study
                };

                return View(profileModel);
            }
            else return RedirectToAction("Index", "Home");
        }
    }
}
