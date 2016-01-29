using AmIRegistered2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmIRegistered2.Services;
using System.Security.Cryptography;
using System.Text;

namespace AmIRegistered2.Controllers
{
    
    public class UserController : Controller
    {
        private HashService HashService = new HashService();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //POST: User
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(User userModel)
        {
            // Concatenate the input string
            string inputString = userModel.FirstName + userModel.LastName + userModel.Address + userModel.PhoneNo + userModel.NINO;
            
            // Has the String
            string hashedString = HashService.HashString(inputString);
            
            // Check if hash exists
            Boolean result =  HashService.DoesHashExist(hashedString);

            // Return result
            if (result)
            {
                return View("Success");
            }
            else
            {
                ViewBag.searchFailed = true;
                return View("Index");
            }
            
        }
    }
}