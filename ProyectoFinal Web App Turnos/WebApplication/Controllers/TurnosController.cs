using HospitalTurnos.Models;
using HospitalTurnos.Services;
using HospitalTurnos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HospitalTurnos.Controllers
{
    public class TurnosController : Controller
    {
        private readonly ITurnoService _turnoService;

        public TurnosController(ITurnoService turnoService)
        {
            _turnoService = turnoService;
        }

        // GET /Turnos
        public IActionResult Index(string? filtroEstado, string? filtroPrioridad)
        {
            var modelo = _turnoService.ObtenerCola(filtroEstado, filtroPrioridad);
            
            ViewBag.Estados = _turnoService.ObtenerEstados(); 
            ViewBag.Prioridades = _turnoService.ObtenerPrioridades();

            return View(modelo);
        }

        // GET /Turnos/Crear
        public IActionResult Crear()
        {
            ViewBag.Especialidades = _turnoService.ObtenerEspecialidades();
            return View();
        }

        [HttpGet]
        public IActionResult GetPacienteByCedula(string cedula)
        {
            var paciente = _turnoService.ObtenerPacientePorCedula(cedula);
            if (paciente == null) return NotFound();

            return Json(new { 
                pacienteId = paciente.PacienteId, 
                nombreCompleto = paciente.NombreCompleto 
            });
        }

        [HttpGet]
        public IActionResult GetMedicosByEspecialidad(int especialidadId)
        {
            var medicos = _turnoService.ObtenerMedicosPorEspecialidad(especialidadId);
            return Json(medicos.Select(m => new { 
                medicoId = m.MedicoId, 
                nombreCompleto = m.NombreCompleto 
            }));
        }

        // POST /Turnos/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(int pacienteId, int medicoId, int? recepcionistaId, 
                                  int prioridadId, string? observaciones)
        {
            try 
            {
                _turnoService.CrearTurno(pacienteId, medicoId, recepcionistaId, prioridadId, observaciones);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["ModelError"] = "Error al crear el turno: " + ex.Message;
                ViewBag.Especialidades = _turnoService.ObtenerEspecialidades();
                return View();
            }
        }

        // POST /Turnos/CambiarEstado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CambiarEstado(int turnoId, int nuevoEstadoId)
        {
            _turnoService.CambiarEstado(turnoId, nuevoEstadoId);
            return RedirectToAction(nameof(Index));
        }

        // POST /Turnos/Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(int turnoId)
        {
            _turnoService.EliminarTurno(turnoId);
            TempData["Mensaje"] = "Turno eliminado.";
            return RedirectToAction(nameof(Index));
        }

        // GET /Turnos/Api/Cola
        [HttpGet("Turnos/Api/Cola")]
        public IActionResult ApiCola()
        {
            var modelo = _turnoService.ObtenerCola();
            return Json(new
            {
                modelo.TotalCreados,
                modelo.TotalUrgentes,
                modelo.TotalAltas,
                modelo.TotalMedias,
                modelo.TotalBajas,
                modelo.TotalAtendidos,
                colaEspera = modelo.ColaEspera,
                enAtencion = modelo.TurnoEnAtencion
            });
        }
    }
}
