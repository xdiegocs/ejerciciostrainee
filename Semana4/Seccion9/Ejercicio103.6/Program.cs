namespace Seccion9_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.TipoAnimal = "Lobo";
            animal.ColorPelo = "Gris";
            animal.EsDomestico = false;
            animal.NumeroPatas = 4;

            Console.WriteLine("Tipo de Animal: " + animal.TipoAnimal);
            Console.WriteLine("Color de Pelo: " +  animal.ColorPelo);
            Console.WriteLine("¿Es Dómestico?: " + animal.EsDomestico);
            Console.WriteLine("Número de Patas: " + animal.NumeroPatas);
            
        }
    }
}