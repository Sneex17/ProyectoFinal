using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
namespace CAccesoDatos.RepositoryPattern
{
    public class EstadoRepository : IRepositoryGeneral<Estado>
    {
        private readonly GestionTurnosHospitalDbContext _context;
        public EstadoRepository()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
            .UseSqlServer(ConexionAppDB.ConnectionString)
            .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }
        public void Actualizar(Estado tabla)
        {
            _context.Estados.Update(tabla);
            _context.SaveChanges();
        }
        public void Agregar(Estado tabla)
        {
            _context.Estados.Add(tabla);
            _context.SaveChanges();
        }
        public void Eliminar(Estado tabla)
        {
            _context.Estados.Remove(tabla);
            _context.SaveChanges();
        }
        public IList<Estado> Listar()
        {
            return _context.Estados.ToList();
        }
    }
}
