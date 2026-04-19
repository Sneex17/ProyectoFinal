using System;
using System.Collections.Generic;
using CEntidades.TurnoDecorator;

namespace CEntidades.Models;
public partial class Turno : ITurno
{
    public int TurnoId { get; set; }
    public int PacienteId { get; set; }
    public int MedicoId { get; set; }
    public int RecepcionistaId { get; set; }
    public string? Observaciones { get; set; }
    public int NumeroTurno { get; set; }
    public int PrioridadId { get; set; }
    public int EstadoTurnoId { get; set; }
    public DateTime? FechaHoraCreacion { get; set; }
    public DateTime? FechaHoraInicio { get; set; }
    public DateTime? FechaHoraFin { get; set; }

    public virtual EstadoTurno EstadoTurno { get; set; } = null!;
    public virtual Medico Medico { get; set; } = null!;
    public virtual Paciente Paciente { get; set; } = null!;
    public virtual Prioridade Prioridad { get; set; } = null!;
    public virtual Recepcionista Recepcionista { get; set; } = null!;

    public virtual string GetEtiqueta()
        => PrioridadId switch
        {
            1 => "Alta",
            2 => "Media",
            3 => "Baja",
            4 => "Urgente",
            _ => "Sin especificar"
        };

    public virtual string GetColorFila()
        => "White";

    public virtual System.Drawing.Color GetColor()
        => System.Drawing.Color.White;

    public virtual string GetDescripcion()
        => $"Turno {NumeroTurno} — {Paciente.NombreCompleto} | {EstadoTurno.Nombre}";

    public override string ToString()
        => $"{NumeroTurno} - {Paciente.NombreCompleto}";
}