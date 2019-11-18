using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinanzas.Models;
using TrabajoFinanzas.Models.DAO;

namespace TrabajoFinanzas.Controllers
{
    public class FacturaController : Controller
    {
        bdFinanzassEntities3 ds = new bdFinanzassEntities3();
        DAO dao = new DAO();

        // GET: Factura
        public ActionResult Index()
        {
            var items = ds.nameBancoes.ToList();
            if (items != null) ViewBag.data = items;
            
            ViewBag.Frecuencia = ds.Frecuencias.ToList();
            ViewBag.plazoGracia = ds.PlazoGracias.ToList();
            return View();
        }

        // GET: Factura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Factura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Factura/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Factura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Simulador/5
        [HttpPost]
        public ActionResult Simulador(String NombreBando, String diasAnio, String fr, String tea, String fechaDescuento, String tipoMoneda,String fechaEmision,String fechaPago,String totalFacturado)
        {
            try
            {
                // TODO: Add delete logic here
                leasing ls = new leasing();
                ls.idBanco = Int32.Parse(NombreBando);
                ls.Banco = dao.datosBancoXID(Int32.Parse(NombreBando));
                
                //var numero = dao.carroEntid(carro).Precio;
                ls.NprevioVenta = float.Parse(totalFacturado);

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

        // POST: Factura/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Factura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Factura/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
