﻿using Microsoft.AspNetCore.Mvc;

namespace DemoUserAuth.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }   

        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
