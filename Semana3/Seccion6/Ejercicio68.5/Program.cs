namespace Seccion6_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra = 'Z';

            while (letra >= 'A')
            {
                Console.Write(letra + " ");
                letra--;
            }

            Console.ReadKey();
        }
    }
}