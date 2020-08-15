using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseHandler.Dataset;
using DatabaseHandler.Models;

namespace DatabaseHandler.Handlers
{
    public class HandleUsers
    {
        public static List<User> GetAllUsers()
        {
            using (var db = new DataContext())
            {
                var Data = db.Users;
                List<User> Users = Data.ToList();
                return Users;
            }
        }
    }
}
