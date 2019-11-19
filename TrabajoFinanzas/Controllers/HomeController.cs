using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinanzas.Models;
using TrabajoFinanzas.Models.DAO;

namespace TrabajoFinanzas.Controllers
{
    public class HomeController : Controller
    {
        DAO dao = new DAO();
        bdFinanzassEntities4 ds = new bdFinanzassEntities4();

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

        public ActionResult Resultados(String NombreBando, String diasAnio, String fr)
        {
            try
            {
                // TODO: Add delete logic here
                leasing ls = new leasing();
                ls.idBanco = Int32.Parse(NombreBando);
                ls.Banco = dao.datosBancoXID(Int32.Parse(NombreBando));

                //var numero = dao.carroEntid(carro).Precio;
                //ls.NprevioVenta = float.Parse(totalFacturado);

                ls.idFrecuencia = dao.frecuenciaDD(fr).idFrecuencia;
                //ls.idCarro = dao.carroEntid(carro).idCarro;
                //ls.NAnios = Int32.Parse(anios);
                ls.Frecuencia = dao.frecuenciaDD(fr);

                //Session["plazoGracia"] = Int32.Parse(CantCu);
                //Session["tipoGracia"] = (String)pl;

                Session["datosPlanPago"] = ls;
                //var prestamo = float.Parse(pv) - (int.Parse(ci) * 0.01 * int.Parse(pv));

                return RedirectToAction("Index", "PlanDePagos");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Seleccion()
        {
            var items = ds.nameBancoes.ToList();
            if (items != null) ViewBag.data = items;

            var itemss = ds.nameEmpresas.ToList();
            if (itemss != null) ViewBag.empresas = itemss;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}