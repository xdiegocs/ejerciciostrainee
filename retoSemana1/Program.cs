namespace Ejercicio_Semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Ingresa un numero: "); //el usuario ingresara un numero
            int number = int.Parse(Console.ReadLine()); //aqui se almacena el numero

            //numero mayor a 100
            if (number > 100) //se valida si el numero es mayor a 100 mediante el operador
            {
                Console.WriteLine("El numero ingresado es mayor a 100");
            }
            else
            {
                Console.WriteLine("El numero ingresado es menor o igual a 100");
            }

            //numero par/impar
            if (number % 2 == 0) //si el numero mediante el resto con el 2 es igual a cero entonces es par 
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
            {
                Console.WriteLine("El numero ingresado es impar");
            }

            //FOR
            //numero primo
            bool numeroPrimo = true; //se estable la variable como "true"
            for (int i = 2; i < number; i++) //se evalua un ciclo
            {
                if (number % i == 0)
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
            
        }
    }
}