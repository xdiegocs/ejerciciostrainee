namespace Seccion13_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = "personas.txt";
            bool insertarMasPersonas = true;

            while (insertarMasPersonas)
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona:");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la localidad de la persona:");
                string localidad = Console.ReadLine();

                Persona persona = new Persona
                {
                    Nombre = nombre,
                    Edad = edad,
                    Localidad = localidad
                };

                persona.Guardar(rutaArchivo);

                Console.WriteLine("¿Desea insertar más personas? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();
                insertarMasPersonas = respuesta == "S";
            }

            Console.WriteLine("Personas registradas:");
            Persona personaCargada = new Persona();
            personaCargada.Cargar(rutaArchivo);

            Console.ReadKey();
        }
    }
}