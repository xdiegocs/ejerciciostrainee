namespace Seccion5_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            int numeroMasAlto;
            int numeroMasBajo;
            int diferencia;

            Console.WriteLine("--Para finalizar debes ingresar el numero 0--");

            ObtenerEstadisticas(out cantidadNumeros, out numeroMasAlto, out numeroMasBajo, out diferencia);

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Cantidad de numeros introducidos: {cantidadNumeros}");
            Console.WriteLine($"Numero mas alto: {numeroMasAlto}");
            Console.WriteLine($"Numero mas bajo: {numeroMasBajo}");
            Console.WriteLine($"Diferencia entre el numero mayor y el numero menor: {diferencia}");

            Console.ReadLine();
        }

        static void ObtenerEstadisticas(out int cantidadNumeros, out int numeroMasAlto, out int numeroMasBajo, out int diferencia)
        {
            cantidadNumeros = 0;
            numeroMasAlto = int.MinValue;
            numeroMasBajo = int.MaxValue;

            while (true)
            {
                Console.Write("Ingrese un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                    break;

                cantidadNumeros++;

                if (numero > numeroMasAlto)
                    numeroMasAlto = numero;

                if (numero < numeroMasBajo)
                    numeroMasBajo = numero;
            }

            diferencia = numeroMasAlto - numeroMasBajo;
        }

    }
}