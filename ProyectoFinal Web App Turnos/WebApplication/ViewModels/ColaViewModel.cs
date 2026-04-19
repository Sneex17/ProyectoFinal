namespace HospitalTurnos.ViewModels
{
    /// <summary>
    /// Todo lo que la Vista principal de la cola necesita.
    /// </summary>
    public class ColaViewModel
    {
        // Turno actualmente en atención (si existe)
        public TurnoViewModel? TurnoEnAtencion { get; set; }

        // Cola ordenada jerárquicamente
        public List<TurnoViewModel> ColaEspera { get; set; } = new();

        // Histórico del día (Atendido + Cancelado)
        public List<TurnoViewModel> Historial { get; set; } = new();

        // Resumen para tarjetas del dashboard
        public int TotalCreados { get; set; }
        public int TotalUrgentes { get; set; }
        public int TotalAltas { get; set; }
        public int TotalMedias { get; set; }
        public int TotalBajas { get; set; }
        public int TotalAtendidos { get; set; }

        // Filtros aplicados actualmente
        public string? FiltroEstado { get; set; }
        public string? FiltroPrioridad { get; set; }
    }
}
