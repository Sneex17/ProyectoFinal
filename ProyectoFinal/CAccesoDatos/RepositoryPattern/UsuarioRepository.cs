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


        public static int AgregarUsuario(Usuario usuario)
        {
            using var connection = new SqlConnection(ConexionAppDB.ConnectionString);
            using var command = new SqlCommand("sp_AgregarUsuario", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Usuario", usuario.Usuario1);
            command.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
            command.Parameters.AddWithValue("@FechaCreacion", usuario.FechaCreacion);
            command.Parameters.AddWithValue("@RolId", usuario.RolId);
            command.Parameters.AddWithValue("@EstadoId", usuario.EstadoId);
            connection.Open();

            int result = (int)command.ExecuteScalar();
            return result;
        }


        public static void ActualizarUsuario(Usuario usuario)
        {
            using var connection = new SqlConnection(ConexionAppDB.ConnectionString);
            using var command = new SqlCommand("sp_ActualizarUsuario", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
            command.Parameters.AddWithValue("@Usuario", usuario.Usuario1);
            command.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
            command.Parameters.AddWithValue("@RolId", usuario.RolId);
            command.Parameters.AddWithValue("@EstadoId", usuario.EstadoId);
            connection.Open();

            int result = command.ExecuteNonQuery();
        }

        public static void DesactivarUsuario(Usuario usuario)
        {
            using var connection = new SqlConnection(ConexionAppDB.ConnectionString);
            using var command = new SqlCommand("sp_DesactivarUsuario", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
            command.Parameters.AddWithValue("@EstadoId", usuario.EstadoId);
            connection.Open();

            int result = command.ExecuteNonQuery();
        }
    }
}