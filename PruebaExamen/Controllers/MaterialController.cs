using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaExamen.Models;
using System.Data.Entity;
using System.Data.SqlClient;

namespace PruebaExamen.Controllers
{
    public class MaterialController : Controller
    {
        
        Contexto bd = new Contexto();

        public class MaterialTotal
        {
            public string Nom { get; set; }
            public string Nombre { get; set; }
            public string Peso { get; set; }
        }

        // GET: Material
        public ActionResult Index()
        {
            List<MaterialModelo> materiales = bd.Materiales.Include(x => x.Almacen).ToList();
            return View(materiales);
        }

        // GET: Material/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ListaCondicionada(int almacenID)
        {
            AlmacenModelo marca = bd.Almacenes.Include("materiales").FirstOrDefault(x => x.ID == almacenID);
            return View(marca);
        }

        public ActionResult ListaPorPeso(string Peso = "")
        {
            ViewBag.Peso = new SelectList(bd.Materiales.Select(x => new { Peso = x.Peso }).Distinct(), "Peso", "Peso");
            var lista = bd.Database.SqlQuery<MaterialTotal>("getMaterialesPorPeso @PesoSeleccionado", new SqlParameter("@PesoSeleccionado", Peso)).ToList();
            return View(lista);
        }

        // GET: Material/Create
        public ActionResult Create()
        {
            ViewBag.AlmacenId = new SelectList(bd.Almacenes, "ID", "Nombre");
            return View();
        }

        // POST: Material/Create
        [HttpPost]
        public ActionResult Create(MaterialModelo material)
        {
            try
            {
                bd.Materiales.Add(material);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Material/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Material/Edit/5
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

        // GET: Material/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Material/Delete/5
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
