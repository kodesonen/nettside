using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using DatabaseHandler.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Auth;

namespace WebApp.Controllers
{
    /*
	 * TODO
	 *	Add modelvalidators
	 *  Add Model errors
	 *	Add Validation summary
	 */

    public class AuthenticationController : Controller
    {
        private readonly UserManager<KodesonenUser> userManager;
        private readonly SignInManager<KodesonenUser> signInManager;

        public AuthenticationController(
			UserManager<KodesonenUser> userManager,
			SignInManager<KodesonenUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        #region login
        [HttpGet]
		[Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
		[Route("Login")]
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Modelstate invalid");
                return View(model);
            }

            var result = signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);

            if (!result.Result.Succeeded)
            {
                Console.WriteLine("Password does not match");
                return View(model);
            }

            return View();
        }

        #endregion login

        #region register
        [HttpGet]
		[Route("Join")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
		[Route("Join")]
        public async Task<IActionResult> RegisterAsync(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Modelstate is invalid");
                return View(ModelState);
            }

            KodesonenUser user = new KodesonenUser()
            {
                Id = Guid.NewGuid().ToString(),
                Email = model.Email,
                UserName = model.Email,
                //Add first,lastname
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors.ToList())
                    ModelState.AddModelError("All", error.Description.ToString());
                Console.WriteLine("Error when creating user");
                return View(model);
            }

            await signInManager.PasswordSignInAsync(user.Email, model.Password, true, false);
            Console.WriteLine("Registered!");
            return View("Success");
        }

        #endregion register
    }
}
