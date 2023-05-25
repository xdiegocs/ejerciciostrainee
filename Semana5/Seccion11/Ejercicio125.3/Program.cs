namespace Seccion11_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (Enum.IsDefined(typeof(Animales), numero))
            {
                animal.Tipo = (Animales)numero;
                Console.WriteLine("Ese valor pertenece al animal: " + animal.Tipo.ToString());
            }
            else
            {
                Console.WriteLine("Lo siento. Ese valor no pertenece a ningún Animal.");
            }

            Console.ReadKey();
        }
    }
}