namespace Seccion6_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pide una palabra por consola
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            // Llama el metodo y pasa la palabra por parametro y la imprime
            string palabraInvertida = InvertirPalabra(palabra);
            Console.WriteLine("Palabra invertida: " + palabraInvertida);

            Console.ReadKey();
        }

        static string InvertirPalabra(string palabra)
        {
            // Guarda la palabra y la invierte con la propiedad que provee el Array
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}