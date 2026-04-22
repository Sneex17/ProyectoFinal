using HospitalTurnos.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalTurnos.Data
{
    public class HospitalTurnosContext : DbContext
    {
        public HospitalTurnosContext(DbContextOptions<HospitalTurnosContext> options)
            : base(options) { }

        // ─── DbSets (una propiedad por tabla) ─────────────────────────────
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Prioridad> Prioridades { get; set; }
        public DbSet<EstadoTurno> EstadoTurnos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ── Turnos ────────────────────────────────────────────────────
            modelBuilder.Entity<Turno>(entity =>
            {
                entity.ToTable("Turnos", tb => tb.HasTrigger("SqlTableDependencyTrigger"));
                entity.HasKey(t => t.TurnoId);

                entity.Property(t => t.Observaciones).HasColumnType("nvarchar(max)");
                entity.Property(t => t.FechaHoraCreacion)
                      .HasDefaultValueSql("getdate()");

                // FK → Pacientes
                entity.HasOne(t => t.Paciente)
                      .WithMany()
                      .HasForeignKey(t => t.PacienteId)
                      .OnDelete(DeleteBehavior.Restrict);

                // FK → Medicos
                entity.HasOne(t => t.Medico)
                      .WithMany()
                      .HasForeignKey(t => t.MedicoId)
                      .OnDelete(DeleteBehavior.Restrict);

                // FK → Recepcionistas  (columna en BD: RecepcionistaId)
                entity.HasOne(t => t.Recepcionista)
                      .WithMany()
                      .HasForeignKey(t => t.RecepcionistaId)
                      .OnDelete(DeleteBehavior.Restrict);

                // FK → Prioridades
                entity.HasOne(t => t.Prioridad)
                      .WithMany()
                      .HasForeignKey(t => t.PrioridadId)
                      .OnDelete(DeleteBehavior.Restrict);

                // FK → EstadoTurnos
                entity.HasOne(t => t.EstadoTurno)
                      .WithMany()
                      .HasForeignKey(t => t.EstadoTurnoId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // ── Pacientes ─────────────────────────────────────────────────
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.ToTable("Pacientes");
                entity.HasKey(p => p.PacienteId);
                entity.HasIndex(p => p.Cedula).IsUnique();
                entity.Property(p => p.Sexo)
                      .HasColumnType("char(1)")
                      .IsRequired();
                entity.Property(p => p.FechaNacimiento).HasColumnType("date");
            });

            // ── Medicos ───────────────────────────────────────────────────
            modelBuilder.Entity<Medico>(entity =>
            {
                entity.ToTable("Medicos");
                entity.HasKey(m => m.MedicoId);
                entity.HasIndex(m => m.NLicencia).IsUnique();
                entity.Property(m => m.NLicencia).HasMaxLength(50).IsRequired();
                entity.Property(m => m.Nombre).HasMaxLength(100).IsRequired();
                entity.Property(m => m.Apellido).HasMaxLength(100).IsRequired();
            });

            // ── Recepcionistas ────────────────────────────────────────────
            modelBuilder.Entity<Recepcionista>(entity =>
            {
                entity.ToTable("Recepcionistas");
                entity.HasKey(r => r.RecepcionistaId);
                entity.Property(r => r.Nombre).HasMaxLength(100).IsRequired();
                entity.Property(r => r.Apellido).HasMaxLength(100).IsRequired();
            });

            // ── Prioridades ───────────────────────────────────────────────
            modelBuilder.Entity<Prioridad>(entity =>
            {
                entity.ToTable("Prioridades");
                entity.HasKey(p => p.PrioridadId);
                entity.Property(p => p.Nombre).HasMaxLength(50).IsRequired();
            });

            // ── EstadoTurnos ──────────────────────────────────────────────
            modelBuilder.Entity<EstadoTurno>(entity =>
            {
                entity.ToTable("EstadoTurnos");
                entity.HasKey(e => e.EstadoTurnoId);
                entity.Property(e => e.Nombre).HasMaxLength(50).IsRequired();
            });

            // ── Especialidades ────────────────────────────────────────────
            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("Especialidades");
                entity.HasKey(e => e.EspecialidadId);
                entity.Property(e => e.Nombre).HasMaxLength(100).IsRequired();
            });
        }
    }
}