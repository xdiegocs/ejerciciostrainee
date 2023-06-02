namespace Ejercicio_Semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a un emocionante e intrigante juego de aventuras!");

            Console.Write("Ingrese el nombre del jugador: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el nivel del jugador: ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los puntos de vida del jugador: ");
            int puntosVida = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de reinicios del jugador: ");
            int numeroReinicios = int.Parse(Console.ReadLine());

            Jugador jugador = new Jugador
            {
                Nombre = nombre,
                Nivel = nivel,
                PuntosVida = puntosVida,
                NumeroReinicios = numeroReinicios
            };

            Console.Write("Desea guardar los datos del jugador (S/N): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "S")
            {
                string rutaArchivo = "DatosJugador/datosjugador.bin";

                jugador.GuardarDatos(rutaArchivo);
            }

            Console.Write("Desea cargar los datos del jugador (S/N): ");
            respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "S")
            {
                string rutaArchivo = "DatosJugador/datosjugador.bin";

                Jugador cargarJugador = Jugador.CargarDatos(rutaArchivo);

                if (cargarJugador != null)
                {
                    Console.WriteLine($"Nombre: {cargarJugador.Nombre}");
                    Console.WriteLine($"Nivel: {cargarJugador.Nivel}");
                    Console.WriteLine($"Puntos de Vida: {cargarJugador.PuntosVida}");
                    Console.WriteLine($"Número de Reinicios: {cargarJugador.NumeroReinicios}");
                }
            }

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }
    }
}