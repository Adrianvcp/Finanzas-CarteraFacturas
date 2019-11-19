using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinanzas.Models;
using TrabajoFinanzas.Models.DAO;

namespace TrabajoFinanzas.Controllers
{
    public class FacturaController : Controller
    {
        bdFinanzassEntities4 ds = new bdFinanzassEntities4();
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
        public ActionResult Resultado(String diasAnio, String fr, String tea, String fechaDescuento, String tipoMoneda, String fechaEmision, String fechaPago, String totalFacturado)
        {
            try
            {
                
                var dat = (1 + (Convert.ToInt32(tea) / 100));
                DateTime fechaP = DateTime.ParseExact(fechaPago, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime fechaD = DateTime.ParseExact(fechaDescuento, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                var a = fechaD - fechaP;
                int differenceInDays = a.Days;
                /*
                double teporc = Math.Pow(dat,(differenceInDays/Convert.ToInt32(diasAnio)))  - 1;
                ViewBag.teporc = teporc*100;
                //*100

                var dporc = (teporc / (1 + teporc));
                ViewBag.dporc = dporc * 100;
                */

                return RedirectToAction("Resultado", "Factura");
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
