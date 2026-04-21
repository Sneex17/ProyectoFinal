using Microsoft.Data.SqlClient;
using System.Data;
using CEntidades.Models;

namespace CAccesoDatos.RepositoryPattern
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository()
        {
            _connectionString = ConexionAppDB.ConnectionString;
        }

        public Usuario? ValidarLogin(string usuario, string contrasena)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_Login", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@Contrasena", contrasena);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Usuario
                {
                    UsuarioId = reader.GetInt32(0),
                    Usuario1 = reader.GetString(1),
                    RolId = reader.GetInt32(2),
                    EstadoId = reader.GetInt32(4),
                    // Propiedades adicionales que devolveremos
                };
            }
            return null;
        }

        public (int UsuarioId, string NombreUsuario, int RolId, string RolNombre, int EstadoId, int? IdRelacionado)? 
            ValidarLoginConRol(string usuario, string contrasena)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_Login", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@Contrasena", contrasena);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                int? idRelacionado = reader.IsDBNull(6) ? null : reader.GetInt32(6);
                return (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    idRelacionado
                );
            }
            return null;
        }
    }
}