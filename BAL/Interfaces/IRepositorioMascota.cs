using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Modelos;

namespace BAL.Interfaces
{
    public interface IRepositorioMascota
    {
        void AgregarMascota(ModeloMascota modelo);
        void EliminarMascota(int id);
        List<ModeloMascota> ObtenerTodas();
        ModeloMascota ObtenerMascotaPorId(int id);
        void EditarMascota(ModeloMascota modelo);
    }
}
