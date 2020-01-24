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
            throw new NotImplementedException();
        }

        public void EditarDueno(ModeloDueno modelo)
        {
            throw new NotImplementedException();
        }

        public void EliminarDueno(int id)
        {
            throw new NotImplementedException();
        }

        public ModeloDueno ObtenerDuenoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ModeloDueno> ObtenerTodos()
        {
            throw new NotImplementedException();
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
    }
}
