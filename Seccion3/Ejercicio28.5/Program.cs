namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa un nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("\nAhora ingresa una ciudad:");
            string city = Console.ReadLine();
            Console.Write("\nHola " + name + " bienvenido(a) a " + city);
            Console.ReadKey();
        }
    }
}