namespace Seccion4_Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se declaran las variables
            int numero;
            int suma = 0;

            do
            {
                Console.Write("Por favor, ingrese un número del 1 al 1000: ");
                numero = Convert.ToInt32(Console.ReadLine());

                //se crea una condicion de que si el numero esta fuera de limite dara error
                if (numero < 1 || numero > 1000)
                {
                    Console.WriteLine("El número ingresado no es válido.");
                }
            } while (numero < 1 || numero > 1000); //al no cumplirse esta condicion simplemente sale

            //mediante este for ingresaremos a cada numero por medio del indice realizando la validacion y suma
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            //ya que puede dar la respuesta con decimales, declaramos la respuesta como double
            double media = (double)suma / numero;

            //se imprimen los resultados
            Console.WriteLine("La suma de los números del 1 al {0} es: {1}", numero, suma);
            Console.WriteLine("La media es: {0}", media);

            Console.ReadKey();
        }
    }
}