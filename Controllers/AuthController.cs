using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models.Auth;
using WebApp.Helpers;
using WebApp.DbHandler.Interfaces;

namespace WebApplication.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthHandler AuthHandler;
        
        public AuthController(IAuthHandler authHandler)
        {
            AuthHandler = authHandler;
        }

        [HttpGet]
        [Route("logg-inn")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("logg-inn")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await AuthHandler.SignIn(model);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["StatusMessage"] = StatusMessage.Error("Oops!", "Ditt passord stemmer ikke. Vennligst prøv igjen!");
                    //ModelState.AddModelError("", "Invalid credentials");
                    return View(model);
                }
            }

            return View();
        }

        [HttpGet]
        [Route("join")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("join")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await AuthHandler.CreateUser(model);

                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }

                    return View(model);
                }
                else
                {
                    ModelState.Clear();
                    TempData["StatusMessage"] = StatusMessage.Success("Hurra!", "Du har registert en bruker og kan nå logge inn!");
                }
            }

            return View();
        }

        [HttpGet]
        [Route("logg-ut")]
        public async Task<IActionResult> Logout()
        {
            await AuthHandler.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
