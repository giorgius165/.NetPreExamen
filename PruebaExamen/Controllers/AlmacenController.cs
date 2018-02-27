using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaExamen.Models;
using System.Data.Entity;

namespace PruebaExamen.Controllers
{
    public class AlmacenController : Controller
    {
        // GET: Almacen
        Contexto bd = new Contexto();
        public ActionResult Index()
        {
            var almacenes = bd.Almacenes.Include(x => x.AlmacenTrabajador).Include(y => y.Materiales).ToList();
            ViewBag.cualquiera = bd.Trabajadores.ToList();
            return View(almacenes);
        }

        // GET: Almacen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ListaCondicionada()
        {
            List<AlmacenModelo> almacenes = bd.Almacenes.ToList();
            return View(almacenes);
        }

        // GET: Almacen/Create
        public ActionResult Create()
        {
            ViewBag.lista = new MultiSelectList(bd.Trabajadores, "ID", "Nombre");
            return View();
        }

        // POST: Almacen/Create
        [HttpPost]
        public ActionResult Create(AlmacenModelo almacen)
        {
            try
            {
                bd.Almacenes.Add(almacen);
                bd.SaveChanges();

                foreach (var trabajadorID in almacen.TrabajadoresSeleccionados)
                {
                    /*VehiculosExtrasModelos vehiculosExtrasModelos=new VehiculosExtrasModelos();
                    vehiculosExtrasModelos.extraID = extraID;*/

                    var obj = new AlmacenTrabajadorModelo() {AlmacenID = almacen.ID, TrabajadorID = trabajadorID };
                    bd.AlmacenesTrabajadores.Add(obj);
                }
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Almacen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Almacen/Edit/5
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

        // GET: Almacen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Almacen/Delete/5
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
