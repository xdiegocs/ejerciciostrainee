namespace Seccion17_Ejercicio1nuevo1.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ClaseId { get; set; }

        public Clase Clase { get; set; }
    }
}
