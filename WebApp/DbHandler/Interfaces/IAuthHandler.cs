using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApp.DbHandler.Models;
using WebApp.Models.Auth;

namespace WebApp.DbHandler.Interfaces
{
    public interface IAuthHandler
    {
        Task<IdentityResult> CreateUser(RegisterModel registerModel);
        Task<SignInResult> SignIn(LoginModel loginModel);
        Task SignOut();
    }

    public class AuthHandler : IAuthHandler
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AuthHandler(UserManager<User> _userManager, SignInManager<User> _signInManager)
        {
            this.userManager = _userManager;
            this.signInManager = _signInManager;
        }

        public async Task<IdentityResult> CreateUser(RegisterModel registerModel)
        {
            var user = new User()
            {
                Email = registerModel.Email,
                UserName = registerModel.Email,
                FullName = registerModel.Name,
                University = registerModel.University,
                Study = registerModel.Study,
                Degree = registerModel.Degree
            };

            var result = await userManager.CreateAsync(user, registerModel.Password);
            return result;
        }

        public async Task<SignInResult> SignIn(LoginModel loginModel)
        {
            var result = await signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, true, false);
            return result;
        }

        public async Task SignOut()
        {
            await signInManager.SignOutAsync();
        }
    }
}
