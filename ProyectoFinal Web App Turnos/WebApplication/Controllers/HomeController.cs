using HospitalTurnos.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalTurnos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITurnoService _turnoService;

        public HomeController(ITurnoService turnoService)
        {
            _turnoService = turnoService;
        }

        // GET /  →  redirige a la cola
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Turnos");
        }
    }
}
