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
                    Name = user.UserName,
                    Description = user.Description,
                    StaffPosition = user.StaffPosition,
                    LinkedIn = user.LinkedIn,
                    GitHub = user.GitHub,
                    University = user.University,
                    Study = user.Study
                };

                if (string.IsNullOrEmpty(profileModel.Description)) profileModel.Description = $"Velkommen til {profileModel.Name} sin profil!";
                if (string.IsNullOrEmpty(profileModel.Description)) profileModel.Description = $"Velkommen til {profileModel.Name} sin profil!";

                return View(profileModel);
            }
            else return RedirectToAction("Index", "Home");
        }
    }
}
