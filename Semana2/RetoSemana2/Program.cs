namespace Ejercicio_Semana2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena para verificar si es un palindromo: ");
            string input = Console.ReadLine();

            // Eliminar los espacios en blanco de la cadena
            string stringWithoutSpaces = input.Replace(" ", "");

            bool esPalindromo = true;
            int n = stringWithoutSpaces.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (stringWithoutSpaces[i] != stringWithoutSpaces[n - i - 1])
                {
                    esPalindromo = false;
                    break;
                }
            }

            if (esPalindromo)
            {
                Console.WriteLine("La cadena ingresada es un palindromo.");
            }
            else
            {
                Console.WriteLine("La cadena ingresada no es un palindromo.");
            }

            Console.ReadKey();
        }
    }
}