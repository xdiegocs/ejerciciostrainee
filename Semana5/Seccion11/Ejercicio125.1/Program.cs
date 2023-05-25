namespace Seccion11_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            while (true)
            {
                Console.WriteLine("Ingrese un número (0 para salir): ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                    break;

                Console.WriteLine("Ingrese una cadena: ");
                string cadena = Console.ReadLine();

                diccionario[numero] = cadena;
            }

            Console.WriteLine("Ingrese una cadena de 2 letras para buscar: ");
            string cadenaBuscada = Console.ReadLine();

            Console.WriteLine($"Claves que contienen '{cadenaBuscada}' en los valores del diccionario");
            foreach (KeyValuePair<int, string> search in diccionario)
            {
                if (search.Value.Contains(cadenaBuscada))
                {
                    Console.WriteLine(search.Key);
                }
            }

            Console.ReadKey();
        }
    }
}