using CEntidades.Models;
using Microsoft.EntityFrameworkCore;

namespace CAccesoDatos.RepositoryPattern
{
    /// <summary>
    /// Repositorio para la gestión de roles usando Entity Framework Core.
    /// </summary>
    public class RolRepository : IRepositoryGeneral<Role>
    {
        private readonly GestionTurnosHospitalDbContext _context;
        public RolRepository()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
            .UseSqlServer(ConexionAppDB.ConnectionString)
            .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }
        public void Actualizar(Role tabla)
        {
            _context.Roles.Update(tabla);
            _context.SaveChanges();
        }
        public void Agregar(Role tabla)
        {
            _context.Roles.Add(tabla);
            _context.SaveChanges();
        }
        public void Eliminar(Role tabla)
        {
            _context.Roles.Remove(tabla);
            _context.SaveChanges();
        }
        public IList<Role> Listar()
        {
            return _context.Roles.ToList();
        }
    }
}
