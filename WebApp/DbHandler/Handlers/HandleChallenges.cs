using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebApp.DbHandler.Models;
using WebApp.DbHandler;
using System.Linq;

namespace WebApp.DbHandler.Handlers
{
    public class HandleChallenges
    {
        private readonly DataContext db;

        public HandleChallenges(DataContext _db)
        {
            this.db = _db;
        }

        public List<Challenge> GetAllChallenges()
        {
            var Data = db.Challenges;
            List<Challenge> ChallengesList = Data.ToList();
            return ChallengesList;
        }
    }
}
