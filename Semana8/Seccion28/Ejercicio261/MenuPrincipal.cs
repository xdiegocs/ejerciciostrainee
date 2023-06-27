using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion27_Ejercicio1
{
    public class MenuPrincipal : Agenda
    {
        public void Menu()
        {
            int opcion;
            do
            {
                Console.WriteLine("1 - Añadir cita");
                Console.WriteLine("2 - Añadir contacto");
                Console.WriteLine("3 - Consultar cita");
                Console.WriteLine("4 - Buscar contacto");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Selecciona una opción:");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarCita();
                        break;
                    case 2:
                        AgregarContacto();
                        break;
                    case 3:
                        ConsultarCita();
                        break;
                    case 4:
                        BuscarContacto();
                        break;
                    case 0:
                        Console.WriteLine("¿Estas seguro de que deseas salir? (S/N)");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToUpper() == "S")
                        {
                            Console.WriteLine("Saliendo del programa...");
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                Console.WriteLine("Presiona cualquier tecla para volver al menu principal.");
                Console.ReadKey();
                Console.Clear();

            } while (true);
        }
    }
}
