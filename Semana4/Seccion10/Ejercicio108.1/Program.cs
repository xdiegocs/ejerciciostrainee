namespace Seccion10_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Andar();

            if (animal.EsPerro())
            {
                Console.WriteLine("El animal es un perro");
            }
            else
            {
                Console.WriteLine("El animal no es un perro");
            }

            animal.Saltar();
            Console.ReadKey();
        }
    }
}