using HospitalTurnos.Services;
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
        // Vista principal de la cola. Acepta filtros opcionales por query string:
        // /Turnos?filtroEstado=Creado&filtroPrioridad=Emergencia
        [HttpGet]
        public IActionResult Index(string? filtroEstado, string? filtroPrioridad)
        {
            var modelo = _turnoService.ObtenerCola(filtroEstado, filtroPrioridad);

            // Pasar catálogos para los <select> de la vista
            ViewBag.Prioridades = _turnoService.ObtenerPrioridades();
            ViewBag.Estados = _turnoService.ObtenerEstados();

            return View(modelo);
        }

        // GET /Turnos/Detalle/5
        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var turno = _turnoService.ObtenerPorId(id);
            if (turno is null) return NotFound();
            return View(turno);
        }

        // GET /Turnos/Crear
        [HttpGet]
        public IActionResult Crear()
        {
            // Llenar dropdowns del formulario
            ViewBag.Pacientes = _turnoService.ObtenerPacientes();
            ViewBag.Medicos = _turnoService.ObtenerMedicos();
            ViewBag.Asistentes = _turnoService.ObtenerAsistentes();
            ViewBag.Prioridades = _turnoService.ObtenerPrioridades();
            return View();
        }

        // POST /Turnos/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(int pacienteId, int medicoId, int? asistenteId,
                                   int prioridadId, string? observaciones)
        {
            if (pacienteId == 0 || medicoId == 0 || prioridadId == 0)
            {
                ModelState.AddModelError("", "Paciente, Médico y Prioridad son requeridos.");
                ViewBag.Pacientes = _turnoService.ObtenerPacientes();
                ViewBag.Medicos = _turnoService.ObtenerMedicos();
                ViewBag.Asistentes = _turnoService.ObtenerAsistentes();
                ViewBag.Prioridades = _turnoService.ObtenerPrioridades();
                return View();
            }

            _turnoService.CrearTurno(pacienteId, medicoId, asistenteId, prioridadId, observaciones);
            TempData["Mensaje"] = "Turno creado correctamente.";
            return RedirectToAction(nameof(Index));
        }

        // POST /Turnos/CambiarEstado
        // Llamado por botones de acción rápida en la vista (Llamar, Atender, Cancelar)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CambiarEstado(int turnoId, int nuevoEstadoId)
        {
            var ok = _turnoService.CambiarEstado(turnoId, nuevoEstadoId);
            if (!ok) return NotFound();

            TempData["Mensaje"] = "Estado actualizado.";
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

        // ??? GET /Turnos/Api/Cola  (JSON — útil para refresco automático con JS)
        [HttpGet("Turnos/Api/Cola")]
        public IActionResult ApiCola()
        {
            var modelo = _turnoService.ObtenerCola();
            return Json(new
            {
                modelo.TotalCreados,
                modelo.TotalEmergencias,
                modelo.TotalPrioritarios,
                modelo.TotalNormales,
                modelo.TotalAtendidos,
                colaEspera = modelo.ColaEspera,
                enAtencion = modelo.TurnoEnAtencion
            });
        }
    }
}
