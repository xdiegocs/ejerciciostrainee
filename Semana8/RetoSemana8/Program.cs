﻿namespace Ejercicio_Semana8
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = "Server=tcp:masterudemybdg.database.windows.net,1433;Initial Catalog=trainee;Persist Security Info=False;User ID=xdiegocs;Password=8lT!lt1P;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            IControlVuelo flightManager = new ControlVuelo(cadenaConexion);

            while (true)
            {
                Console.WriteLine("1. Cargar datos desde un archivo CSV");
                Console.WriteLine("2. Buscar vuelos por origen");
                Console.WriteLine("3. Buscar vuelos por destino");
                Console.WriteLine("4. Salir");
                Console.WriteLine();

                Console.Write("Selecciona una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        flightManager.CargarDatosDeCSV();
                        break;

                    case 2:
                        Console.Write("Ingresa el origen: ");
                        string origen1 = Console.ReadLine();                      

                        if (true)
                        {                          
                            flightManager.ObtenerDestinoPorOrigen(origen1);
                            Console.WriteLine("Destinos relacionados:");
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron destinos relacionados.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingresa el destino: ");
                        string destino2 = Console.ReadLine();

                        if (true)
                        {
                            flightManager.ObtenerOrigenPorDestino(destino2);
                            Console.WriteLine("Orígenes relacionados:");
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron origenes relacionados.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}