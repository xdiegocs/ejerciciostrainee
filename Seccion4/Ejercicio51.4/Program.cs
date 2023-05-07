namespace Seccion4_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se le pide al usuario que ingrese el precio del producto
            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            //se le pide que ingrese la forma de pago
            Console.WriteLine("Ingrese la forma de pago (efectivo o tarjeta): ");
            string formaPago = Console.ReadLine().ToLower(); //para que sea mas sencilla la comparacion se convierte a minusculas

            //si la forma de pago es tarjeta, pedir el numero de cuenta
            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Ingrese el numero de cuenta: ");
                string numeroCuenta = Console.ReadLine();
                Console.WriteLine("El numero de cuenta ingresado es: " + numeroCuenta);
            }

            //se muestra el precio y la forma de pago mediante la consola
            Console.WriteLine("El precio del producto es: $" + precio);
            Console.WriteLine("La forma de pago es: " + formaPago);
        }
    }
}