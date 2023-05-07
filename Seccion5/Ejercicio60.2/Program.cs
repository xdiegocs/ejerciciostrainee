namespace Seccion5_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu de opciones de la calculadora:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione la opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                    break;

                Console.Write("Ingrese el primer numero: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = Suma(num1, num2);
                        break;

                    case 2:
                        resultado = Resta(num1, num2);
                        break;

                    case 3:
                        resultado = Multiplicacion(num1, num2);
                        break;

                    case 4:
                        if (num2 != 0)
                            resultado = Division(num1, num2);
                        else
                            Console.WriteLine("Error: No se puede dividir por cero.");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);
            }

            Console.WriteLine("Gracias por haber usado la calculadora.");
            Console.ReadLine();
        }

        static double Suma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        static double Resta(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        static double Multiplicacion(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        static double Division(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

    }
}