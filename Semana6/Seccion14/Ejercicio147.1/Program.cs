namespace Seccion14_Ejercicio1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Comenzando la receta...");

            Receta receta = new Receta();
            await receta.HacerTortilla();

            Console.WriteLine("Receta terminada.");
        }
    }
}