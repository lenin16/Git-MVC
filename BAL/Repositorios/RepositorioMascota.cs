using BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Modelos;
using DAL;

namespace BAL.Repositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        public void AgregarMascota(ModeloMascota modelo)
        {
            using (var db = new BdMascotaEntities())
            {
                db.TBL_MASCOTA.Add(MapearABaseDeDatos(modelo));
                db.SaveChanges();
            }
        }

        public void EditarMascota(ModeloMascota modelo)
        {
            using (var db = new BdMascotaEntities())
            {
                var editar = db.TBL_MASCOTA.Find(modelo.IdMascota);
                editar.Descripcion = modelo.Descripcion;
                editar.Nombre = modelo.Nombre;
                db.SaveChanges();
            }
        }

        public void EliminarMascota(int id)
        {
            using (var db = new BdMascotaEntities())
            {
                var eliminar_Mascota = db.TBL_MASCOTA.Find(id);
                db.TBL_MASCOTA.Remove(eliminar_Mascota);
                db.SaveChanges();
            }
        }

        public ModeloMascota ObtenerMascotaPorId(int id)
        {
            using (var db = new BdMascotaEntities())
            {
                return MapearAAplicacion(db.TBL_MASCOTA.Find(id));
            }
        }

        public List<ModeloMascota> ObtenerTodas()
        {
            using (var db = new BdMascotaEntities())
            {
                return db.TBL_MASCOTA.Select(MapearAAplicacion).ToList();
            }
        }

        private TBL_MASCOTA MapearABaseDeDatos(ModeloMascota modelo)
        {
            return new TBL_MASCOTA()
            {
                Descripcion = modelo.Descripcion,
                IdMascota = modelo.IdMascota,
                IdDueno = modelo.IdDueno,
                Nombre=modelo.Nombre,
                IdTipo=modelo.IdTipo
            };
        }

        private ModeloMascota MapearAAplicacion(TBL_MASCOTA tbl)
        {
            return new ModeloMascota()
            {
                Descripcion = tbl.Descripcion,
                Nombre = tbl.Nombre,
                IdMascota=tbl.IdMascota,
                IdDueno=tbl.IdDueno,
            };
        }
    }
}
