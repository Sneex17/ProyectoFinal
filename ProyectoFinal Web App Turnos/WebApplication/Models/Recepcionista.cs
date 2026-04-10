namespace HospitalTurnos.Models
{
    public class Recepcionista
    {
        public int RecepcionistaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int AreaId { get; set; }
        public int? UsuarioId { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
