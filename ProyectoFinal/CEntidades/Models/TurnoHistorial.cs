using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Models
{
    public class TurnoHistorialDto
    {
        public int TurnoId { get; set; }
        public int NumeroTurno { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Especialidad { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string Observaciones { get; set; }
        public int PacienteId { get; set; }
    }
}
