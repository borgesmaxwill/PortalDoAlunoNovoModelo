﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class LibraryController : Controller
    {
        public PartialViewResult QuickSearch()
        {
            return PartialView();
        }

        //[HttpPost]
        //public ActionResult QuickSearch()
        //{
        //    return View();
        //}

        public PartialViewResult DetailedSearch()
        {
            return PartialView();
        }

        //[HttpPost]
        //public ActionResult DetailedSearch()
        //{
        //    return View();
        //}
    }
}