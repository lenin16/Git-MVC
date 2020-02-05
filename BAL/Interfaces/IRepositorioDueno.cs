using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Modelos;

namespace BAL.Interfaces
{
    public interface IRepositorioDueno
    {
        void AgregarDueno(ModeloDueno modelo);
        void EliminarDueno(int id);
        List<ModeloDueno> ObtenerTodos();
        ModeloDueno ObtenerDuenoPorId(int id);
        void EditarDueno(ModeloDueno modelo);
        ModeloDuenoyMascota obtenerDuenoConMascotas(int idDueno);
    }
}
