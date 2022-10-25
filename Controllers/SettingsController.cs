using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Models;
using WebApp.DbHandler;
using WebApp.DbHandler.Interfaces;
using Microsoft.AspNetCore.Authorization;
using WebApp.Models.Settings;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class SettingsController : Controller
    {
        private IUserHandler UserHandler;

        public SettingsController(IUserHandler _uh)
        {
            this.UserHandler = _uh;
        }

        [HttpGet]
        [Authorize]
        [Route("innstillinger")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        [Route("innstillinger/endre-profil")]
        public IActionResult EditProfile()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        [Route("innstillinger/endre-passord")]
        public IActionResult EditPassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [Route("innstillinger/endre-passord")]
        public async Task<IActionResult> EditPassword(EditPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserHandler.ChangePassword(model);

                if (result.Succeeded)
                {
                    ModelState.Clear();
                    TempData["StatusMessage"] = StatusMessage.Success("Hurra!", "Du har oppdatert passordet ditt!");
                }
                else
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(model);
                }
            }
            return View();
        }
    }
}
