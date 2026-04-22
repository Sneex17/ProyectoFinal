using Microsoft.Data.SqlClient;
using System.Data;
using CEntidades.Models;

namespace CAccesoDatos.RepositoryPattern
{
    /// <summary>
    /// Repositorio para la gestión de pacientes en la base de datos.
    /// </summary>
    public class PacienteRepository
    {
        private static readonly string _connectionString;

        static PacienteRepository()
        {
            _connectionString = ConexionAppDB.ConnectionString;
        }

        public static int Insertar(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, 
            string sexo, string? direccion, string? seguro, string? correo)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_InsertarPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.ToDateTime(TimeOnly.MinValue));
            command.Parameters.AddWithValue("@Sexo", sexo);
            command.Parameters.AddWithValue("@Direccion", (object?)direccion ?? DBNull.Value);
            command.Parameters.AddWithValue("@Seguro", (object?)seguro ?? DBNull.Value);
            command.Parameters.AddWithValue("@Correo", (object?)correo ?? DBNull.Value);

            var pacienteIdParam = command.Parameters.Add("@PacienteId", SqlDbType.Int);
            pacienteIdParam.Direction = ParameterDirection.Output;

            connection.Open();
            command.ExecuteNonQuery();

            return (int)pacienteIdParam.Value;
        }

        public static void Actualizar(int pacienteId, string nombre, string apellido, DateOnly fechaNacimiento,
            string sexo, string? direccion, string? seguro, string? correo)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_ActualizarPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PacienteId", pacienteId);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.ToDateTime(TimeOnly.MinValue));
            command.Parameters.AddWithValue("@Sexo", sexo);
            command.Parameters.AddWithValue("@Direccion", (object?)direccion ?? DBNull.Value);
            command.Parameters.AddWithValue("@Seguro", (object?)seguro ?? DBNull.Value);
            command.Parameters.AddWithValue("@Correo", (object?)correo ?? DBNull.Value);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public static (bool Success, string Mensaje) Eliminar(int pacienteId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_EliminarPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PacienteId", pacienteId);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return (true, reader.GetString(1));
            }
            return (false, "Error al eliminar paciente");
        }

        public Paciente? BuscarPorCedula(string cedula)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_BuscarPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return MapearPaciente(reader);
            }
            return null;
        }

        public Paciente? BuscarPorNombre(string nombre)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_BuscarPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Nombre", nombre);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return MapearPaciente(reader);
            }
            return null;
        }

        public Paciente? BuscarPorCodigo(int codigo)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_BuscarPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Codigo", codigo);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return MapearPaciente(reader);
            }
            return null;
        }

        public (List<Paciente> Pacientes, int TotalRegistros) Listar(int pageNumber, int pageSize, string? buscar)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_ListarPacientes", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PageNumber", pageNumber);
            command.Parameters.AddWithValue("@PageSize", pageSize);
            command.Parameters.AddWithValue("@Buscar", (object?)buscar ?? DBNull.Value);

            connection.Open();
            using var reader = command.ExecuteReader();

            var pacientes = new List<Paciente>();
            int totalRegistros = 0;

            while (reader.Read())
            {
                pacientes.Add(MapearPaciente(reader));
                totalRegistros = reader.GetInt32(9);
            }

            return (pacientes, totalRegistros);
        }

        public Paciente? ObtenerPorId(int pacienteId)
        {
            return BuscarPorCodigo(pacienteId);
        }

        private Paciente MapearPaciente(SqlDataReader reader)
        {
            return new Paciente
            {
                PacienteId = reader.GetInt32(0),
                Cedula = reader.GetString(1),
                Nombre = reader.GetString(2),
                Apellido = reader.GetString(3),
                FechaNacimiento = DateOnly.FromDateTime(reader.GetDateTime(4)),
                Sexo = reader.GetString(5),
                Direccion = reader.IsDBNull(6) ? null : reader.GetString(6),
                Seguro = reader.IsDBNull(7) ? null : reader.GetString(7),
                Correo = reader.IsDBNull(8) ? null : reader.GetString(8)
            };
        }
    }
}