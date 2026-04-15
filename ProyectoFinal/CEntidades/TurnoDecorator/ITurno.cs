using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.TurnoDecorator
{
    public interface ITurno
    {
        int TurnoId { get; set; }
        int PacienteId { get; set; }
        int MedicoId { get; set; }
        int RecepcionistaId { get; set; }
        string? Observaciones { get; set; }
        int NumeroTurno { get; set; }
        int PrioridadId { get; set; }
        int EstadoTurnoId { get; set; }
        DateTime? FechaHoraCreacion { get; set; }
        DateTime? FechaHoraInicio { get; set; }
        DateTime? FechaHoraFin { get; set; }

        EstadoTurno EstadoTurno { get; set; }
        Medico Medico { get; set; }
        Paciente Paciente { get; set; }
        Prioridade Prioridad { get; set; }
        Recepcionista Recepcionista { get; set; }

        string GetEtiqueta();
        string GetColorFila();
        string GetDescripcion();

    }
}