using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana5
{
    [Serializable]
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int PuntosVida { get; set; }
        public int NumeroReinicios { get; set; }

        public void GuardarDatos(string rutaArchivo)
        {
            try
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Create))
                {
                    bFormatter.Serialize(fileStream, this);
                    Console.WriteLine("Los datos se han guardado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar los datos del jugador.");
                RegistrarErrores(ex);
            }
        }

        public static Jugador CargarDatos(string rutaArchivo)
        {
            try
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Open))
                {
                    Jugador jugador = (Jugador)bFormatter.Deserialize(fileStream);
                    Console.WriteLine("Los datos se han cargado exitosamente.");
                    return jugador;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los datos del jugador.");
                RegistrarErrores(ex);
                return null;
            }
        }

        private static void RegistrarErrores(Exception ex)
        {
            string mensajeError = $"[{DateTime.Now}] Error: {ex.Message}";
            File.AppendAllText("ErroresJugador/registro_errores.txt", mensajeError + Environment.NewLine);
        }
    }
}
