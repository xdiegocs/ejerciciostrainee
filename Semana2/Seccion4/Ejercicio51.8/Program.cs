namespace Seccion4_Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                //en cada iteracion se verifica si "i" es par o divisible entre 3
                //por eso se utiliza el operador "OR = ||"
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}