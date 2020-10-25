using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DbHandler.Models;

namespace WebApp.DbHandler.Interfaces
{
    public interface IUserHandler
    {
        public List<User> GetUsers();
        public List<User> GetPublicUsers();
    }

    public class UserHandler : IUserHandler
    {
        private readonly DataContext db;
        public UserHandler(DataContext _db)
        {
            this.db = _db;
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
    }
}
