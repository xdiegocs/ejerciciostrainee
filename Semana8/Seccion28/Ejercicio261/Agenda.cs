using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion27_Ejercicio1
{
    public class Agenda : IAgenda
    {
        private List<Cita> _citas;
        private List<Contacto> _contactos;

        private const string agendaPath = "agenda.txt";
        private const string contactosPath = "contactos.txt";

        public Agenda()
        {
            _citas = new List<Cita>();
            _contactos = new List<Contacto>();
        }

        public void AgregarCita()
        {
            Console.WriteLine("Ingresa la fecha para la cita (dd/mm/yyyy):");
            String fecha = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduce la descripcion de la cita:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Introduce el nombre del contacto:");
            string nombreContacto = Console.ReadLine();

            List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombreContacto);
            if (contactosEncontrados.Count == 0)
            {
                Console.WriteLine("No se encontro ningun contacto con ese nombre. Primero añade el contacto.");
                AgregarContacto();
                return;
            }

            Console.WriteLine("Contactos encontrados:");
            MostrarContactos(contactosEncontrados);

            Console.WriteLine("Introduce el numero del contacto:");
            int numeroContacto = int.Parse(Console.ReadLine());

            if (numeroContacto < 1 || numeroContacto > contactosEncontrados.Count)
            {
                Console.WriteLine("Numero de contacto invalido.");
                return;
            }

            Contacto contactoSeleccionado = contactosEncontrados[numeroContacto - 1];

            Console.WriteLine("Informacion de la cita:");
            Console.WriteLine($"Fecha: {fecha}");
            Console.WriteLine($"Descripcion: {descripcion}");
            Console.WriteLine($"Contacto: {contactoSeleccionado.Nombre} {contactoSeleccionado.Apellidos}");

            Console.WriteLine("¿Deseas guardar la cita? (S/N)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "S")
            {
                Cita cita = new Cita
                {
                    Fecha = fecha,
                    Descripcion = descripcion,
                    ContactoId = contactoSeleccionado.Id
                };

                _citas.Add(cita);
                GuardarCitaEnArchivo(cita);
                Console.WriteLine("Cita guardada correctamente.");
            }
        }

        public void AgregarContacto()
        {
            Console.WriteLine("Introduce el nombre del contacto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce los apellidos del contacto:");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Introduce el número de telefono del contacto:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Introduce la localidad del contacto:");
            string localidad = Console.ReadLine();

            Console.WriteLine("Informacion del contacto:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"Telefono: {telefono}");
            Console.WriteLine($"Localidad: {localidad}");

            Console.WriteLine("¿Deseas guardar el contacto? (S/N)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "S")
            {
                int nuevoId = _contactos.Count + 1;

                Contacto contacto = new Contacto
                {
                    Id = nuevoId,
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Telefono = telefono,
                    Localidad = localidad
                };

                _contactos.Add(contacto);
                GuardarContactoEnArchivo(contacto);
                Console.WriteLine("Contacto guardado correctamente.");
            }
        }

        public void ConsultarCita()
        {
            Console.WriteLine("Seleccione el tipo de consulta:");
            Console.WriteLine("1 - Consulta por fecha");
            Console.WriteLine("2 - Consulta por contacto");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa la fecha (dd/mm/yyyy):");
                    String fechaConsulta = Convert.ToString(Console.ReadLine());
                    List<Cita> citasEnFecha = BuscarCitasPorFecha(fechaConsulta);
                    if (citasEnFecha.Count == 0)
                    {
                        Console.WriteLine("No existen citas para esa fecha.");
                    }
                    else
                    {
                        Console.WriteLine("Citas encontradas:");
                        MostrarCitas(citasEnFecha);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingresa el nombre del contacto:");
                    string nombreConsulta = Console.ReadLine();
                    List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombreConsulta);
                    if (contactosEncontrados.Count == 0)
                    {
                        Console.WriteLine("No se encontro ningun contacto con ese nombre.");
                    }
                    else if (contactosEncontrados.Count > 1)
                    {
                        Console.WriteLine("Contactos encontrados:");
                        MostrarContactos(contactosEncontrados);
                        Console.WriteLine("Introduce el numero del contacto:");
                        int numeroContacto = int.Parse(Console.ReadLine());
                        if (numeroContacto < 1 || numeroContacto > contactosEncontrados.Count)
                        {
                            Console.WriteLine("Numero de contacto invalido.");
                        }
                        else
                        {
                            Contacto contactoSeleccionado = contactosEncontrados[numeroContacto - 1];
                            List<Cita> citasDelContacto = BuscarCitasPorContacto(contactoSeleccionado.Id);
                            Console.WriteLine("Citas encontradas:");
                            MostrarCitas(citasDelContacto);
                        }
                    }
                    else
                    {
                        Contacto contactoSeleccionado = contactosEncontrados[0];
                        List<Cita> citasDelContacto = BuscarCitasPorContacto(contactoSeleccionado.Id);
                        Console.WriteLine("Citas encontradas:");
                        MostrarCitas(citasDelContacto);
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        public void BuscarContacto()
        {
            Console.WriteLine("Introduce el nombre del contacto:");
            string nombreBusqueda = Console.ReadLine();

            List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombreBusqueda);
            if (contactosEncontrados.Count == 0)
            {
                Console.WriteLine("No se encontro ningún contacto con ese nombre.");
            }
            else
            {
                Console.WriteLine("Contactos encontrados:");
                MostrarContactos(contactosEncontrados);
            }
        }

        private void GuardarCitaEnArchivo(Cita cita)
        {
            using (StreamWriter sw = File.AppendText(agendaPath))
            {
                sw.WriteLine($"{cita.Fecha};{cita.Descripcion};{cita.ContactoId}");
            }
        }

        private void GuardarContactoEnArchivo(Contacto contacto)
        {
            using (StreamWriter sw = File.AppendText(contactosPath))
            {
                sw.WriteLine($"{contacto.Id};{contacto.Nombre};{contacto.Apellidos};{contacto.Telefono};{contacto.Localidad}");
            }
        }

        private List<Contacto> BuscarContactoPorNombre(string nombre)
        {
            List<Contacto> contactosEncontrados = new List<Contacto>();

            using (StreamReader sr = new StreamReader(contactosPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');
                    string nombreCompleto = $"{datos[1]} {datos[2]}";
                    if (nombreCompleto.ToLower().Contains(nombre.ToLower()))
                    {
                        Contacto contacto = new Contacto
                        {
                            Id = int.Parse(datos[0]),
                            Nombre = datos[1],
                            Apellidos = datos[2],
                            Telefono = datos[3],
                            Localidad = datos[4]
                        };
                        contactosEncontrados.Add(contacto);
                    }
                }
            }

            return contactosEncontrados;
        }

        private List<Cita> BuscarCitasPorFecha(String fecha)
        {
            List<Cita> citasEncontradas = new List<Cita>();

            using (StreamReader sr = new StreamReader(agendaPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');
                    String fechaCita = (datos[0]);
                    if (fechaCita == fecha)
                    {
                        Cita cita = new Cita
                        {
                            Fecha = Convert.ToString(fechaCita[0]),
                            Descripcion = datos[1],
                            ContactoId = int.Parse(datos[2])
                        };
                        citasEncontradas.Add(cita);
                    }
                }
            }

            return citasEncontradas;
        }

        private List<Cita> BuscarCitasPorContacto(int contactoId)
        {
            List<Cita> citasEncontradas = new List<Cita>();

            using (StreamReader sr = new StreamReader(agendaPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');
                    int id = int.Parse(datos[2]);
                    if (id == contactoId)
                    {
                        Cita cita = new Cita
                        {
                            Fecha = datos[0],
                            Descripcion = datos[1],
                            ContactoId = id
                        };
                        citasEncontradas.Add(cita);
                    }
                }
            }

            return citasEncontradas;
        }

        private void MostrarCitas(List<Cita> citas)
        {
            if (citas == null || citas.Count == 0)
            {
                Console.WriteLine("No hay citas para mostrar.");
                return;
            }

            foreach (Cita cita in citas)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Fecha: {cita.Fecha}");
                Console.WriteLine($"Descripcion: {cita.Descripcion}");
                Contacto contacto = _contactos.Find(c => c.Id == cita.ContactoId);
                if (contacto != null)
                {
                    Console.WriteLine($"Contacto: {contacto.Nombre} {contacto.Apellidos}");
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado.");
                }
            }
            Console.WriteLine("-----------------------------");
        }

        private void MostrarContactos(List<Contacto> contactos)
        {
            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Id: {contacto.Id}");
                Console.WriteLine($"Nombre: {contacto.Nombre} {contacto.Apellidos}");
                Console.WriteLine($"Telefono: {contacto.Telefono}");
                Console.WriteLine($"Localidad: {contacto.Localidad}");
            }
            Console.WriteLine("-----------------------------");
        }

    }
}
