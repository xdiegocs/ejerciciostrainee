using System.Collections.Generic;

namespace Seccion17_Ejercicio1nuevo1.Models
{
    public class Colegio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Clase> Clases { get; set; }
    }
}
