using System.Collections;

namespace Seccion7_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();

            // Recorrer el bucle for del 1 al 1000 e insertar en el ArrayList
            for (int i = 1; i <= 1000; i++)
            {
                numeros.Add(i);
            }

            int suma = 0;

            // Recorrer el ArrayList y calcular la suma de los numeros
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
                suma += numero;
            }

            // Mostrar la suma en la consola
            Console.WriteLine("La suma de los números del 1 al 1000 es: " + suma);

            Console.ReadKey();
        }
    }
}