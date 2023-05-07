namespace Seccion4_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir el nombre de la semana al usuario
            Console.WriteLine("Ingrese el nombre de la semana: ");
            string diaSemana = Console.ReadLine().ToLower();

            //se verificara si es fin de semana o no
            if (diaSemana == "sabado" || diaSemana == "domingo")
            {
                Console.WriteLine("Es fin de semana");
            }
            else
            {
                Console.WriteLine("No es fin de semana");
            }
            
        }
    }
}