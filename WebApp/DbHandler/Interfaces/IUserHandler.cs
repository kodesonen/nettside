using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DbHandler.Models;

namespace WebApp.DbHandler.Interfaces
{
    public interface IUserHandler
    {
        public List<User> LoadAll();
    }

    public class UserHandler : IUserHandler
    {
        private readonly DataContext db;
        public UserHandler(DataContext _db)
        {
            this.db = _db;
        }

        public List<User> LoadAll()
        {
            var Data = db.Users;
            List<User> ListOfUsers = Data.ToList();
            return ListOfUsers;
        }
    }
}
