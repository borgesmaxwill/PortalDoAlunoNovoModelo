﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Password, string Username)
        {
            if (Password.Equals("admin") && Username.Equals("admin"))
                return RedirectToAction("Index", "Home");
            return View();
        }
    }
}