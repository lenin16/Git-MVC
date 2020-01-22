using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Modelos
{
    public class ModeloMascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdDueno { get; set; }
    }
}
