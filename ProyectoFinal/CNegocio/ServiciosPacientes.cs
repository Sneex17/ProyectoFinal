using CAccesoDatos.RepositoryPattern;

namespace CNegocio
{
    public class ServiciosPacientes
    {
        public static int InsertarPaciente(string cedula, string nombre, string apellido, DateOnly fechaNacimiento,
            string sexo, string? direccion, string? seguro, string? correo)
        {
            return PacienteRepository.Insertar(cedula, nombre, apellido, fechaNacimiento, sexo, direccion, seguro, correo);
        }

        public static void Actualizar(int pacienteId, string nombre, string apellido, DateOnly fechaNacimiento,
            string sexo, string? direccion, string? seguro, string? correo)
        {
            PacienteRepository.Actualizar(pacienteId, nombre, apellido, fechaNacimiento, sexo, direccion, seguro, correo);
        }

        public static (bool Success, string Mensaje) Eliminar(int pacienteId)
        {
            return PacienteRepository.Eliminar(pacienteId);
        }
    }
}
