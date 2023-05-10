namespace Seccion5_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un carácter: ");
            char caracter = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");

            if (EsNumero(caracter))
            {
                Console.WriteLine("El carácter ingresado es un número.");
            }
            else if (EsVocal(caracter))
            {
                Console.WriteLine("El carácter ingresado es una vocal.");
            }
            else if (EsConsonante(caracter))
            {
                Console.WriteLine("El carácter ingresado es una consonante.");
            }
            else
            {
                Console.WriteLine("El carácter ingresado no es ni un número, ni una vocal, ni una consonante.");
            }

            Console.ReadLine();
        }

        static bool EsNumero(char caracter)
        {
            return Char.IsDigit(caracter);
        }

        static bool EsVocal(char caracter)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            return Array.Exists(vocales, vocal => vocal == Char.ToLower(caracter));
        }

        static bool EsConsonante(char caracter)
        {
            char[] consonantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'ñ', 
                'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            return Array.Exists(consonantes, consonante => consonante == Char.ToLower(caracter));
        }
    }
}