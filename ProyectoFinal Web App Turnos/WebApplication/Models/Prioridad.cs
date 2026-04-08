namespace HospitalTurnos.Models
{
    // <summary>
    /// Valores esperados: 1-Normal | 2-Prioritario | 3-Emergencia
    /// El orden de atención se basa en PrioridadId DESC, luego FechaHoraCreacion ASC
    /// </summary>
    public class Prioridad
    {
        public int PrioridadId { get; set; }
        public string Nombre { get; set; } = string.Empty;          // "Normal" | "Prioritario" | "Emergencia"
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Clase CSS asociada para colorear la fila en el frontend.
        /// El HTML simplemente usa: class="prioridad-@turno.Prioridad.CssClass"
        /// </summary>
        public string CssClass => Nombre.ToLower() switch
        {
            "emergencia" => "emergencia",
            "prioritario" => "prioritario",
            _ => "normal"
        };
    }
}
