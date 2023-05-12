namespace Seccion6_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            // Convierte el nombre ingresado a minúsculas
            nombre = nombre.ToLower();

            // Compara el nombre ingresado con el establecido
            if (nombre == "alejandro")
            {
                Console.WriteLine($"Hola, {nombre}!");
            }
            else
            {
                Console.WriteLine("No te conozco.");
            }

            Console.ReadKey();
        }
    }
}