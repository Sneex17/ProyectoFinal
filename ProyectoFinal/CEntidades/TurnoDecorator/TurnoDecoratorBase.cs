using CEntidades.Models;

namespace CEntidades.TurnoDecorator
{
    /// <summary>
    /// Clase base abstracta del patrón Decorator.
    /// Envuelve un ITurno y delega todo al objeto envuelto por defecto.
    /// Los decoradores concretos solo sobreescriben lo que necesitan cambiar.
    /// </summary>
    public abstract class TurnoDecoratorBase : ITurno
    {
        protected readonly ITurno _turno;

        protected TurnoDecoratorBase(ITurno turno)
        {
            _turno = turno ?? throw new ArgumentNullException(nameof(turno));
        }

        public int TurnoId
        {
            get => _turno.TurnoId;
            set => _turno.TurnoId = value;
        }

        public int PacienteId
        {
            get => _turno.PacienteId;
            set => _turno.PacienteId = value;
        }

        public int MedicoId
        {
            get => _turno.MedicoId;
            set => _turno.MedicoId = value;
        }

        public int RecepcionistaId
        {
            get => _turno.RecepcionistaId;
            set => _turno.RecepcionistaId = value;
        }

        public string? Observaciones
        {
            get => _turno.Observaciones;
            set => _turno.Observaciones = value;
        }

        public int NumeroTurno
        {
            get => _turno.NumeroTurno;
            set => _turno.NumeroTurno = value;
        }

        public int PrioridadId
        {
            get => _turno.PrioridadId;
            set => _turno.PrioridadId = value;
        }

        public int EstadoTurnoId
        {
            get => _turno.EstadoTurnoId;
            set => _turno.EstadoTurnoId = value;
        }

        public DateTime? FechaHoraCreacion
        {
            get => _turno.FechaHoraCreacion;
            set => _turno.FechaHoraCreacion = value;
        }

        public DateTime? FechaHoraInicio
        {
            get => _turno.FechaHoraInicio;
            set => _turno.FechaHoraInicio = value;
        }

        public DateTime? FechaHoraFin
        {
            get => _turno.FechaHoraFin;
            set => _turno.FechaHoraFin = value;
        }

        public EstadoTurno EstadoTurno
        {
            get => _turno.EstadoTurno;
            set => _turno.EstadoTurno = value;
        }

        public Medico Medico
        {
            get => _turno.Medico;
            set => _turno.Medico = value;
        }

        public Paciente Paciente
        {
            get => _turno.Paciente;
            set => _turno.Paciente = value;
        }

        public Prioridade Prioridad
        {
            get => _turno.Prioridad;
            set => _turno.Prioridad = value;
        }

        public Recepcionista Recepcionista
        {
            get => _turno.Recepcionista;
            set => _turno.Recepcionista = value;
        }

        public virtual string GetEtiqueta() => _turno.GetEtiqueta();
        public virtual string GetColorFila() => _turno.GetColorFila();
        public virtual string GetDescripcion() => _turno.GetDescripcion();

        public override string ToString() => _turno.ToString();
    }
}
