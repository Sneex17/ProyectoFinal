using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
namespace CAccesoDatos.RepositoryPattern
{
    public class UsuariosRepositoty : IRepositoryGeneral<Usuario>
    {
        private readonly GestionTurnosHospitalDbContext _context;
        public UsuariosRepositoty()
        {
            var options = new DbContextOptionsBuilder<GestionTurnosHospitalDbContext>()
            .UseSqlServer(ConexionAppDB.ConnectionString)
            .Options;
            _context = new GestionTurnosHospitalDbContext(options);
        }
        public void Actualizar(Usuario tabla)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Usuario tabla)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Usuario tabla)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
    }
}
