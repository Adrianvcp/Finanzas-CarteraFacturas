     using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinanzas.Models;
using TrabajoFinanzas.Models.DAO;

namespace TrabajoFinanzas.Controllers
{
    public class EmpresaController : Controller
    {

        DAO dao = new DAO();


        // GET: Empresa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empresa/Edit/5
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

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(String name, String ruc, String prestigio)
        {
            try
            {
                // TODO: Add insert logic here
                Empresa obj = new Empresa();
                obj.Nombre = name;
                obj.RUC = ruc;
                
                obj.Prestigio = Convert.ToInt32(prestigio);

                dao.addEmpresa(obj);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
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
