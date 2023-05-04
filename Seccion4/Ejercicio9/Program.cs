namespace Seccion4_Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se declara el array
            int[] numerosPares = new int[50];
            int index = 0;

            //por medio del bucle se insertan los numeros pares
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numerosPares[index] = i;
                    index++;
                }
            }

            Console.WriteLine("Numero pares del 1 al 100");

            //posteriormente se imprimen mediante foreach accediendo a cada numero
            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}