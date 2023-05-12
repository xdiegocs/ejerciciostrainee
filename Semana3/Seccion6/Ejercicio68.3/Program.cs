namespace Seccion6_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase con al menos 20 caracteres y 4 palabras:");
            string frase = Console.ReadLine();

            // Valida la longitud de la cadena y el número de palabras
            if (frase.Length >= 20 && ContarPalabras(frase) >= 4)
            {
                Console.WriteLine("Longitud de la cadena: " + frase.Length);
                // Compara dependiendo si se ingreso la cadena en mayúsculas o minúsculas
                if (frase.ToUpper() == frase)
                {
                    Console.WriteLine("Frase con 'A' reemplazada por 'X': " + ReemplazarLetra(frase, 'A', 'X'));
                }
                else if (frase.ToLower() == frase)
                {
                    Console.WriteLine("Frase con 'a' reemplazada por 'x': " + ReemplazarLetra(frase, 'a', 'x'));
                }
                Console.WriteLine("Cadena en mayúsculas: " + frase.ToUpper());
                Console.WriteLine("Cadena en minúsculas: " + frase.ToLower());
                Console.WriteLine("Cadena sin las 3 primeras letras: " + frase.Substring(3));
                Console.WriteLine("Cadena de la posición 5 a la 10: " + frase.Substring(5, 5));
                Console.WriteLine("Cadena invertida: " + InvertirCadena(frase));
                Console.WriteLine("Número de palabras en la frase: " + ContarPalabras(frase));
                Console.WriteLine("Tercera palabra: " + ObtenerTerceraPalabra(frase));
            }
            else
            {
                Console.WriteLine("La frase debe tener al menos 20 caracteres y 4 palabras.");
            }

            Console.ReadKey();
        }

        static int ContarPalabras(string frase)
        {
            // Remueve los espacios y calcula el tamaño de la cadena
            string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }

        static string ReemplazarLetra(string cadena, char letraAnterior, char letraNueva)
        {
            // Compara la cadena y reemplaza los nuevos valores que se pasan por parametro
            return cadena.Replace(letraAnterior.ToString(), letraNueva.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        static string InvertirCadena(string cadena)
        {
            char[] caracteres = cadena.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }

        static string ObtenerTerceraPalabra(string frase)
        {
            // Elimina los espacios y evalua la cadena para tomar la tercera palabra
            string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (palabras.Length >= 3)
            {
                return palabras[2];
            }
            return string.Empty;
        }
    }
}