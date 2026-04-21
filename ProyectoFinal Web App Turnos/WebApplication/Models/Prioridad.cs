namespace HospitalTurnos.Models
{
    /// <summary>
    /// Valores esperados: 1-Alta | 2-Media | 3-Baja | 4-Urgente
    /// El orden de atención se basa en una jerarquía personalizada.
    /// </summary>
    public class Prioridad
    {
        public int PrioridadId { get; set; }
        public string Nombre { get; set; } = string.Empty;          
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Clase CSS asociada para colorear la fila en el frontend.
        /// </summary>
        public string CssClass => Nombre.ToLower() switch
        {
            "urgente" => "emergencia",
            "alta" => "prioritario",
            "media" => "media",
            "baja" => "baja",
            _ => "normal"
        };
    }
}
