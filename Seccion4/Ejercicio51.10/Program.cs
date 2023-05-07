namespace Seccion4_Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se crea un array capaz de almacenar 10 numeros enteros
            int[] numeros = new int[10];
            int sumaPares = 0;
            int restaImpares = 0;

            Console.WriteLine("Ingresa 10 numeros: ");

            //se crea un bucle para ingresar los 10 numeros
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            //se buscara cada numero y comparara si es par o impar y realiza su respectiva operacion
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    restaImpares -= numero;
                }
            }

            //posteriormente se imprimen sus resultados
            Console.WriteLine("Suma de los numeros pares: {0}", sumaPares);
            Console.WriteLine("Resta de los numeros impares: {0}", restaImpares);
        }
    }
}