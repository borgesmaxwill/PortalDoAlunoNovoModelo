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
        [HttpGet]
        public PartialViewResult BookSearch()
        {
            return PartialView("_BookSearch");
        }

        [HttpPost]
        public PartialViewResult BookSearchResult(Livro livro)
        {
            IList<Livro> listaDeLivros = livro.Busca();
            return PartialView("_SearchResults", listaDeLivros);
        }
    }
}