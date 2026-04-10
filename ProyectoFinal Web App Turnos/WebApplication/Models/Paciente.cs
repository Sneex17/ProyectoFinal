namespace HospitalTurnos.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Cedula { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = string.Empty;   // "M" | "F"
        public string Direccion { get; set; } = string.Empty;
        public string? Seguro { get; set; }
        public string? Correo { get; set; }

        // Propiedad calculada — útil en vistas
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
