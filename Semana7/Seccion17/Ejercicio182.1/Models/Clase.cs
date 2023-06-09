using System.Collections.Generic;

namespace Seccion17_Ejercicio1nuevo1.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ColegioId { get; set; }
        
        public Colegio Colegio { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
