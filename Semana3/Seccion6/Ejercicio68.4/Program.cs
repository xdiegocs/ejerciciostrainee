using System.Text;

namespace Seccion6_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pide 4 números y los almacena
            Console.WriteLine("Ingrese 4 numeros:");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());
            int numero4 = int.Parse(Console.ReadLine());

            // Los números que se almacenaron ahora se almacenan en el StringBuilder
            StringBuilder frase = new StringBuilder();
            frase.Append("El primer numero introducido es el ");
            frase.Append(numero1);
            frase.Append(", despues han introducido el ");
            frase.Append(numero2);
            frase.Append(" y ");
            frase.Append(numero3);
            frase.Append(" y por ultimo el ");
            frase.Append(numero4);

            Console.WriteLine(frase.ToString());
            Console.ReadKey();
        }
    }
}