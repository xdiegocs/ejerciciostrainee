namespace Seccion11_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseGenerica<string> claseGenerica = new ClaseGenerica<string>();

            Console.WriteLine("Ingrese los valores ('n' para terminar): ");

            while (true)
            {
                string valor = Console.ReadLine();

                if (valor == "n")
                    break;

                claseGenerica.AgregarElementos(valor);
            }

            claseGenerica.MostrarElementos();

            Console.ReadKey();
        }
    }
}