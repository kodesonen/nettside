using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DbHandler.Models;

namespace WebApp.DbHandler.Interfaces
{
    public interface IChallengeHandler
    {
        public List<Challenge> LoadAll();
    }

    public class ChallengeHandler : IChallengeHandler
    {
        private readonly DataContext db;
        public ChallengeHandler(DataContext _db)
        {
            this.db = _db;
        }

        public List<Challenge> LoadAll()
        {
            var Data = db.Challenges;
            List<Challenge> ChallengesList = Data.ToList();
            return ChallengesList;
        }
    }
}
