using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
namespace CAccesoDatos.RepositoryPattern
{
    public class EspecialidadesRepositoty : IRepositoryGeneral<Especialidade>
    {
        private readonly GestionTurnosHospitalDbContext _context;
        public EspecialidadesRepositoty()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
            .UseSqlServer(ConexionAppDB.ConnectionString)
            .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }
        public void Actualizar(Especialidade tabla)
        {
            _context.Especialidades.Update(tabla);
            _context.SaveChanges();
        }

        public void Agregar(Especialidade tabla)
        {
            _context.Especialidades.Add(tabla);
            _context.SaveChanges();
        }

        public void Eliminar(Especialidade tabla)
        {
            _context.Especialidades.Remove(tabla);
            _context.SaveChanges();
        }

        public IList<Especialidade> Listar()
        {
           return _context.Especialidades.ToList();
        }
    }
}
