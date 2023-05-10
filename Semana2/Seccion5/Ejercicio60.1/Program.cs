namespace Seccion5_Ejercicicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al conversor de moneda!");

            double tipoCambio = PedirTipoCambio();

            Console.WriteLine("1. Convertir de dolares a euros");
            Console.WriteLine("2. Convertir de euros a dolares");
            Console.Write("Ingrese su opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la cantidad en dolares: ");
                    double dolares = Convert.ToDouble(Console.ReadLine());
                    double euros = ConvertirDolaresAEuros(dolares, tipoCambio);
                    Console.WriteLine($"{dolares} dolares son equivalentes a {euros} euros.");
                    break;

                case 2:
                    Console.Write("Ingrese la cantidad en euros: ");
                    double euros2 = Convert.ToDouble(Console.ReadLine());
                    double dolares2 = ConvertirEurosADolares(euros2, tipoCambio);
                    Console.WriteLine($"{euros2} euros son equivalentes a {dolares2} dólares.");
                    break;

                default:
                    Console.WriteLine("Ingresa una opcion valida");
                    break;
            }

            Console.ReadLine();
        }

        static double PedirTipoCambio()
        {
            Console.Write("Ingrese el tipo de cambio del dia: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double ConvertirDolaresAEuros(double dolares, double tipoCambio)
        {
            return dolares * tipoCambio;
        }

        static double ConvertirEurosADolares(double euros, double tipoCambio)
        {
            return euros / tipoCambio;
        }
    }
}