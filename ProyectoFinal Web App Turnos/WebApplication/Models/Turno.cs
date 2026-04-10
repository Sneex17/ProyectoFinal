namespace HospitalTurnos.Models
{
    public class Turno
    {
        public int TurnoId { get; set; }

        // FKs — IDs planos (como viene de BD)
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public int? RecepcionistaId { get; set; }
        public int PrioridadId { get; set; }
        public int EstadoTurnoId { get; set; }

        public string? Observaciones { get; set; }
        public int NumeroTurno { get; set; }

        public DateTime FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }

        // Navegación — se poblan desde el servicio (equivalen a los JOINs de SQL)
        public Paciente Paciente { get; set; } = null!;
        public Medico Medico { get; set; } = null!;
        public Recepcionista? Recepcionista { get; set; }
        public Prioridad Prioridad { get; set; } = null!;
        public EstadoTurno EstadoTurno { get; set; } = null!;
    }
}
