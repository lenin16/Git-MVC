using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Modelos;

namespace BAL.Interfaces
{
    public interface IRepositorioTipo
    {
        void AgregarTipo(ModeloTipo tipo);
        void EliminarTipo(int id);
        void EditarTipo(int id);
        ModeloTipo obtenerTipo(int id);
        List<ModeloTipo> obtenerTodos();
        List<ModeloMascota> obtenerMascotaPorTipo(int idTipo);


    }
}
