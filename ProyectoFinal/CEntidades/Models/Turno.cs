using System;
using System.Collections.Generic;
using CEntidades.TurnoDecorator;

namespace CEntidades.Models;

/// <summary>
/// Representa un turno médico dentro del sistema.
/// Contiene la información del paciente, médico, recepcionista,
/// prioridad, estado y las fechas relacionadas al turno.
/// </summary>
public partial class Turno : ITurno
{
    /// <summary>
    /// Identificador único del turno.
    /// </summary>
    public int TurnoId { get; set; }
    /// <summary>
    /// Identificador del paciente asociado al turno.
    /// </summary>
    public int PacienteId { get; set; }

    /// <summary>
    /// Identificador del médico asignado al turno.
    /// </summary>
    public int MedicoId { get; set; }
    /// <summary>
    /// Identificador del recepcionista asociado al turno.
    /// </summary>
    public int RecepcionistaId { get; set; }

    /// <summary>
    /// Observaciones adicionales del turno.
    /// </summary>
    public string? Observaciones { get; set; }

    /// <summary>
    /// Número asignado al turno.
    /// </summary>
    public int NumeroTurno { get; set; }

    /// <summary>
    /// Identificador de la prioridad del turno.
    /// </summary>
    public int PrioridadId { get; set; }

    /// <summary>
    /// Identificador del estado del turno.
    /// </summary>
    public int EstadoTurnoId { get; set; }

    /// <summary>
    /// Fecha y hora de creación del turno.
    /// </summary>

    public DateTime? FechaHoraCreacion { get; set; }

    /// <summary>
    /// Fecha y hora de inicio del turno.
    /// </summary>
    public DateTime? FechaHoraInicio { get; set; }
    /// <summary>
    /// Fecha y hora de finalización del turno.
    /// </summary>
    public DateTime? FechaHoraFin { get; set; }

    /// <summary>
    /// Estado actual del turno.
    /// </summary>
    public virtual EstadoTurno EstadoTurno { get; set; } = null!;

    /// <summary>
    /// Médico asignado al turno.
    /// </summary>
    public virtual Medico Medico { get; set; } = null!;
    /// <summary>
    /// Paciente asociado al turno.
    /// </summary>  
    public virtual Paciente Paciente { get; set; } = null!;
    /// <summary>
    /// Prioridad del turno.
    /// </summary>
    public virtual Prioridade Prioridad { get; set; } = null!;
    /// <summary>
    /// Recepcionista asociado al turno.
    /// </summary>
    public virtual Recepcionista Recepcionista { get; set; } = null!;

    /// <summary>
    /// Obtiene la etiqueta de prioridad del turno en formato texto.
    /// </summary>
    /// <returns>Cadena que representa la prioridad (Alta, Media, Baja, Urgente o Sin especificar).</returns>
    public virtual string GetEtiqueta()
        => PrioridadId switch
        {
            1 => "Alta",
            2 => "Media",
            3 => "Baja",
            4 => "Urgente",
            _ => "Sin especificar"
        };

    /// <summary>
    /// Obtiene el color de la fila asociado al turno.
    /// </summary>
    /// <returns>Nombre del color en formato texto.</returns>
    public virtual string GetColorFila()
        => "White";

    /// <summary>
    /// Obtiene una descripción resumida del turno.
    /// </summary>
    /// <returns>Cadena descriptiva del turno.</returns>
    public virtual string GetDescripcion()
        => $"Turno {NumeroTurno} — {Paciente.NombreCompleto} | {EstadoTurno.Nombre}";
   
    /// <summary>
    /// Devuelve una representación en texto del turno.
    /// </summary>
    /// <returns>Cadena representativa del turno.</returns>
    public override string ToString()
        => $"{NumeroTurno} - {Paciente.NombreCompleto}";
}