using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class LibraryController : Controller
    {
        public ActionResult QuickSearch()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult QuickSearch()
        //{
        //    return View();
        //}

        public ActionResult DetailedSearch()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult DetailedSearch()
        //{
        //    return View();
        //}
    }
}