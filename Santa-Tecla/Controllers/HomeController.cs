using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Santa_Tecla.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Departamento()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult QuienesSomos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contacto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult admiFormulario()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

