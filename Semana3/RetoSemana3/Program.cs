namespace Ejercicio_Semana3
{
    internal class Program
    {
        // Se crea la lista para almacenar los alumnos
        static List<Alumno> listaAlumnos = new List<Alumno>();

        static void Main(string[] args)
        {
            // Se agregan los alumnos a la lista
            listaAlumnos.Add(new Alumno("Jose", "Del Rey", "01022217", "Ciencias Medicas", new List<double> { 21, 16, 54, 61, 70}));
            listaAlumnos.Add(new Alumno("Salvador", "Lopez", "02022217", "Derecho", new List<double> { 74, 61, 50, 84, 21}));
            listaAlumnos.Add(new Alumno("Carlos", "Perez", "03022217", "Criminologia", new List<double> { 2, 4, 8, 7, 4}));
            listaAlumnos.Add(new Alumno("Antonio", "Flags", "04022217", "Ingenieria Ambiental", new List<double> { 89, 74, 60, 41, 26}));
            listaAlumnos.Add(new Alumno("James", "Bond", "00702217", "Admon de Empresas", new List<double> { 72, 68, 16, 65, 99}));
            
            MostrarAlumnos();
            Console.ReadKey();

            PromedioDeSeis();
            Console.ReadKey();

            PromedioGeneral();
            Console.ReadKey();
        }

        public static void MostrarAlumnos()
        {
            int contador = 1;

            // Se imprimen los datos de cada alumno
            Console.WriteLine("Información de los Alumnos:");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine("Alumno {0}", contador++);
                Console.WriteLine($"Nombre completo: {alumno.nombreAlumno} {alumno.apellidoAlumno}");
                Console.WriteLine($"Número de identificación: {alumno.numeroId}");
                Console.WriteLine($"Carrera: {alumno.carreraAlumno}");
                Console.WriteLine($"Promedio de notas: {alumno.NotasPromedio()}");
                Console.WriteLine();
            }
        }
        public static void PromedioDeSeis()
        {
            // Se imprimen los alumnos con promedio mayor o igual a 6
            Console.WriteLine("Alumnos con promedio mayor o igual a 6:");
            foreach (var alumno in listaAlumnos)
            {
                if (alumno.NotasPromedio() >= 6)
                {
                    Console.WriteLine($"Nombre completo: {alumno.nombreAlumno} {alumno.apellidoAlumno}");
                    Console.WriteLine($"Número de identificación: {alumno.numeroId}");
                    Console.WriteLine();
                }
            }
        }

        public static void PromedioGeneral()
        {
            // Se calcula el promedio general de todos los alumnos
            double suma = 0;
            foreach (var alumno in listaAlumnos)
            {
                suma += alumno.NotasPromedio();
            }
            double promedio = suma / listaAlumnos.Count;
            Console.WriteLine("Promedio general de todos los alumnos: " + promedio);
        }
    }
}