using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DbHandler.Models;
using WebApp.Models.Settings;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApp.DbHandler.Interfaces
{
    public interface IUserHandler
    {
        public List<User> GetUsers();
        public List<User> GetPublicUsers();
        public User GetUserById(string userId);
        public User GetUserByUrlName(string name);
        Task<IdentityResult> ChangePassword(EditPasswordModel model);
    }

    public class UserHandler : IUserHandler
    {
        private readonly DataContext db;
        private readonly UserManager<User> userManager;
        private readonly IHttpContextAccessor httpContext;
        
        public UserHandler(DataContext _db, UserManager<User> _userManager, IHttpContextAccessor _httpContext)
        {
            this.db = _db;
            this.userManager = _userManager;
            this.httpContext = _httpContext;
        }

        public List<User> GetUsers()
        {
            var Data = db.Users;
            List<User> ListOfUsers = Data.ToList();
            return ListOfUsers;
        }

        public List<User> GetPublicUsers()
        {
            var Data = db.Users.Where(x => x.Private == false).OrderByDescending(y => y.Id);
            List<User> ListOfUsers = Data.ToList();
            return ListOfUsers;
        }

        public User GetUserById(string userId)
        {
            var Data = db.Users.Where(x => x.Id == userId).FirstOrDefault();
            if (Data != null) return Data;
            return null;
        }

        public User GetUserByUrlName(string name)
        {
            var Data = db.Users.Where(x => x.UrlName == name).FirstOrDefault();
            if (Data != null) return Data;
            return null;
        }

        public async Task<IdentityResult> ChangePassword(EditPasswordModel model)
        {
            User user = await userManager.GetUserAsync(httpContext.HttpContext.User);
            var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            return result;
        }
    }
}
