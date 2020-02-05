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
    public class RepositorioDueno : IRepositorioDueno
    {
        public void AgregarDueno(ModeloDueno modelo)
        {
            using (BdMascotaEntities db = new BdMascotaEntities())
            {
                db.TBL_DUENO.Add(mapearABaseDatos(modelo));
                db.SaveChanges();
            }
        }

        public void EditarDueno(ModeloDueno modelo)
        {
            using (var db = new BdMascotaEntities())
            {
                var editar = db.TBL_DUENO.Find(modelo.IdDueno);
                editar.Correo = modelo.Correo;
                db.SaveChanges();
            }

        }

        public ModeloDuenoyMascota obtenerDuenoConMascotas(int idDueno)
        {
            using (var db = new BdMascotaEntities())
            {
                var dueno = db.TBL_DUENO.Find(idDueno);
                var duenoConMascota = mapearDuenoyMascotaHaAplicacion(dueno);
                return duenoConMascota;
            }
        }

        public void EliminarDueno(int id)
        {
            using (var db = new BdMascotaEntities())
            {
                var eliminar=db.TBL_DUENO.Find(id);
                db.TBL_DUENO.Remove(eliminar);
                db.SaveChanges();
            }        
        }

        public ModeloDueno ObtenerDuenoPorId(int id)
        {
            using (var db = new BdMascotaEntities())
            {
                return mapearAAplicacion(db.TBL_DUENO.Find(id));
            }
        }

        public List<ModeloDueno> ObtenerTodos()
        {
            using (var db = new BdMascotaEntities())
            {
                return db.TBL_DUENO.Select(mapearAAplicacion).ToList();
            }
        }

        private TBL_DUENO mapearABaseDatos(ModeloDueno modelo)
        {
            return new TBL_DUENO()
            {
                IdDueno=modelo.IdDueno,
                Nombre = modelo.Nombre,
                Apellido=modelo.Apellido,
                Correo=modelo.Correo,
            };
        }

        private ModeloDueno mapearAAplicacion(TBL_DUENO tbl)
        {
            return new ModeloDueno()
            {
                IdDueno=tbl.IdDueno,
                Nombre=tbl.Nombre,
                Apellido=tbl.Apellido,
                Correo=tbl.Correo,
            };
        }

        private ModeloDuenoyMascota mapearDuenoyMascotaHaAplicacion(TBL_DUENO tbl)
        {
            return new ModeloDuenoyMascota(tbl.IdDueno, tbl.Nombre, tbl.Apellido)
            {
                Mascotas=tbl.TBL_MASCOTA.Select(m=>new ModeloMascota()
                {
                    IdDueno=m.IdDueno,
                    Nombre=m.Nombre,
                    Descripcion=m.Descripcion
                }).ToList()
            };
        }
    }
}
