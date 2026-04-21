using Microsoft.Data.SqlClient;
using System.Data;
using CEntidades.Models;

namespace CAccesoDatos.RepositoryPattern
{
    public class TurnoRepository
    {
        private readonly string _connectionString;

        public TurnoRepository()
        {
            _connectionString = ConexionAppDB.ConnectionString;
        }

        public (int TurnoId, int NumeroTurno, string Mensaje) CrearTurno(
            int pacienteId, int medicoId, int recepcionistaId, int prioridadId, string? observaciones)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_CrearTurno", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PacienteId", pacienteId);
            command.Parameters.AddWithValue("@MedicoId", medicoId);
            command.Parameters.AddWithValue("@RecepcionistaId", recepcionistaId);
            command.Parameters.AddWithValue("@PrioridadId", prioridadId);
            command.Parameters.AddWithValue("@Observaciones", (object?)observaciones ?? DBNull.Value);

            var turnoIdParam = command.Parameters.Add("@TurnoId", SqlDbType.Int);
            turnoIdParam.Direction = ParameterDirection.Output;

            var numeroTurnoParam = command.Parameters.Add("@NumeroTurno", SqlDbType.Int);
            numeroTurnoParam.Direction = ParameterDirection.Output;

            var mensajeParam = command.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 255);
            mensajeParam.Direction = ParameterDirection.Output;

            connection.Open();
            command.ExecuteNonQuery();

            int turnoId = turnoIdParam.Value != DBNull.Value ? (int)turnoIdParam.Value : 0;
            int numeroTurno = numeroTurnoParam.Value != DBNull.Value ? (int)numeroTurnoParam.Value : 0;
            string mensaje = mensajeParam.Value?.ToString() ?? "Turno creado";

            return (turnoId, numeroTurno, mensaje);
        }

        public (bool TieneActivo, int? TurnoIdActual, string? EstadoActual) TieneTurnoActivo(int pacienteId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_TieneTurnoActivo", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PacienteId", pacienteId);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                bool tieneActivo = reader.GetBoolean(0);
                int? turnoId = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                string? estado = reader.IsDBNull(2) ? null : reader.GetString(2);
                return (tieneActivo, turnoId, estado);
            }

            return (false, null, null);
        }

        public List<Turno> ObtenerColaTurnos(int? medicoId = null, int? especialidadId = null)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_ObtenerColaTurnos", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MedicoId", (object?)medicoId ?? DBNull.Value);
            command.Parameters.AddWithValue("@EspecialidadId", (object?)especialidadId ?? DBNull.Value);

            connection.Open();
            using var reader = command.ExecuteReader();

            var turnos = new List<Turno>();
            while (reader.Read())
            {
                var turno = new Turno
                {
                    TurnoId = reader.GetInt32(0),
                    NumeroTurno = reader.GetInt32(1),
                    FechaHoraCreacion = reader.IsDBNull(2) ? null : reader.GetDateTime(2),
                    PrioridadId = reader.GetInt32(3),
                    EstadoTurnoId = 1,
                    PacienteId = reader.GetInt32(6),
                    MedicoId = reader.GetInt32(10),
                    Observaciones = reader.IsDBNull(14) ? null : reader.GetString(14),
                    Paciente = new Paciente
                    {
                        PacienteId = reader.GetInt32(6),
                        Cedula = reader.GetString(7),
                        Nombre = reader.GetString(8),
                        Apellido = reader.GetString(9)
                    },
                    Medico = new Medico
                    {
                        MedicoId = reader.GetInt32(10),
                        Nombre = reader.GetString(11),
                        Apellido = ""
                    },
                    Prioridad = new Prioridade
                    {
                        PrioridadId = reader.GetInt32(3),
                        Nombre = reader.GetString(4)
                    },
                    EstadoTurno = new EstadoTurno
                    {
                        EstadoTurnoId = 1,
                        Nombre = reader.GetString(5)
                    }
                };
                turnos.Add(turno);
            }

            return turnos;
        }

        public (string NuevoEstado, DateTime FechaCambio) CambiarEstadoTurno(int turnoId, int nuevoEstadoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_CambiarEstadoTurno", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TurnoId", turnoId);
            command.Parameters.AddWithValue("@NuevoEstadoId", nuevoEstadoId);

            var mensajeParam = command.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 255);
            mensajeParam.Direction = ParameterDirection.Output;

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                string nuevoEstado = reader.GetString(0);
                DateTime fechaCambio = reader.GetDateTime(1);
                return (nuevoEstado, fechaCambio);
            }

            return ("Desconocido", DateTime.Now);
        }

        public bool ValidarMedicoOcupado(int medicoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_ValidarMedicoOcupado", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MedicoId", medicoId);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return reader.GetBoolean(0);
            }

            return false;
        }

        public int ObtenerPosicionEnCola(int turnoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_PosicionEnCola", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TurnoId", turnoId);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return reader.GetInt32(0);
            }

            return 0;
        }

        public int ObtenerEstadoTurno(int turnoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("SELECT EstadoTurnoId FROM Turnos WHERE TurnoId = @TurnoId", connection);
            command.Parameters.AddWithValue("@TurnoId", turnoId);

            connection.Open();
            var result = command.ExecuteScalar();
            return result != null ? (int)result : 0;
        }

        public Turno? ObtenerTurnoEnAtencion(int medicoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                @"SELECT TOP 1 t.TurnoId, t.NumeroTurno, t.FechaHoraCreacion, t.PrioridadId, t.PacienteId, t.MedicoId, t.Observaciones
                  FROM Turnos t
                  WHERE t.MedicoId = @MedicoId AND t.EstadoTurnoId = 2
                  ORDER BY t.FechaHoraCreacion ASC", connection);
            command.Parameters.AddWithValue("@MedicoId", medicoId);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Turno
                {
                    TurnoId = reader.GetInt32(0),
                    NumeroTurno = reader.GetInt32(1),
                    FechaHoraCreacion = reader.IsDBNull(2) ? null : reader.GetDateTime(2),
                    PrioridadId = reader.GetInt32(3),
                    EstadoTurnoId = 2,
                    PacienteId = reader.GetInt32(4),
                    MedicoId = reader.GetInt32(5),
                    Observaciones = reader.IsDBNull(6) ? null : reader.GetString(6)
                };
            }

            return null;
        }

        public List<Turno> HistorialPaciente(int pacienteId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_HistorialTurnosPaciente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PacienteId", pacienteId);

            connection.Open();
            using var reader = command.ExecuteReader();

            var turnos = new List<Turno>();
            while (reader.Read())
            {
                var turno = new Turno
                {
                    TurnoId = reader.GetInt32(0),
                    NumeroTurno = reader.GetInt32(1),
                    FechaHoraCreacion = reader.IsDBNull(2) ? null : reader.GetDateTime(2),
                    FechaHoraInicio = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                    FechaHoraFin = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    Observaciones = reader.IsDBNull(9) ? null : reader.GetString(9),
                    EstadoTurno = new EstadoTurno { Nombre = reader.GetString(5) },
                    Prioridad = new Prioridade { Nombre = reader.GetString(6) },
                    Medico = new Medico { Nombre = reader.GetString(7) }
                };
                turnos.Add(turno);
            }

            return turnos;
        }
<<<<<<< HEAD

        public (int Total, int Creado, int EnAtencion, int Atendido, int Cancelado, int Postergado) ObtenerEstadisticas(DateTime? fechaDesde, DateTime? fechaHasta, int? especialidadId = null)
        {
            using var connection = new SqlConnection(_connectionString);
            
            fechaDesde = fechaDesde ?? DateTime.Today.AddDays(-30);
            fechaHasta = fechaHasta ?? DateTime.Today;

            string query = @"
                SELECT 
                    et.Nombre AS Estado,
                    COUNT(t.TurnoId) AS Cantidad
                FROM Turnos t
                INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
                LEFT JOIN Medicos m ON t.MedicoId = m.MedicoId
                WHERE CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
                    AND (@EspecialidadId IS NULL OR m.EspecialidadId = @EspecialidadId)
                GROUP BY et.Nombre";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            command.Parameters.AddWithValue("@EspecialidadId", especialidadId ?? (object)DBNull.Value);

            connection.Open();
            using var reader = command.ExecuteReader();

            int creado = 0, enAtencion = 0, atendido = 0, cancelado = 0, postergado = 0;
            int total = 0;

            while (reader.Read())
            {
                var estadoObj = reader["Estado"];
                var cantidadObj = reader["Cantidad"];
                
                if (estadoObj == null || cantidadObj == null || estadoObj == DBNull.Value || cantidadObj == DBNull.Value) continue;
                
                string estado = estadoObj.ToString() ?? "";
                int cantidad = 0;
                int.TryParse(cantidadObj.ToString(), out cantidad);
                total += cantidad;

                switch (estado.Trim())
                {
                    case "Creado": creado = cantidad; break;
                    case "EnAtención": enAtencion = cantidad; break;
                    case "Atendido": atendido = cantidad; break;
                    case "Cancelado": cancelado = cantidad; break;
                    case "Postergado": postergado = cantidad; break;
                }
            }

            return (total, creado, enAtencion, atendido, cancelado, postergado);
        }

        public List<(string Medico, int TurnosAtendidos)> ObtenerTopMedicos(DateTime? fechaDesde, DateTime? fechaHasta, int? especialidadId = null, int top = 5)
        {
            using var connection = new SqlConnection(_connectionString);
            
            fechaDesde = fechaDesde ?? DateTime.Today.AddDays(-30);
            fechaHasta = fechaHasta ?? DateTime.Today;

            string query = $@"
                SELECT TOP {top}
                    m.Nombre + ' ' + m.Apellido AS Medico,
                    COUNT(t.TurnoId) AS TurnosAtendidos
                FROM Turnos t
                INNER JOIN Medicos m ON t.MedicoId = m.MedicoId
                WHERE t.EstadoTurnoId = 3
                    AND CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
                    AND (@EspecialidadId IS NULL OR m.EspecialidadId = @EspecialidadId)
                GROUP BY m.Nombre + ' ' + m.Apellido
                ORDER BY TurnosAtendidos DESC";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            command.Parameters.AddWithValue("@EspecialidadId", especialidadId ?? (object)DBNull.Value);

            connection.Open();
            using var reader = command.ExecuteReader();

            var medicos = new List<(string, int)>();

            while (reader.Read())
            {
                var medicoObj = reader["Medico"];
                var turnosObj = reader["TurnosAtendidos"];
                
                if (medicoObj == null || medicoObj == DBNull.Value) continue;
                
                string medico = medicoObj.ToString() ?? "";
                int turnos = 0;
                if (turnosObj != null && turnosObj != DBNull.Value)
                    int.TryParse(turnosObj.ToString(), out turnos);
                
                medicos.Add((medico, turnos));
            }

            return medicos;
        }

        public int ObtenerTotalPacientes(DateTime? fechaDesde, DateTime? fechaHasta, int? especialidadId = null)
        {
            using var connection = new SqlConnection(_connectionString);
            
            fechaDesde = fechaDesde ?? DateTime.Today.AddDays(-30);
            fechaHasta = fechaHasta ?? DateTime.Today;

            string query = @"
                SELECT COUNT(DISTINCT t.PacienteId) AS TotalPacientes
                FROM Turnos t
                LEFT JOIN Medicos m ON t.MedicoId = m.MedicoId
                WHERE CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
                    AND (@EspecialidadId IS NULL OR m.EspecialidadId = @EspecialidadId)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            command.Parameters.AddWithValue("@EspecialidadId", especialidadId ?? (object)DBNull.Value);

            connection.Open();
            var result = command.ExecuteScalar();
            if (result == null || result == DBNull.Value) return 0;
            
            int valor = 0;
            int.TryParse(result.ToString(), out valor);
            return valor;
        }

        public DataTable ObtenerTurnosDetallados(DateTime? fechaDesde, DateTime? fechaHasta, int? especialidadId = null)
        {
            using var connection = new SqlConnection(_connectionString);
            
            fechaDesde = fechaDesde ?? DateTime.Today.AddDays(-30);
            fechaHasta = fechaHasta ?? DateTime.Today;

            string query = @"
                SELECT 
                    t.TurnoId AS [N° Turno],
                    t.NumeroTurno AS [Número],
                    CAST(t.FechaHoraCreacion AS DATE) AS [Fecha],
                    et.Nombre AS [Estado],
                    pr.Nombre AS [Prioridad],
                    p.Cedula AS [Cédula Paciente],
                    p.Nombre + ' ' + p.Apellido AS [Paciente],
                    m.Nombre + ' ' + m.Apellido AS [Médico],
                    e.Nombre AS [Especialidad],
                    ISNULL(t.Observaciones, '') AS [Observaciones]
                FROM Turnos t
                INNER JOIN EstadoTurnos et ON t.EstadoTurnoId = et.EstadoTurnoId
                INNER JOIN Prioridades pr ON t.PrioridadId = pr.PrioridadId
                INNER JOIN Pacientes p ON t.PacienteId = p.PacienteId
                INNER JOIN Medicos m ON t.MedicoId = m.MedicoId
                INNER JOIN Especialidades e ON m.EspecialidadId = e.EspecialidadId
                WHERE CAST(t.FechaHoraCreacion AS DATE) BETWEEN @FechaDesde AND @FechaHasta
                    AND (@EspecialidadId IS NULL OR e.EspecialidadId = @EspecialidadId)
                ORDER BY t.FechaHoraCreacion DESC";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            command.Parameters.AddWithValue("@EspecialidadId", especialidadId ?? (object)DBNull.Value);

            var dataTable = new DataTable("Estadisticas");
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            
            return dataTable;
        }
=======
>>>>>>> Halveys/Backend
    }
}