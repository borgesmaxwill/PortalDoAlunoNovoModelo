using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trabalhoIHC.Models;

namespace trabalhoIHC.Controllers
{
    public class LibraryController : MessagerBaseController
    {
        public PartialViewResult QuickSearch()
        {
            return PartialView("_QuickSearch");
        }

        [HttpPost]
        public ActionResult QuickSearch(string titulo)
        {
            IList<Livro> listaDeLivros = new List<Livro>();
            return PartialView("_SearchResults", listaDeLivros]);
        }

        public PartialViewResult DetailedSearch()
        {
            return PartialView("_DetailedSearch");
        }

        [HttpPost]
        public ActionResult DetailedSearch(Livro livro)
        {
            IList<Livro> listaDeLivros = new List<Livro>();
            return PartialView("_SearchResults", listaDeLivros]);
        }
    }
}