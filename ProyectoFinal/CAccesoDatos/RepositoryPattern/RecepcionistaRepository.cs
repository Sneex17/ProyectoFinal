using CEntidades.Models;
using Microsoft.EntityFrameworkCore;

namespace CAccesoDatos.RepositoryPattern
{
    /// <summary>
    /// Repositorio para la gestión de recepcionistas usando Entity Framework Core.
    /// </summary>
    public class RecepcionistaRepository : IRepositoryGeneral<Recepcionista>
    {
        private readonly GestionTurnosHospitalDbContext _context;

        public RecepcionistaRepository()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
                .UseSqlServer(ConexionAppDB.ConnectionString)
                .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }

        public void Actualizar(Recepcionista tabla)
        {
            var recepcionistaExistente = _context.Recepcionistas.Include(u => u.Usuario)
                .FirstOrDefault(m => m.RecepcionistaId == tabla.RecepcionistaId);
            if (recepcionistaExistente != null)
            {
                if(string.IsNullOrWhiteSpace(recepcionistaExistente.Usuario.Contrasena))
                {
                    UsuarioRepository.ActualizarUsuario(recepcionistaExistente.Usuario);
                }

                recepcionistaExistente.Nombre = tabla.Nombre;
                recepcionistaExistente.Apellido = tabla.Apellido;
                recepcionistaExistente.AreaId = tabla.AreaId;
                recepcionistaExistente.EstadoId = tabla.EstadoId;
                _context.SaveChanges();
            }
        }

        public void Agregar(Recepcionista tabla)
        {
            _context.Recepcionistas.Add(tabla);
            _context.SaveChanges();
        }

        public void Eliminar(Recepcionista tabla)
        {
            var medicoExistente = _context.Recepcionistas.Include(u => u.Usuario)
                .FirstOrDefault(m => m.RecepcionistaId == tabla.RecepcionistaId);
            if (medicoExistente != null)
            {
                medicoExistente.Usuario.EstadoId = 3;
                UsuarioRepository.DesactivarUsuario(medicoExistente.Usuario);

                medicoExistente.EstadoId = tabla.EstadoId;
                _context.SaveChanges();
            }
        }

        public IList<Recepcionista> Listar()
        {
            return _context.Recepcionistas
                .Include(a => a.Area)
                .Include(u => u.Usuario)
                .Include(e => e.Estado).ToList();
        }

        public Recepcionista? ObtenerPorUsuarioId(int usuarioId)
        {
            return _context.Recepcionistas
                .FirstOrDefault(r => r.UsuarioId == usuarioId);
        }
    }
}