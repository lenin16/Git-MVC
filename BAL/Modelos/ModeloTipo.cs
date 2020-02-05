using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Modelos
{
    public class ModeloTipo
    {
        [Key]
        public int IdTipo { get; set; }
        [MaxLength(50),Display(Name ="Nombre del Tipo")]
        public string Nombre { get; set; }
        [MaxLength(120)]
        public string Descripcion { get; set; }
        public List<ModeloMascota> Mascotas { get; set; }
    }
}
