using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Santa_Tecla.Controllers
{
    public class AdmisionesController : Controller
    {
        //
        // GET: /Admisiones/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admisiones()
        {
            return View();
        }
        
      
        public ActionResult HistoriaClinica()
        {
            return View();
        }
        public ActionResult Farmacia()
        {
            return View();
        }
        public ActionResult DietaPaciente()
        {
            return View();
        }
	}
}