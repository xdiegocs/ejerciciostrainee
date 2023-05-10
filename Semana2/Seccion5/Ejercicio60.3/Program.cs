namespace Seccion5_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el importe: ");
            decimal importe = Convert.ToDecimal(Console.ReadLine());

            DesglosarImporte(importe);

            Console.ReadKey();

        }

        static void DesglosarImporte(decimal importe)
        {
            int[] denominacionesBilletes = { 200, 100, 50, 20, 10, 5, 1 };
            decimal[] denominacionesMonedas = { 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };

            Console.WriteLine("Desglose de billetes:");

            foreach (int denominacion in denominacionesBilletes)
            {
                int cantidadBilletes = (int)(importe / denominacion);

                if (cantidadBilletes > 0)
                {
                    Console.WriteLine("{0} billetes de {1}", cantidadBilletes, denominacion);
                    importe %= denominacion;
                }
            }

            Console.WriteLine("Desglose de monedas:");

            foreach (decimal denominacion in denominacionesMonedas)
            {
                int cantidadMonedas = (int)(importe / denominacion);

                if (cantidadMonedas > 0)
                {
                    Console.WriteLine("{0} monedas de {1}", cantidadMonedas, denominacion.ToString("0.00"));
                    importe %= denominacion;
                }
            }
        }

    }
}