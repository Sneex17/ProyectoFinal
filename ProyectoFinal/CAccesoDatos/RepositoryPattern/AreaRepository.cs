using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
namespace CAccesoDatos.RepositoryPattern
{
    public class AreaRepository : IRepositoryGeneral<Area>
    {
        private readonly GestionTurnosHospitalDbContext _context;
        public AreaRepository()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
            .UseSqlServer(ConexionAppDB.ConnectionString)
            .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }
        public void Actualizar(Area tabla)
        {
            _context.Areas.Update(tabla);
            _context.SaveChanges();
        }
        public void Agregar(Area tabla)
        {
            _context.Areas.Add(tabla);
            _context.SaveChanges();
        }
        public void Eliminar(Area tabla)
        {
            _context.Areas.Remove(tabla);
            _context.SaveChanges();
        }
        public IList<Area> Listar()
        {
            return _context.Areas.ToList();
        }
    }
}
