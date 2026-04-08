namespace HospitalTurnos.Models
{
    public class Asistente
    {
        public int AsistenteId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int AreaId { get; set; }
        public int? UsuarioId { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
