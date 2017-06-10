using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class InformacoesAcademicasController : MessagerBaseController
    {

        public PartialViewResult RetornarQuadroDeHorarios()
        {
            return PartialView("_QuadroDeHorarios");
        }

        public PartialViewResult RetornarGradeAcademica()
        {
            return PartialView("_GradeAcademica");
        }
    }
}