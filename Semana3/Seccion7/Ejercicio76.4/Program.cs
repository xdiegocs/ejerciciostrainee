namespace Seccion7_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();

            // Se le solicita al usuario que ingrese 10 números
            Console.WriteLine("Ingrese 10 números enteros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                int numero = Convert.ToInt32(Console.ReadLine());
                listaNumeros.Add(numero);
            }

            //  Variables que se inicializan en 0 para encontrar el número mayor y número menor
            int numeroMayor = listaNumeros[0];
            int numeroMenor = listaNumeros[0];

            foreach (int recorrerNumero in listaNumeros)
            {
                if (recorrerNumero > numeroMayor)
                {
                    numeroMayor = recorrerNumero;
                }

                if (recorrerNumero < numeroMenor)
                {
                    numeroMenor = recorrerNumero;
                }
            }

            // Se imprime el número mayor y número menor
            Console.WriteLine("El número mayor es: " + numeroMayor);
            Console.WriteLine("El número menor es: " + numeroMenor);

            Console.ReadKey();
        }
    }
}