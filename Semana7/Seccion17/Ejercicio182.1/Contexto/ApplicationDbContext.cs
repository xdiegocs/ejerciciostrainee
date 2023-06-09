using Microsoft.EntityFrameworkCore;
using Seccion17_Ejercicio1nuevo1.Models;

namespace Seccion17_Ejercicio1nuevo1.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Colegio> Colegios { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clase>()
                .HasOne(c => c.Colegio)
                .WithMany(co => co.Clases)
                .HasForeignKey(c => c.ColegioId);

            modelBuilder.Entity<Profesor>()
                .HasOne(p => p.Clase)
                .WithMany(c => c.Profesores)
                .HasForeignKey(p => p.ClaseId);

            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.Clase)
                .WithMany(c => c.Alumnos)
                .HasForeignKey(a => a.ClaseId);
        }
    }
}
