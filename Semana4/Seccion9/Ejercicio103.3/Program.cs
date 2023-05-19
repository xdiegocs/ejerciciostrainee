namespace Seccion9_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Acciones coche
            Coche coche = new Coche();
            coche.Acelerar();
            coche.Frenar();
            coche.Pitar();

            // Acciones avión
            Avion avion = new Avion();
            avion.Acelerar();
            avion.Frenar();
            avion.Aterrizar("japon");

            // Acciones barco
            Barco barco = new Barco();
            barco.Acelerar();
            barco.Frenar();
            barco.EcharAncla();

            Console.ReadKey();
        }
    }
}