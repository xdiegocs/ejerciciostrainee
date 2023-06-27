using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion27_Ejercicio2
{
    public class Agenda
    {
        private readonly AgendaContext _context;

        public Agenda()
        {
            _context = new AgendaContext();
            _context.Database.EnsureCreated();
        }

        public void AgregarCita()
        {
            Console.WriteLine("Añadir cita");
            Console.Write("Fecha (dd/mm/aaaa): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();

            Console.Write("Nombre del contacto: ");
            string nombreContacto = Console.ReadLine();

            var contactos = _context.Contactos.Where(c => c.Nombre.Contains(nombreContacto)).ToList();
            if (contactos.Count == 0)
            {
                Console.WriteLine("No se encontró ningún contacto con ese nombre. Primero añade el contacto.");
                AgregarContacto();
                return;
            }

            Console.WriteLine("Contactos encontrados:");
            for (int i = 0; i < contactos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {contactos[i].Nombre} {contactos[i].Apellidos}");
            }

            Console.Write("Selecciona el número del contacto: ");
            int numeroContacto = int.Parse(Console.ReadLine());
            if (numeroContacto < 1 || numeroContacto > contactos.Count)
            {
                Console.WriteLine("Número de contacto inválido.");
                return;
            }

            var contactoSeleccionado = contactos[numeroContacto - 1];

            var cita = new Cita
            {
                Fecha = fecha,
                Descripcion = descripcion,
                ContactoId = contactoSeleccionado.Id
            };

            _context.Citas.Add(cita);
            _context.SaveChanges();

            Console.WriteLine("Cita guardada correctamente.");
        }

        public void AgregarContacto()
        {
            Console.WriteLine("Añadir contacto");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Localidad: ");
            string localidad = Console.ReadLine();

            var contacto = new Contacto
            {
                Nombre = nombre,
                Apellidos = apellidos,
                Telefono = telefono,
                Localidad = localidad
            };

            _context.Contactos.Add(contacto);
            _context.SaveChanges();

            Console.WriteLine("Contacto guardado correctamente.");
        }

        public void ConsultarCitaPorFecha()
        {
            Console.WriteLine("Consultar cita por fecha");
            Console.Write("Día: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            var fechaConsulta = new DateTime(año, mes, dia);

            var citas = _context.Citas.Where(c => c.Fecha.Date == fechaConsulta.Date).ToList();

            if (citas.Count == 0)
            {
                Console.WriteLine("No hay citas para esa fecha.");
            }
            else
            {
                Console.WriteLine("Citas encontradas:");
                foreach (var cita in citas)
                {
                    Console.WriteLine($"Fecha: {cita.Fecha}, Descripción: {cita.Descripcion}, Contacto: {cita.Contacto.Nombre} {cita.Contacto.Apellidos}");
                }
            }
        }

        public void ConsultarCitaPorContacto()
        {
            Console.WriteLine("Consultar cita por contacto");
            Console.Write("Nombre del contacto: ");
            string nombreContacto = Console.ReadLine();

            var contactos = _context.Contactos.Where(c => c.Nombre.Contains(nombreContacto)).ToList();
            if (contactos.Count == 0)
            {
                Console.WriteLine("No se encontró ningún contacto con ese nombre.");
                return;
            }

            Console.WriteLine("Contactos encontrados:");
            for (int i = 0; i < contactos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {contactos[i].Nombre} {contactos[i].Apellidos}");
            }

            Console.Write("Selecciona el número del contacto: ");
            int numeroContacto = int.Parse(Console.ReadLine());
            if (numeroContacto < 1 || numeroContacto > contactos.Count)
            {
                Console.WriteLine("Número de contacto inválido.");
                return;
            }

            var contactoSeleccionado = contactos[numeroContacto - 1];

            var citas = _context.Citas.Where(c => c.ContactoId == contactoSeleccionado.Id).ToList();

            if (citas.Count == 0)
            {
                Console.WriteLine("No hay citas para ese contacto.");
            }
            else
            {
                Console.WriteLine("Citas encontradas:");
                foreach (var cita in citas)
                {
                    Console.WriteLine($"Fecha: {cita.Fecha}, Descripción: {cita.Descripcion}");
                }
            }
        }

        public void BuscarContacto()
        {
            Console.WriteLine("Buscar contacto");
            Console.Write("Nombre del contacto: ");
            string nombreContacto = Console.ReadLine();

            var contactos = _context.Contactos.Where(c => c.Nombre.Contains(nombreContacto)).ToList();
            if (contactos.Count == 0)
            {
                Console.WriteLine("No se encontró ningún contacto con ese nombre.");
            }
            else
            {
                Console.WriteLine("Contactos encontrados:");
                foreach (var contacto in contactos)
                {
                    Console.WriteLine($"Nombre: {contacto.Nombre}, Apellidos: {contacto.Apellidos}, Teléfono: {contacto.Telefono}, Localidad: {contacto.Localidad}");
                }
            }
        }
    }
}
