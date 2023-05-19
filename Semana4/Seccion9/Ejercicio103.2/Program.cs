using System.Security.Cryptography.X509Certificates;

namespace Seccion9_Ejercicio2
{
    internal class Program
    {
        public static List<Persona> personas = new List<Persona>();
        static void Main(string[] args)
        {
            int contador = 1;

            // Se ingresan 5 personas
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nPersona {0}: ", contador++);
                Console.Write("Ingresa el nombre de la persona: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingresa la edad de la persona: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa si es Alumno(a) o Profesor(a): ");
                string tipo = Console.ReadLine();

                if (tipo.ToLower() == "alumno" || tipo.ToLower() == "alumna")
                {
                    Console.Write("Ingresa la matricula del alumno(a): ");
                    int matricula = Convert.ToInt32(Console.ReadLine());
                    personas.Add(new Alumno { Nombre = nombre, Edad = edad, Matricula = matricula });
                }
                else if (tipo.ToLower() == "profesor" || tipo.ToLower() == "profesora")
                {
                    Console.Write("Ingresa la materia del profesor: ");
                    string materia = Console.ReadLine();
                    personas.Add(new Profesor { Nombre = nombre, Edad = edad, Materia = materia });
                }   
            }

            MayorEdad();
            Console.ReadKey();
        }

        public static void MayorEdad()
        {
            // Se imprimen las personas mayores de 18 años
            Console.WriteLine("\nPersonas mayores de Edad: ");
            foreach (Persona persona in personas)
            {
                if (persona.Edad >= 18)
                {
                    Console.WriteLine(persona.Nombre);
                }
            }
        }
    }
}