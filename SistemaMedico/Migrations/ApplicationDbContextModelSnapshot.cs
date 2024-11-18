﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaMedico.Context;

#nullable disable

namespace SistemaMedico.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaMedico.Models.Diagnostico", b =>
                {
                    b.Property<int>("DiagnosticoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosticoId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnosticoId");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("SistemaMedico.Models.EvolucionMedica", b =>
                {
                    b.Property<int>("EvolucionMedicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvolucionMedicaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiagnosticoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.HasKey("EvolucionMedicaId");

                    b.HasIndex("DiagnosticoId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("MedicoId");

                    b.ToTable("EvolucionesMedicas");
                });

            modelBuilder.Entity("SistemaMedico.Models.HistoriaClinica", b =>
                {
                    b.Property<int>("HistoriaClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoriaClinicaId"));

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("HistoriaClinicaId");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("SistemaMedico.Models.Medico", b =>
                {
                    b.Property<int>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicoId"));

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("MedicoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("SistemaMedico.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacienteId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("SistemaMedico.Models.Plantilla", b =>
                {
                    b.Property<int>("PlantillaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlantillaId"));

                    b.Property<string>("Detalles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiagnosticoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.HasKey("PlantillaId");

                    b.HasIndex("DiagnosticoId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Plantillas");
                });

            modelBuilder.Entity("SistemaMedico.Models.Recepcionista", b =>
                {
                    b.Property<int>("RecepcionistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecepcionistaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("RecepcionistaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recepcionistas");
                });

            modelBuilder.Entity("SistemaMedico.Models.RecetaDigital", b =>
                {
                    b.Property<int>("RecetaDigitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecetaDigitalId"));

                    b.Property<int>("DiagnosticoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("Medicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.HasKey("RecetaDigitalId");

                    b.HasIndex("DiagnosticoId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("MedicoId");

                    b.ToTable("RecetasDigitales");
                });

            modelBuilder.Entity("SistemaMedico.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaMedico.Models.EvolucionMedica", b =>
                {
                    b.HasOne("SistemaMedico.Models.Diagnostico", "Diagnostico")
                        .WithMany("EvolucionesMedicas")
                        .HasForeignKey("DiagnosticoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaMedico.Models.HistoriaClinica", "HistoriaClinica")
                        .WithMany("EvolucionesMedicas")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaMedico.Models.Medico", "Medico")
                        .WithMany("EvolucionesMedicas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("HistoriaClinica");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("SistemaMedico.Models.HistoriaClinica", b =>
                {
                    b.HasOne("SistemaMedico.Models.Paciente", "Paciente")
                        .WithOne("HistoriaClinica")
                        .HasForeignKey("SistemaMedico.Models.HistoriaClinica", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SistemaMedico.Models.Medico", b =>
                {
                    b.HasOne("SistemaMedico.Models.Usuario", "Usuario")
                        .WithMany("Medicos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaMedico.Models.Plantilla", b =>
                {
                    b.HasOne("SistemaMedico.Models.Diagnostico", "Diagnostico")
                        .WithMany("Plantillas")
                        .HasForeignKey("DiagnosticoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaMedico.Models.HistoriaClinica", "HistoriaClinica")
                        .WithMany("Plantillas")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaMedico.Models.Medico", "Medico")
                        .WithMany("Plantillas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("HistoriaClinica");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("SistemaMedico.Models.Recepcionista", b =>
                {
                    b.HasOne("SistemaMedico.Models.Usuario", "Usuario")
                        .WithMany("Recepcionistas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaMedico.Models.RecetaDigital", b =>
                {
                    b.HasOne("SistemaMedico.Models.Diagnostico", "Diagnostico")
                        .WithMany("RecetasDigitales")
                        .HasForeignKey("DiagnosticoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaMedico.Models.HistoriaClinica", "HistoriaClinica")
                        .WithMany("RecetasDigitales")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaMedico.Models.Medico", "Medico")
                        .WithMany("RecetasDigitales")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("HistoriaClinica");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("SistemaMedico.Models.Diagnostico", b =>
                {
                    b.Navigation("EvolucionesMedicas");

                    b.Navigation("Plantillas");

                    b.Navigation("RecetasDigitales");
                });

            modelBuilder.Entity("SistemaMedico.Models.HistoriaClinica", b =>
                {
                    b.Navigation("EvolucionesMedicas");

                    b.Navigation("Plantillas");

                    b.Navigation("RecetasDigitales");
                });

            modelBuilder.Entity("SistemaMedico.Models.Medico", b =>
                {
                    b.Navigation("EvolucionesMedicas");

                    b.Navigation("Plantillas");

                    b.Navigation("RecetasDigitales");
                });

            modelBuilder.Entity("SistemaMedico.Models.Paciente", b =>
                {
                    b.Navigation("HistoriaClinica")
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaMedico.Models.Usuario", b =>
                {
                    b.Navigation("Medicos");

                    b.Navigation("Recepcionistas");
                });
#pragma warning restore 612, 618
        }
    }
}