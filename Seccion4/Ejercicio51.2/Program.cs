namespace Seccion4_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            //validacion de la condicion de los numeros anteriormente ingresados
            if (numero1 > numero2)
            {
                Console.WriteLine(" " + numero1 + " es mayor que " + numero2);
            }
            else
            {
                Console.WriteLine(" " + numero2 + " es mayor que " + numero1);
            }
        }
    }
}