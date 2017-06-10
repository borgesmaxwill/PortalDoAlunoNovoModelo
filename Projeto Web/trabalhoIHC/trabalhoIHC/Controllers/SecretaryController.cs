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
            return PartialView();
        }

        public PartialViewResult SchoolRecords()
        {
            return PartialView();
        }

        public PartialViewResult RequestsTable()
        {
            return PartialView();
        }
    }
}