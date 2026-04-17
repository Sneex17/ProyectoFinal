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
            throw new NotImplementedException();
        }

        public void Agregar(Especialidade tabla)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Especialidade tabla)
        {
            throw new NotImplementedException();
        }

        public IList<Especialidade> Listar()
        {
           return _context.Especialidades.ToList();
        }
    }
}
