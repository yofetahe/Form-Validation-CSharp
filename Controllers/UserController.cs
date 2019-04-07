using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formSubmission.Models;

namespace formSubmission.Controllers
{
    public class UserController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("AddUserInfo");
            } 
            else 
            {
                return View("Index");
            }
        }

        [HttpGet("AddUserInfo")]
        public IActionResult AddUserInfo()
        {
            return View("Result");
        }

    }
}
