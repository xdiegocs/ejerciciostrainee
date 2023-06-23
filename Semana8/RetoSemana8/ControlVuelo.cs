using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana8
{
    public class ControlVuelo : IControlVuelo
    {
        private const string _archivoPath = @"Vuelos disponibles.csv";
        private readonly string _connectionString;

        public ControlVuelo(string connectionString)
        {
            _connectionString = connectionString;
        }    

        public void CargarDatosDeCSV()
        {         
            if (!VerificarTablaExiste())
            {
                CrearTabla();
            }
            else
            {
                EliminarTabla();
                CrearTabla();
            }

            List<Vuelo> vuelos = CargarDesdeCSV();

            InsertDataIntoTable(vuelos);
        }

        public void InsertDataIntoTable(List<Vuelo> vuelos)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaccion = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaccion))
                        {
                            bulkCopy.DestinationTableName = "Vuelos";

                            bulkCopy.ColumnMappings.Add("Id", "Id");
                            bulkCopy.ColumnMappings.Add("Origen", "Origen");
                            bulkCopy.ColumnMappings.Add("Destino", "Destino");
                            bulkCopy.ColumnMappings.Add("Fecha", "Fecha");
                            bulkCopy.ColumnMappings.Add("Precio", "Precio");
                            bulkCopy.ColumnMappings.Add("Aeropuerto", "Aeropuerto");

                            DataTable tablaDatos = new DataTable();
                            tablaDatos.Columns.Add("Id", typeof(int));
                            tablaDatos.Columns.Add("Origen", typeof(string));
                            tablaDatos.Columns.Add("Destino", typeof(string));
                            tablaDatos.Columns.Add("Fecha", typeof(string));
                            tablaDatos.Columns.Add("Precio", typeof(string));
                            tablaDatos.Columns.Add("Aeropuerto", typeof(string));

                            foreach (Vuelo vuelo in vuelos)
                            {
                                tablaDatos.Rows.Add(
                                    vuelo.Id,
                                    vuelo.Origen,
                                    vuelo.Destino,
                                    vuelo.Fecha,
                                    vuelo.Precio,
                                    vuelo.Aeropuerto
                                );
                            }

                            bulkCopy.WriteToServer(tablaDatos);
                        }

                        transaccion.Commit();
                        Console.WriteLine("Datos insertados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        Console.WriteLine("Error al insertar los datos: " + ex.Message);
                    }
                }
            }
        }

        public void ObtenerDestinoPorOrigen(string origen)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "SELECT Destino, Precio, Fecha, Aeropuerto FROM Vuelos WHERE Origen = @Origin";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Origin", origen);

            using SqlDataReader reader = command.ExecuteReader();
            {
                Console.WriteLine("Vuelos encontrados con origen '{0}':", origen);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-10}", "Destino", "Precio", "Fecha", "Aeropuerto");
                Console.WriteLine("--------------------------------------------------");

                while (reader.Read())
                {
                    string destino = reader.GetString(0);
                    string precio = reader.GetString(1);
                    string fecha = reader.GetString(2);
                    string aeropuerto = reader.GetString(3);

                    Console.WriteLine("{0,-15} {1,-10:C} {2,-15:d} {3,-10}", destino, precio, fecha, aeropuerto);
                }
            }
        }

        public void ObtenerOrigenPorDestino(string destino)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "SELECT Origen, Precio, Fecha, Aeropuerto FROM Vuelos WHERE Destino = @Destination";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Destination", destino);

            using SqlDataReader reader = command.ExecuteReader();
            {
                Console.WriteLine("Vuelos encontrados con destino '{0}':", destino);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-10}", "Origen", "Precio", "Fecha", "Aeropuerto");
                Console.WriteLine("--------------------------------------------------");

                while (reader.Read())
                {
                    string origen = reader.GetString(0);
                    string precio = reader.GetString(1);
                    string fecha = reader.GetString(2);
                    string aeropuerto = reader.GetString(3);

                    Console.WriteLine("{0,-15} {1,-10:C} {2,-15:d} {3,-10}", origen, precio, fecha, aeropuerto);
                }
            }         
        }

        private bool VerificarTablaExiste()
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Vuelos'";
            using SqlCommand command = new SqlCommand(query, connection);

            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private void CrearTabla()
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "CREATE TABLE Vuelos (" +
                "Id INT NOT NULL, " +
                "Origen VARCHAR(100) NOT NULL, " +
                "Destino VARCHAR(100) NOT NULL, " +
                "Fecha VARCHAR(100) NOT NULL, " +
                "Precio VARCHAR(100) NOT NULL, " +
                "Aeropuerto VARCHAR(100) NOT NULL, " +
                "PRIMARY KEY (Id)" +
                ")";

            using SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("Tabla Vuelos creada correctamente.");
        }

        private void EliminarTabla()
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "DROP TABLE Vuelos";

            using SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("Tabla Vuelos eliminada correctamente.");
        }

        private List<Vuelo> CargarDesdeCSV()
        {
            List<Vuelo> vuelos = new List<Vuelo>();

            string[] lineas = System.IO.File.ReadAllLines(_archivoPath);
            foreach (string linea in lineas[1..])
            {
                string[] values = linea.Split(',');

                if (values.Length >= 6)
                {
                    Vuelo vuelo = new Vuelo
                    {
                        Id = int.Parse(values[0]),
                        Origen = values[1],
                        Destino = values[2],
                        Fecha = values[3],
                        Precio = values[4],
                        Aeropuerto = values[5]
                    };

                    vuelos.Add(vuelo);
                }
                else
                {
                    Console.WriteLine("El CSV no tiene la cantidad de valores esperada.");
                }
            }

            return vuelos;
        }
    }
}
