using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana3
{
    internal class Alumno
    {
        public string nombreAlumno { get; set; }
        public string apellidoAlumno { get; set; }
        public string numeroId { get; set; }
        public string carreraAlumno { get; set; }
        public List<double> notasAlumno { get; set; }

        // Constructor de la clase
        public Alumno(string nombre, string apellido, string identificacion, string carrera, List<double> notas)
        {
            nombreAlumno = nombre;
            apellidoAlumno = apellido;
            numeroId = identificacion;
            carreraAlumno = carrera;
            notasAlumno = notas;
        }

        // Metodo para obtener el promedio de la notas
        public double NotasPromedio()
        {
            if (notasAlumno.Count == 0)
            {
                return 0;
            }

            double suma = 0;
            foreach (var nota in notasAlumno)
            {
                suma += nota;
            }

            return suma / notasAlumno.Count;
        }
    }
}
