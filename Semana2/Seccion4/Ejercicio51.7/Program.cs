namespace Seccion4_Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se usara un bucle for para este ejercicio
            for (int i = 1; i <= 100; i++)
            {
                //se define una condicion donde se usa el resto para encontrar los numeros pares
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}