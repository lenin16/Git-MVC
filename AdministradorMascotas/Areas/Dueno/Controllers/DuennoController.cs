using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL.Interfaces;
using BAL.Modelos;
using BAL.Repositorios;

namespace AdministradorMascotas.Areas.Dueno.Controllers
{
    public class DuennoController : Controller
    {
        private IRepositorioDueno _repositorioDueno;
        public DuennoController()
        {
            if (_repositorioDueno == null)
                _repositorioDueno = new RepositorioDueno();
        }

        // GET: Dueno/Duenno
        public ActionResult Inicio()
        {
            var lista = _repositorioDueno.ObtenerTodos();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ModeloDueno modelo)
        {
            if (ModelState.IsValid)
            {
                _repositorioDueno.AgregarDueno(modelo);
            }

            return RedirectToAction("Inicio");
        }

        public ActionResult Details(int id)
        {
            //var dueno=_repositorioDueno.ObtenerDuenoPorId(id);
            var dueno = _repositorioDueno.obtenerDuenoConMascotas(id);
            return View(dueno);
        }

        public ActionResult Edit(int id)
        {
            var dueno = _repositorioDueno.ObtenerDuenoPorId(id);
            return View(dueno);
        }

        [HttpPost]
        public ActionResult Edit(ModeloDueno modelo)
        {
            _repositorioDueno.EditarDueno(modelo);
            return RedirectToAction("Inicio");
        }

        public ActionResult Delete(int id)
        {
           var dueno= _repositorioDueno.ObtenerDuenoPorId(id);
            return View(dueno);
        }

        [HttpPost]
        public ActionResult DeleteDueno(int IdDueno)
        {
            _repositorioDueno.EliminarDueno(IdDueno);
            return RedirectToAction("Inicio");

        }
    }
}