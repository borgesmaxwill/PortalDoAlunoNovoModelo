using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class SecretaryController : MessagerBaseController
    {
        public PartialViewResult RegistrationStatement()
        {
            return PartialView("_RegistrationStatement");
        }

        public PartialViewResult RequestsTable()
        {
            return PartialView("_RequestsTable");
        }

    }
}