using CEntidades.Models;
using Microsoft.EntityFrameworkCore;

namespace CAccesoDatos.RepositoryPattern
{
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
            _context.Recepcionistas.Update(tabla);
            _context.SaveChanges();
        }

        public void Agregar(Recepcionista tabla)
        {
            _context.Recepcionistas.Add(tabla);
            _context.SaveChanges();
        }

        public void Eliminar(Recepcionista tabla)
        {
            _context.Recepcionistas.Remove(tabla);
            _context.SaveChanges();
        }

        public IList<Recepcionista> Listar()
        {
            return _context.Recepcionistas.ToList();
        }

        public Recepcionista? ObtenerPorUsuarioId(int usuarioId)
        {
            return _context.Recepcionistas
                .FirstOrDefault(r => r.UsuarioId == usuarioId);
        }
    }
}