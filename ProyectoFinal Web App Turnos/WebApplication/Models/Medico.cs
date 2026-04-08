namespace HospitalTurnos.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string NLicencia { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int EspecialidadId { get; set; }
        public int? UsuarioId { get; set; }

        public string NombreCompleto => $"Dr(a). {Nombre} {Apellido}";
    }
}
