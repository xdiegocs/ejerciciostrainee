﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seccion17_Ejercicio1nuevo1.Contexto;

namespace Seccion17_Ejercicio1nuevo1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230608191250_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaseId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("ClaseId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Clase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColegioId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("ColegioId");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Colegio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaseId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("ClaseId");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Alumno", b =>
                {
                    b.HasOne("Seccion17_Ejercicio1nuevo1.Models.Clase", "Clase")
                        .WithMany("Alumnos")
                        .HasForeignKey("ClaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Clase", b =>
                {
                    b.HasOne("Seccion17_Ejercicio1nuevo1.Models.Colegio", "Colegio")
                        .WithMany("Clases")
                        .HasForeignKey("ColegioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seccion17_Ejercicio1nuevo1.Models.Profesor", b =>
                {
                    b.HasOne("Seccion17_Ejercicio1nuevo1.Models.Clase", "Clase")
                        .WithMany("Profesores")
                        .HasForeignKey("ClaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}