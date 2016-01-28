using AmIRegistered2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmIRegistered2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //POST: User
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Search(User userModel)
        {
            // Check the submitted data
            return "Here";
            // If a match is found

            // Else no match was found
        }
    }
}