using CAccesoDatos.RepositoryPattern;

namespace CNegocio
{
    /// <summary>
    /// Servicio de lógica de negocio para la gestión de pacientes.
    /// Provee métodos para insertar, actualizar y eliminar pacientes.
    /// </summary>
    public class ServiciosPacientes
    {
        /// <summary>
        /// Inserta un nuevo paciente en el sistema.
        /// </summary>
        /// <param name="cedula">Número de cédula.</param>
        /// <param name="nombre">Nombre del paciente.</param>
        /// <param name="apellido">Apellido del paciente.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento.</param>
        /// <param name="sexo">Sexo (M/F).</param>
        /// <param name="direccion">Dirección (opcional).</param>
        /// <param name="seguro">Información de seguro (opcional).</param>
        /// <param name="correo">Correo electrónico (opcional).</param>
        /// <returns>ID del paciente insertado.</returns>
        public static int InsertarPaciente(string cedula, string nombre, string apellido, DateOnly fechaNacimiento,
            string sexo, string? direccion, string? seguro, string? correo)
        {
            return PacienteRepository.Insertar(cedula, nombre, apellido, fechaNacimiento, sexo, direccion, seguro, correo);
        }

        /// <summary>
        /// Actualiza los datos de un paciente existente.
        /// </summary>
        /// <param name="pacienteId">ID del paciente a actualizar.</param>
        /// <param name="nombre">Nuevo nombre.</param>
        /// <param name="apellido">Nuevo apellido.</param>
        /// <param name="fechaNacimiento">Nueva fecha de nacimiento.</param>
        /// <param name="sexo">Nuevo sexo.</param>
        /// <param name="direccion">Nueva dirección.</param>
        /// <param name="seguro">Nuevo seguro.</param>
        /// <param name="correo">Nuevo correo.</param>
        public static void Actualizar(int pacienteId, string nombre, string apellido, DateOnly fechaNacimiento,
            string sexo, string? direccion, string? seguro, string? correo)
        {
            PacienteRepository.Actualizar(pacienteId, nombre, apellido, fechaNacimiento, sexo, direccion, seguro, correo);
        }

        /// <summary>
        /// Elimina un paciente del sistema.
        /// </summary>
        /// <param name="pacienteId">ID del paciente a eliminar.</param>
        /// <returns>Tupla con éxito y mensaje.</returns>
        public static (bool Success, string Mensaje) Eliminar(int pacienteId)
        {
            return PacienteRepository.Eliminar(pacienteId);
        }
    }
}
