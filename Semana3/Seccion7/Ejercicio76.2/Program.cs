namespace Seccion7_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNombres = new List<string>();

            // Se le solicita al usuario que ingrese 5 nombres
            Console.WriteLine("Ingrese 5 nombres:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre {0}: ", i + 1);
                string nombre = Console.ReadLine().ToLower();
                listaNombres.Add(nombre);
            }

            // Se le solicita al usuario que ingrese un nombre para buscar en la lista
            Console.Write("Ingrese un nombre a buscar: ");
            string buscarNombre = Console.ReadLine().ToLower();

            // Se verifica si el nombre está contenido en la lista
            if (listaNombres.Contains(buscarNombre))
            {
                Console.WriteLine($"El nombre {buscarNombre} está contenido en la lista.");
            }
            else
            {
                Console.WriteLine($"El nombre {buscarNombre} no está contenido en la lista.");
            }

            Console.ReadKey();
        }
    }
}