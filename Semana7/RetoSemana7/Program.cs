using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_Semana7
{
    public class Program
    {
        private static IJokeService _jokeService = new JokeService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Obtener un chiste random");
                Console.WriteLine("2. Buscar un chiste por palabra clave");
                Console.WriteLine("3. Salir del programa");
                Console.Write("Ingresa la opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ObtenerChisteAleatorio();
                        break;
                    case "2":
                        BuscarPorPalabraClave();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida. Prueba de nuevo.");
                        break;
                }
            }
        }

        private static void ObtenerChisteAleatorio()
        {
            var chiste = _jokeService.ObtenerChisteAleatorio();
            if (chiste != null)
            {
                _jokeService.GuardarAtributos(chiste);
                Console.WriteLine($"Chiste: {chiste.Value}");
            }
        }

        private static void BuscarPorPalabraClave()
        {
            Console.Write("Ingresa la palabra clave: ");
            string palabraClave = Console.ReadLine();
            var chistes = _jokeService.BuscarPorPalabraClave(palabraClave);
            if (chistes.Any())
            {
                Console.WriteLine($"Se encontraron {chistes.Count} chistes que coinciden con la palabra clave '{palabraClave}':");
                foreach (var chiste in chistes)
                {
                    Console.WriteLine($"- {chiste.Value}");
                }
            }
            else
            {
                Console.WriteLine("No hay coincidencias.");
            }
        }
    }

}