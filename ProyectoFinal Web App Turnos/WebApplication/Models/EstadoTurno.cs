namespace HospitalTurnos.Models
{
    /// <summary>
    /// Valores esperados: 1-Creado | 2-EnAtencion | 3-Atendido | 4-Cancelado
    /// </summary>
    public class EstadoTurno
    {
        public int EstadoTurnoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public string CssClass => Nombre.ToLower() switch
        {
            "enatención" or "enatención" => "en-atencion",
            "atendido" => "atendido",
            "cancelado" => "cancelado",
            _ => "creado"
        };
    }
}
