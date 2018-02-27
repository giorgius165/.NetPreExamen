using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaExamen.Models;
using System.Data.Entity;

namespace PruebaExamen.Controllers
{
    public class TrabajadorController : Controller
    {
        Contexto bd = new Contexto();
        // GET: Trabajador
        public ActionResult Index()
        {
            List<TrabajadorModelo> trabajadores = bd.Trabajadores.ToList();
            return View(trabajadores);
        }

        // GET: Trabajador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trabajador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabajador/Create
        [HttpPost]
        public ActionResult Create(TrabajadorModelo trabajador)
        {
            try
            {
                bd.Trabajadores.Add(trabajador); 
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trabajador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trabajador/Edit/5
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

        // GET: Trabajador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trabajador/Delete/5
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
