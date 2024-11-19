namespace SistemaMedico.Context
{
    using Microsoft.EntityFrameworkCore;
    using SistemaMedico.Models;

    public class ApplicationDbContext : DbContext
    {
        // Constructor que acepta opciones de configuración
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets para las entidades
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<EvolucionMedica> EvolucionesMedicas { get; set; }
        public DbSet<RecetaDigital> RecetasDigitales { get; set; }
        public DbSet<Plantilla> Plantillas { get; set; }

        // Configuración de las relaciones entre entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de las entidades y relaciones
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Medicos)
                .WithOne(m => m.Usuario)
                .HasForeignKey(m => m.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Recepcionistas)
                .WithOne(r => r.Usuario)
                .HasForeignKey(r => r.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.HistoriaClinica)
                .WithOne(h => h.Paciente)
                .HasForeignKey<HistoriaClinica>(h => h.PacienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HistoriaClinica>()
                .HasMany(h => h.EvolucionesMedicas)
                .WithOne(e => e.HistoriaClinica)
                .HasForeignKey(e => e.HistoriaClinicaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HistoriaClinica>()
                .HasMany(h => h.RecetasDigitales)
                .WithOne(r => r.HistoriaClinica)
                .HasForeignKey(r => r.HistoriaClinicaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HistoriaClinica>()
                .HasMany(h => h.Plantillas)
                .WithOne(p => p.HistoriaClinica)
                .HasForeignKey(p => p.HistoriaClinicaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Diagnostico>()
                .HasMany(d => d.EvolucionesMedicas)
                .WithOne(e => e.Diagnostico)
                .HasForeignKey(e => e.DiagnosticoId);

            modelBuilder.Entity<Diagnostico>()
                .HasMany(d => d.RecetasDigitales)
                .WithOne(r => r.Diagnostico)
                .HasForeignKey(r => r.DiagnosticoId);

            modelBuilder.Entity<Diagnostico>()
                .HasMany(d => d.Plantillas)
                .WithOne(p => p.Diagnostico)
                .HasForeignKey(p => p.DiagnosticoId);

            modelBuilder.Entity<Medico>()
                .HasMany(m => m.EvolucionesMedicas)
                .WithOne(e => e.Medico)
                .HasForeignKey(e => e.MedicoId);

            modelBuilder.Entity<Medico>()
                .HasMany(m => m.RecetasDigitales)
                .WithOne(r => r.Medico)
                .HasForeignKey(r => r.MedicoId);

            modelBuilder.Entity<Medico>()
                .HasMany(m => m.Plantillas)
                .WithOne(p => p.Medico)
                .HasForeignKey(p => p.MedicoId);
        }
    }

}
