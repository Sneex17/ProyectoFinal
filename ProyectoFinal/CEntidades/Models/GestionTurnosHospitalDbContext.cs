using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CEntidades.Models;

/// <summary>
/// Representa el contexto de base de datos para la gestión de turnos hospitalarios.
/// Proporciona acceso a las tablas mediante DbSet y gestiona la conexión con la base de datos.
/// </summary>
public partial class GestionTurnosHospitalDbContext : DbContext
{
    /// <summary>
    /// Inicializa una nueva instancia del contexto de base de datos.
    /// </summary>
    public GestionTurnosHospitalDbContext()
    {
        // Constructor vacío para permitir la creación del contexto sin parámetros. 
    }

    public GestionTurnosHospitalDbContext(DbContextOptions<GestionTurnosHospitalDbContext> options)
        : base(options)
    {
        // Constructor que acepta opciones de configuración para la conexión a la base de datos.
    }

    public virtual DbSet<Area> Areas { get; set; }

    // DbSet que representa la tabla de especialidades médicas en la base de datos.

    public virtual DbSet<Especialidade> Especialidades { get; set; }

    // DbSet que representa la tabla de estados de usuario en la base de datos.

    public virtual DbSet<Estado> Estados { get; set; }

    // DbSet que representa la tabla de estados de turno en la base de datos.

    public virtual DbSet<EstadoTurno> EstadoTurnos { get; set; }

    // DbSet que representa la tabla de médicos en la base de datos.
    public virtual DbSet<Medico> Medicos { get; set; }

    // DbSet que representa la tabla de pacientes en la base de datos.  
    public virtual DbSet<Paciente> Pacientes { get; set; }
    
    // DbSet que representa la tabla de prioridades en la base de datos.
    public virtual DbSet<Prioridade> Prioridades { get; set; }
    // DbSet que representa la tabla de recepcionistas en la base de datos.

    public virtual DbSet<Recepcionista> Recepcionistas { get; set; }
    // DbSet que representa la tabla de roles de usuario en la base de datos.

    public virtual DbSet<Role> Roles { get; set; }
    // DbSet que representa la tabla de turnos en la base de datos.

    public virtual DbSet<Turno> Turnos { get; set; }
    // DbSet que representa la tabla de usuarios en la base de datos.

    public virtual DbSet<Usuario> Usuarios { get; set; }

    /// <summary>
    /// Configura el modelo de datos mediante Fluent API.
    /// Define las claves primarias, propiedades (longitudes, tipos),
    /// índices únicos y relaciones entre las entidades del sistema.
    /// </summary>
    /// <param name="modelBuilder">Constructor utilizado para configurar las entidades.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración de la entidad Area, incluyendo clave primaria, propiedades y relaciones.

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AreaId).HasName("PK__Areas__70B820481AA6A0C0");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        // Configuración de la entidad Especialidade, incluyendo clave primaria, propiedades y relaciones.

        modelBuilder.Entity<Especialidade>(entity =>
        {
            entity.HasKey(e => e.EspecialidadId).HasName("PK__Especial__F90718313EE2F13B");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        // Configuración de la entidad Estado, incluyendo clave primaria, propiedades y relaciones.

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.EstadoId).HasName("PK__Estados__FEF86B0034C18108");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        // Configuración de la entidad EstadoTurno, incluyendo clave primaria, propiedades y relaciones.

        modelBuilder.Entity<EstadoTurno>(entity =>
        {
            entity.HasKey(e => e.EstadoTurnoId).HasName("PK__EstadoTu__10C65F0614C4B6BF");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        // Configuración de la entidad Medico, incluyendo clave primaria, propiedades, índices únicos y relaciones.

        modelBuilder.Entity<Medico>(entity =>
        {
            entity.HasKey(e => e.MedicoId).HasName("PK__Medicos__5953C25650033C0A");

            entity.HasIndex(e => e.Nlicencia, "UQ__Medicos__43289F4726D119A4").IsUnique();

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Nlicencia)
                .HasMaxLength(50)
                .HasColumnName("NLicencia");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Especialidad).WithMany(p => p.Medicos)
                .HasForeignKey(d => d.EspecialidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Medicos_Especialidades");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Medicos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Medicos_Usuarios");
        });
        // Configuración de la entidad Paciente, incluyendo clave primaria, propiedades, índices únicos y relaciones.

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.PacienteId).HasName("PK__Paciente__9353C01FA7E9C61A");

            entity.HasIndex(e => e.Cedula, "UQ__Paciente__B4ADFE38E92764D2").IsUnique();

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Seguro).HasMaxLength(100);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });
        // Configuración de la entidad Prioridade, incluyendo clave primaria, propiedades y relaciones.

        modelBuilder.Entity<Prioridade>(entity =>
        {
            entity.HasKey(e => e.PrioridadId).HasName("PK__Priorida__3939172EC92D7A87");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        // Configuración de la entidad Recepcionista, incluyendo clave primaria, propiedades, índices únicos y relaciones.
        modelBuilder.Entity<Recepcionista>(entity =>
        {
            entity.HasKey(e => e.RecepcionistaId).HasName("PK__Recepcio__C76F4478922D5C0D");

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Area).WithMany(p => p.Recepcionista)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcionistas_Areas");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Recepcionista)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcionistas_Usuarios");
        });

        // Configuración de la entidad Role, incluyendo clave primaria, propiedades y relaciones.

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__Roles__F92302F1FE4BA9F5");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        // Configuración de la entidad Turno, incluyendo clave primaria, propiedades, tipos de datos y relaciones.

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.TurnoId).HasName("PK__Turnos__AD3E2E9490E4AF7F");

            entity.Property(e => e.FechaHoraCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");

            entity.HasOne(d => d.EstadoTurno).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.EstadoTurnoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_EstadoTurnos");

            entity.HasOne(d => d.Medico).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.MedicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Medicos");

            entity.HasOne(d => d.Paciente).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Pacientes");

            entity.HasOne(d => d.Prioridad).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.PrioridadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Prioridades");

            entity.HasOne(d => d.Recepcionista).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.RecepcionistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Recepcionistas");
        });
        // Configuración de la entidad Usuario, incluyendo clave primaria, propiedades, índices únicos y relaciones.

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE7B8E1D38B1C");

            entity.HasIndex(e => e.Usuario1, "UQ__Usuarios__E3237CF7EDBF58A5").IsUnique();

            entity.Property(e => e.Contrasena).HasMaxLength(255);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UltimoAcceso).HasColumnType("datetime");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .HasColumnName("Usuario");

            entity.HasOne(d => d.Estado).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Estados");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Roles");
        });

        // Permite extender la configuración del modelo en una clase parcial sin modificar el código generado.

        OnModelCreatingPartial(modelBuilder);
    }

    // Método parcial para permitir la extensión de la configuración del modelo en una clase parcial sin modificar el código generado.
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
