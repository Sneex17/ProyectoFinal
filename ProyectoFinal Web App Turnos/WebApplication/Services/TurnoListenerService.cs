using HospitalTurnos.Hubs;
using HospitalTurnos.Models;
using Microsoft.AspNetCore.SignalR;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace HospitalTurnos.Services
{
    public class TurnoListenerService : BackgroundService
    {
        private readonly string _connectionString;
        private readonly IHubContext<TurnoHub> _hubContext;
        private SqlTableDependency<Turno>? _tableDependency;

        public TurnoListenerService(IConfiguration configuration, IHubContext<TurnoHub> hubContext)
        {
            _connectionString = configuration.GetConnectionString("HospitalTurnos") ?? "";
            _hubContext = hubContext;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // El mapper ayuda a SqlTableDependency a entender la estructura si los nombres difieren,
            // pero Turno coincide con los nombres de columna estándar.
            _tableDependency = new SqlTableDependency<Turno>(_connectionString, "Turnos");

            _tableDependency.OnChanged += TableDependency_OnChanged;
            _tableDependency.OnError += TableDependency_OnError;

            _tableDependency.Start();

            // El servicio corre hasta que se cancele
            return Task.CompletedTask;
        }

        private async void TableDependency_OnChanged(object sender, RecordChangedEventArgs<Turno> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                // Notificar a todos los clientes que la cola ha cambiado
                await _hubContext.Clients.All.SendAsync("UpdateQueue");
            }
        }

        private void TableDependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            // Loguear error si fuera necesario
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _tableDependency?.Stop();
            _tableDependency?.Dispose();
            await base.StopAsync(cancellationToken);
        }
    }
}
