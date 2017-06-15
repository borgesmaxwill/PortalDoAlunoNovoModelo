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
        public PartialViewResult BookSearch()
        {
            return PartialView("_BookSearch");
        }

        [HttpPost]
        public PartialViewResult BookSearch(Livro livro)
        {
            IList<Livro> listaDeLivros = new List<Livro>();
            return PartialView("_SearchResults", listaDeLivros);
        }
    }
}