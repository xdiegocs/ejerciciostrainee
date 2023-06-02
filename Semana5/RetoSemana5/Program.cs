namespace Ejercicio_Semana5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a un emocionante e intrigante juego de aventuras!");

            string respuesta;
            Jugador jugador = null;

            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Crear nueva partida");
                Console.WriteLine("2. Cargar partida existente");
                Console.WriteLine("3. Salir");

                Console.Write("Ingrese la opción deseada (1-3): ");
                respuesta = Console.ReadLine();

                switch (respuesta)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del jugador: ");
                        string nombre = Console.ReadLine();

                        int nivel = 1;
                        int puntosVida = 3;
                        int numeroReinicios = 0;

                        string nombreArchivo = nombre;
                        string rutaArchivo = $"{nombreArchivo}.bin";

                        jugador = new Jugador
                        {
                            Nombre = nombre,
                            Nivel = nivel,
                            PuntosVida = puntosVida,
                            NumeroReinicios = numeroReinicios
                        };

                        Console.Write("Desea guardar los datos del jugador (S/N): ");
                        respuesta = Console.ReadLine();

                        if (respuesta.ToUpper() == "S")
                        {
                            jugador.GuardarDatos(rutaArchivo);
                            Console.WriteLine("Datos del jugador guardados exitosamente.");
                        }

                        break;

                    case "2":
                        Console.Write("Ingrese el nombre del jugador para cargar los datos: ");
                        string nombreArchivoCarga = Console.ReadLine();
                        string rutaArchivoCarga = $"{nombreArchivoCarga}.bin";

                        jugador = Jugador.CargarDatos(rutaArchivoCarga);

                        if (jugador != null)
                        {
                            Console.WriteLine("Datos del jugador cargados exitosamente.");
                            Console.WriteLine($"Nombre del jugador: {jugador.Nombre}");
                            Console.WriteLine($"Nivel: {jugador.Nivel}");
                            Console.WriteLine($"Puntos de Vida: {jugador.PuntosVida}");
                            Console.WriteLine($"Número de Reinicios: {jugador.NumeroReinicios}");
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron datos de jugador.");
                        }

                        break;

                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            } while (respuesta != "3");

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }
    }
}