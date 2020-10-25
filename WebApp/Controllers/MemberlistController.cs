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
        private IUserHandler UserHandler;
        public MemberlistController(IUserHandler _uh)
        {
            this.UserHandler = _uh;
        }

        [HttpGet]
        [Route("Medlemsliste")]
        public IActionResult Index()
        {
            List<User> ListOfUsers = UserHandler.LoadAll();
            return View(ListOfUsers);
        }
    }
}
