using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion27_Ejercicio2
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Cita> Citas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuracion DDBB
            optionsBuilder.UseSqlServer("Server=tcp:server.database.windows.net,1433;Initial Catalog=AgendaDB;Persist Security Info=False;User ID=user;Password=password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }
    }
}
