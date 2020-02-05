using BAL.Interfaces;
using BAL.Modelos;
using BAL.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdministradorMascotas.Areas.TipoMascota.Controllers
{
    public class TipoMascotaController : Controller
    {
        private IRepositorioTipo _repositorioTipo;
        public TipoMascotaController()
        {
            if (_repositorioTipo == null)
                _repositorioTipo = new RepositorioTipo();
        }

        // GET: TipoMascota/TipoMascota
        public ActionResult Inicio()
        {
            var tipos = _repositorioTipo.obtenerTodos();
            return View(tipos);
        }

        // GET: TipoMascota/TipoMascota/Details/5
        public ActionResult Details(int id)
        {
            var tipo = _repositorioTipo.obtenerTipo(id);
            return View(tipo);
        }

        // GET: TipoMascota/TipoMascota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMascota/TipoMascota/Create
        [HttpPost]
        public ActionResult Create(ModeloTipo modelo)
        {
            try
            {                
                _repositorioTipo.AgregarTipo(modelo);
                return RedirectToAction("Inicio");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoMascota/TipoMascota/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoMascota/TipoMascota/Edit/5
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

        // GET: TipoMascota/TipoMascota/Delete/5
        public ActionResult Delete(int id)
        {
            var tipo = _repositorioTipo.obtenerTipo(id);
            return View(tipo);
        }

        // POST: TipoMascota/TipoMascota/Delete/5
        [HttpPost]
        public ActionResult DeleteTipo(int IdTipo)
        {
            _repositorioTipo.EliminarTipo(IdTipo);
            return RedirectToAction("Inicio");
        }

        public ActionResult verMascotaPorTipo()
        {
            var tipos = _repositorioTipo.obtenerTodos();
            return View(tipos);
        }

        public ActionResult verMascotasDelTipo(int idTipo)
        {
            var mascotasPorTipo = _repositorioTipo.obtenerMascotaPorTipo(idTipo);
            return PartialView(mascotasPorTipo);
        }
    }
}
