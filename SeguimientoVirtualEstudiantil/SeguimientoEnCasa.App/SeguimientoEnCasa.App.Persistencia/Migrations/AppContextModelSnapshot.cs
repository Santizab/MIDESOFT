﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeguimientoEnCasa.App.Persistencia;

namespace SeguimientoEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("SugerenciaEstudioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SugerenciaEstudioId");

                    b.ToTable("Historicos");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.SugerenciaEstudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaestroId")
                        .HasColumnType("int");

                    b.Property<int?>("TutorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcudienteId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("MaestroId");

                    b.HasIndex("TutorId");

                    b.ToTable("Sugerencias");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HorasLaborales")
                        .HasColumnType("int");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Acudiente", b =>
                {
                    b.HasBaseType("SeguimientoEnCasa.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Acudiente");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SeguimientoEnCasa.App.Dominio.Persona");

                    b.Property<int?>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.HasIndex("AcudienteId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Maestro", b =>
                {
                    b.HasBaseType("SeguimientoEnCasa.App.Dominio.Persona");

                    b.Property<string>("Asignatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Registro")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("EstudianteId");

                    b.HasDiscriminator().HasValue("Maestro");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Historico", b =>
                {
                    b.HasOne("SeguimientoEnCasa.App.Dominio.SugerenciaEstudio", "SugerenciaEstudio")
                        .WithMany()
                        .HasForeignKey("SugerenciaEstudioId");

                    b.Navigation("SugerenciaEstudio");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.SugerenciaEstudio", b =>
                {
                    b.HasOne("SeguimientoEnCasa.App.Dominio.Acudiente", "Acudiente")
                        .WithMany()
                        .HasForeignKey("AcudienteId");

                    b.HasOne("SeguimientoEnCasa.App.Dominio.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId");

                    b.HasOne("SeguimientoEnCasa.App.Dominio.Maestro", "Maestro")
                        .WithMany()
                        .HasForeignKey("MaestroId");

                    b.HasOne("SeguimientoEnCasa.App.Dominio.Tutor", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");

                    b.Navigation("Acudiente");

                    b.Navigation("Estudiante");

                    b.Navigation("Maestro");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("SeguimientoEnCasa.App.Dominio.Acudiente", "Acudiente")
                        .WithMany()
                        .HasForeignKey("AcudienteId");

                    b.Navigation("Acudiente");
                });

            modelBuilder.Entity("SeguimientoEnCasa.App.Dominio.Maestro", b =>
                {
                    b.HasOne("SeguimientoEnCasa.App.Dominio.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId");

                    b.Navigation("Estudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
