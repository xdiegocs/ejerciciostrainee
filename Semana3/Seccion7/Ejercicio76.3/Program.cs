namespace Seccion7_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();

            // Se le solicita al usuario que ingrese 10 números
            Console.WriteLine("Ingrese 10 números:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                int numero = Convert.ToInt32(Console.ReadLine());
                listaNumeros.Add(numero);
            }

            //  Variables para calcular las sumas de los número pares e impares
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach (int recorrerNumero in listaNumeros)
            {
                if (recorrerNumero % 2 == 0)
                {
                    sumaPares += recorrerNumero;
                }
                else
                {
                    sumaImpares += recorrerNumero;
                }
            }

            // Mostrar la suma de los números pares e impares
            Console.WriteLine("La suma de los números pares es: " + sumaPares);
            Console.WriteLine("La suma de los números impares es: " + sumaImpares);

            Console.ReadKey();
        }
    }
}