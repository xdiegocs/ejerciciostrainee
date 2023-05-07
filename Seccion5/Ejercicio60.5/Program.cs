namespace Seccion5_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            ImprimirTablaMultiplicar(numero);

            Console.ReadLine();
        }

        static void ImprimirTablaMultiplicar(int numero)
        {
            Console.WriteLine($"\nTabla de multiplicar del numero {numero}:\n");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}