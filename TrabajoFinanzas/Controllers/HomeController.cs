using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinanzas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
         

        public ActionResult CerrarSesion()
        {

            Session["estado"] = 0;
            Session["userName"] = "";
            Session["idUser"] = 0;
            Session["plazoGracia"] = 0;
            Session["frecuencia"] = 0;
            Session["frDias"] = 0;
            return View("Index");
        }

        public ActionResult About()
        {
          
            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}