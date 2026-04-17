namespace HospitalTurnos.ViewModels
{
    /// <summary>
    /// Todo lo que la Vista principal de la cola necesita.
    /// </summary>
    public class ColaViewModel
    {
        // Turno actualmente en atención (si existe)
        public TurnoViewModel? TurnoEnAtencion { get; set; }

        // Cola ordenada: Emergencia → Prioritario → Normal, luego por FechaHoraCreacion ASC
        // Solo incluye turnos con Estado "Creado"
        public List<TurnoViewModel> ColaEspera { get; set; } = new();

        // Histórico del día (Atendido + Cancelado)
        public List<TurnoViewModel> Historial { get; set; } = new();

        // Resumen para tarjetas del dashboard
        public int TotalCreados { get; set; }
        public int TotalEmergencias { get; set; }
        public int TotalPrioritarios { get; set; }
        public int TotalNormales { get; set; }
        public int TotalAtendidos { get; set; }

        // Filtros aplicados actualmente (para mantener estado en la vista)
        public string? FiltroEstado { get; set; }
        public string? FiltroPrioridad { get; set; }
    }
}