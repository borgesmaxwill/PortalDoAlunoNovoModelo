﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class AccountController : MessagerBaseController
    {
        public ActionResult Login()
        {
            this.AddToastMessage("Este é o novo Portal do Aluno!", "Bem-Vindo!", ToastType.Success);
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