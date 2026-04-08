namespace HospitalTurnos.ViewModels
{
    /// <summary>
    /// Datos aplanados que la Vista necesita para mostrar UNA fila de la cola.
    /// Nunca expone modelos internos directamente — desacopla Model de View.
    /// </summary>
    public class TurnoViewModel
    {
        public int TurnoId { get; set; }
        public int NumeroTurno { get; set; }

        // Paciente
        public string PacienteNombre { get; set; } = string.Empty;
        public string PacienteCedula { get; set; } = string.Empty;

        // Médico
        public string MedicoNombre { get; set; } = string.Empty;

        // Prioridad
        public string PrioridadNombre { get; set; } = string.Empty;
        public string PrioridadCss { get; set; } = string.Empty;       // "normal" | "prioritario" | "emergencia"

        // Estado
        public string EstadoNombre { get; set; } = string.Empty;
        public string EstadoCss { get; set; } = string.Empty;           // "creado" | "en-atencion" | "atendido" | "cancelado"

        // Tiempos
        public DateTime FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }

        public string? Observaciones { get; set; }

        /// <summary>Tiempo en sala desde que fue creado hasta ahora (si aún no fue atendido).</summary>
        public TimeSpan TiempoEspera => FechaHoraInicio.HasValue
            ? FechaHoraInicio.Value - FechaHoraCreacion
            : DateTime.Now - FechaHoraCreacion;
    }
}