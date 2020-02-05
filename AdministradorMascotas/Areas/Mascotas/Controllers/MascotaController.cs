using BAL.Interfaces;
using BAL.Modelos;
using BAL.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdministradorMascotas.Areas.Mascotas.Controllers
{
    public class MascotaController : Controller
    {
        private IRepositorioMascota _repositorioMascota;
        private IRepositorioDueno _repositorioDueno;
        private IRepositorioTipo _repositorioTipo;
        public MascotaController()
        {
            if (_repositorioMascota == null)
                _repositorioMascota = new RepositorioMascota();

            if (_repositorioDueno == null)
                _repositorioDueno = new RepositorioDueno();

            if (_repositorioTipo == null)
                _repositorioTipo = new RepositorioTipo();
        }

        // GET: Mascotas/Mascota
        public ActionResult Inicio()
        {
           var mascotas= _repositorioMascota.ObtenerTodas();
            return View(mascotas);
        }

        // GET: Mascotas/Mascota/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mascotas/Mascota/Create
        public ActionResult Create()
        {
            var duennos = _repositorioDueno.ObtenerTodos();
            var tipos = _repositorioTipo.obtenerTodos();

            ViewBag.duenos = duennos;
            ViewBag.tipos = tipos;
            return View();
        }

        // POST: Mascotas/Mascota/Create
        [HttpPost]
        public ActionResult Create(ModeloMascota modelo)
        {
            try
            {
                var c = 0;
                _repositorioMascota.AgregarMascota(modelo);
                return RedirectToAction("Inicio");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mascotas/Mascota/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mascotas/Mascota/Edit/5
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

        // GET: Mascotas/Mascota/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mascotas/Mascota/Delete/5
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
