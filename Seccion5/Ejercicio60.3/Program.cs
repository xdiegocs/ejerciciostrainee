namespace Seccion5_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el importe: ");
            double importe = Convert.ToDouble(Console.ReadLine());

            DesglosarImporte(importe);

            Console.ReadLine();
        }

        static void DesglosarImporte(double importe)
        {
            int[] denominaciones = { 200, 100, 50, 20, 10, 5, 1 };
            int[] cantidadDenominaciones = new int[denominaciones.Length];

            int importeInt = (int)importe;

            for (int i = 0; i < denominaciones.Length; i++)
            {
                if (importeInt >= denominaciones[i])
                {
                    cantidadDenominaciones[i] = importeInt / denominaciones[i];
                    importeInt %= denominaciones[i];
                }
            }

            Console.WriteLine("Desglose de importe:");

            for (int i = 0; i < denominaciones.Length; i++)
            {
                if (cantidadDenominaciones[i] > 0)
                {
                    if (denominaciones[i] >= 5)
                        Console.WriteLine($"{cantidadDenominaciones[i]} billetes de {denominaciones[i]}");
                    else
                        Console.WriteLine($"{cantidadDenominaciones[i]} monedas de {denominaciones[i]}");
                }
            }
        }
    }
}