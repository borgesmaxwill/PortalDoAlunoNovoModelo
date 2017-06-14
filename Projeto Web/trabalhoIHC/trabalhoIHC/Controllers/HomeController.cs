using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class HomeController : MessagerBaseController
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}