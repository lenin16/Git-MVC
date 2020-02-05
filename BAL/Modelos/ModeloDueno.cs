using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Modelos
{
    public class ModeloDueno
    {
        [Key]
        public int IdDueno {get;set;}
        [Display(Name ="Nombre de usuario"),Required,DataType(DataType.Text),MaxLength(12)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name ="Email")]
        public string Correo { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }

    public class ModeloDuenoyMascota:ModeloDueno
    {
        public List<ModeloMascota> Mascotas { get; set; }
        public ModeloDuenoyMascota(int id,string nombre,string apellido)
        {
            IdDueno = id;
            Nombre = nombre;
            Apellido = apellido;
            Mascotas = new List<ModeloMascota>();
        }
    }
}
