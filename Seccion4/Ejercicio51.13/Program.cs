namespace Seccion4_Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool numeroPrimo = true; //se estable la variable como "true"
            for (int i = 2; i < numero; i++) //se evalua un ciclo
            {
                if (numero % 2 == 0)
                {
                    numeroPrimo = false; //si cumple la condicion pasa a tener el valor "false"
                    break; //entonces termina la condicion
                }
            }
            if (numeroPrimo) //se valida y se imprime mediante la condicion anterior
            {
                Console.WriteLine("El numero ingresado es primo");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es primo");
            }

            Console.ReadKey();
        }
    }
}