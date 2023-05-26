using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion13_Ejercicio1
{
    internal class Persona : IArchivo
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Localidad { get; set; }

        public void Guardar(string ruta)
        {
            string registro = $"{Nombre}|{Edad}|{Localidad};";

            try
            {
                using (FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(registro);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar en el archivo: " + ex.Message);
            }
        }

        public void Cargar(string ruta)
        {
            try
            {
                using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                using (StreamReader sw = new StreamReader(fs))
                {
                    string linea;
                    while ((linea = sw.ReadLine()) != null)
                    {
                        string[] datos = linea.Split('|');
                        if (datos.Length == 3)
                        {
                            Persona persona = new Persona
                            {
                                Nombre = datos[0],
                                Edad = int.Parse(datos[1]),
                                Localidad = datos[2]
                            };
                            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, Localidad: {persona.Localidad}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no existe.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el archivo: " + ex.Message);
            }
        }

    }
}
