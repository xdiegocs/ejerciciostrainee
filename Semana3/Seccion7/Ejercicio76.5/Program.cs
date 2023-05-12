namespace Seccion7_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se pide la cantidad de elementos que tendrá el Array
            Console.Write("Ingrese la cantidad de elementos del array: ");
            int cantidadElementos = Convert.ToInt32(Console.ReadLine());

            // La cantidad de elementos se almacena en el Array
            int[] elementosArray = new int[cantidadElementos];

            // Se solicitan los valores para llenar el array
            Console.WriteLine("Ingrese los valores del array:");

            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.Write("Elemento {0}: ", i);
                elementosArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Se muestra el array antes de insertar el nuevo valor
            Console.WriteLine("Array antes de la inserción:");
            MostrarArray(elementosArray);

            // Se pide un nuevo valor y la posición donde se insertará
            Console.Write("Ingrese el nuevo valor a insertar: ");
            int nuevoValor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la posición donde desea insertarlo (0-{0}): ", cantidadElementos);
            int posicionInsercion = Convert.ToInt32(Console.ReadLine());

            // Validar la posición de inserción
            if (posicionInsercion < 0 || posicionInsercion > cantidadElementos)
            {
                Console.WriteLine("Posición inválida. La inserción no se realizará.");
            }
            else
            {
                // Se crea un nuevo array con espacio para el nuevo valor
                int[] nuevoArray = new int[cantidadElementos + 1];

                // Aquí se copiarán los elementos del array original hasta la posición de inserción
                for (int i = 0; i < posicionInsercion; i++)
                {
                    nuevoArray[i] = elementosArray[i];
                }

                // Se inserta el nuevo valor en la posición de inserción
                nuevoArray[posicionInsercion] = nuevoValor;

                // Se copian los elementos restantes del array original después de la posición de inserción
                for (int i = posicionInsercion + 1; i < nuevoArray.Length; i++)
                {
                    nuevoArray[i] = elementosArray[i - 1];
                }

                // Se reemplaza el array original con el nuevo array
                elementosArray = nuevoArray;

                // Se muestra el array después de la inserción
                Console.WriteLine("Array después de la inserción:");
                MostrarArray(elementosArray);
            }

            Console.ReadKey();
        }

        static void MostrarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i, array[i]);
            }
        }
    }
}