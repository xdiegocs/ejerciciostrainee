using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion27_Ejercicio2
{
    public class MenuPrincipal
    {
        private readonly Agenda _agenda;

        public MenuPrincipal()
        {
            _agenda = new Agenda();
        }

        public void MostrarMenu()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine();
                Console.WriteLine("1. Añadir cita");
                Console.WriteLine("2. Añadir contacto");
                Console.WriteLine("3. Consultar cita");
                Console.WriteLine("4. Buscar contacto");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        _agenda.AgregarCita();
                        break;
                    case 2:
                        _agenda.AgregarContacto();
                        break;
                    case 3:
                        MostrarMenuConsultarCita();
                        break;
                    case 4:
                        _agenda.BuscarContacto();
                        break;
                    case 0:
                        salir = ConfirmarSalida();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Intentalo de nuevo.");
                        break;
                }
            }
        }

        public void MostrarMenuConsultarCita()
        {
            bool volver = false;

            while (!volver)
            {
                Console.WriteLine();
                Console.WriteLine("Consultar cita");
                Console.WriteLine("1. Consultar por fecha");
                Console.WriteLine("2. Consultar por contacto");
                Console.WriteLine("0. Volver");
                Console.Write("Selecciona una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        _agenda.ConsultarCitaPorFecha();
                        break;
                    case 2:
                        _agenda.ConsultarCitaPorContacto();
                        break;
                    case 0:
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Intentalo de nuevo.");
                        break;
                }
            }
        }

        public bool ConfirmarSalida()
        {
            Console.Write("¿Estas seguro de que quieres salir? (S/N): ");
            string confirmacion = Console.ReadLine();

            return confirmacion.ToUpper() == "S";
        }
    }
}
