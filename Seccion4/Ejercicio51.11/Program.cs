namespace Seccion4_Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //el usuario ingresara un numero del 1-7
            Console.WriteLine("Ingresa un numero del 1 al 7: ");
            int diaSemana = Convert.ToInt32(Console.ReadLine());

            //por medio del switch se comparara el numero y dara el resultado
            switch (diaSemana)
            {
                case 1:
                    Console.Write("Lunes");
                    break;
                case 2:
                    Console.Write("Martes");
                    break;
                case 3:
                    Console.Write("Miercoles");
                    break;
                case 4:
                    Console.Write("Jueves");
                    break;
                case 5:
                    Console.Write("Viernes");
                    break;
                case 6:
                    Console.Write("Sabado");
                    break;
                case 7:
                    Console.Write("Domingo");
                    break;
                default:
                    Console.Write("Intenta ingresar un numero valido en el rango establecido");
                    break;
            }

            Console.ReadKey();
        }
    }
}