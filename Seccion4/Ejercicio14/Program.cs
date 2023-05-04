namespace Seccion4_Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cifras = 0;

            Console.Write("Ingrese un numero entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //se valida por medio del indice del numero
            if (numero == 0)
            {
                cifras = 1;
            }
            else
            {
                //se utiliza el bucle para ir dividiendo el numero entre 10 y aumentar la variable
                while (numero > 0) 
                {
                    cifras++;
                    numero /= 10;
                }
            }

            Console.WriteLine("El numero tiene {0} cifras.", cifras);
        }
    }
}