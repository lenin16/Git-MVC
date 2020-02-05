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
    public class RepositorioTipo : IRepositorioTipo
    {
        public void AgregarTipo(ModeloTipo tipo)
        {
            using (var db = new BdMascotaEntities())
            {
                db.TBL_TIPO_MASCOTA.Add(MapearHaciaBaseDatos(tipo));
                db.SaveChanges();
            }
        }

        public List<ModeloMascota> obtenerMascotaPorTipo(int idTipo)
        {
            using (var db = new BdMascotaEntities())
            {
                var mascotas = db.TBL_MASCOTA.Where(m => m.IdTipo == idTipo).Select(m=>new ModeloMascota()
                {
                    Nombre=m.Nombre,
                    Descripcion=m.Descripcion
                }).ToList();
                return mascotas;
            }
        }

        public void EditarTipo(int id)
        {
            
            throw new NotImplementedException();
        }

        public void EliminarTipo(int id)
        {
            using (var db = new BdMascotaEntities())
            {
                db.TBL_TIPO_MASCOTA.Remove(db.TBL_TIPO_MASCOTA.Find(id));
                db.SaveChanges();

            }
        }

        public ModeloTipo obtenerTipo(int id)
        {
            using (var db = new BdMascotaEntities())
            {
                return MapearHaciaAplicacion(db.TBL_TIPO_MASCOTA.Find(id));
            }
        }

        public List<ModeloTipo> obtenerTodos()
        {
            using (var db = new BdMascotaEntities())
            {
                return db.TBL_TIPO_MASCOTA.Select(MapearHaciaAplicacion).ToList();
            }
        }

        private TBL_TIPO_MASCOTA MapearHaciaBaseDatos(ModeloTipo modelo)
        {
            return new TBL_TIPO_MASCOTA()
            {
                IdTipo=modelo.IdTipo,
                NombreTipo=modelo.Nombre,
                Descripcion=modelo.Descripcion
            };
        }

        private ModeloTipo MapearHaciaAplicacion(TBL_TIPO_MASCOTA tbl)
        {
            return new ModeloTipo()
            {
                IdTipo = tbl.IdTipo,
                Nombre = tbl.NombreTipo,
                Descripcion = tbl.Descripcion
            };
        }
    }
}
