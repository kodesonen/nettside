using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbHandler.Models;
using WebApp.DbHandler;
using WebApp.DbHandler.Interfaces;

namespace WebApp.Controllers
{
    public class MemberlistController : Controller
    {
        private IChallengeHandler ChallengeHandler;
        public MemberlistController(IChallengeHandler _ch)
        {
            this.ChallengeHandler = _ch;
        }

        [HttpGet]
        [Route("Medlemsliste")]
        public IActionResult Index()
        {
            //List<Challenge> ChallengesList = ChallengeHandler.LoadAll();
            //return View(ChallengesList);
            return View();
        }
    }
}
