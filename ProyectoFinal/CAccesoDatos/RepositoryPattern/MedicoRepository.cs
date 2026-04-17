using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
namespace CAccesoDatos.RepositoryPattern
{
    public class MedicoRepository : IRepositoryGeneral<Medico>
    {
        private readonly GestionTurnosHospitalDbContext _context;
        public MedicoRepository()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
            .UseSqlServer(ConexionAppDB.ConnectionString)
            .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }

        public void Actualizar(Medico tabla)
        {
            _context.Medicos.Update(tabla);
            _context.SaveChanges();
        }

        public void Agregar(Medico tabla)
        {
            _context.Medicos.Add(tabla);
            _context.SaveChanges();
        }

        public void Eliminar(Medico tabla)
        {
            _context.Medicos.Remove(tabla);
            _context.SaveChanges();
        }

        public IList<Medico> Listar()
        {
            return _context.Medicos.ToList();
        }
    }
}
