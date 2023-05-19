namespace Seccion9_Ejercicio1
{
    internal class Program
    {
        static List<Persona> personas = new List<Persona>();
        static void Main(string[] args)
        {
            
            int contador = 1;
            // Se cargan los datos por teclado
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("\nPersona {0}: ", contador++);
                Console.Write("Ingrese el nombre de la persona: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la edad de la persona: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                personas.Add(new Persona { Nombre = nombre, Edad = edad });
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