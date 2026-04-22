using CEntidades.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CAccesoDatos.RepositoryPattern
{
    /// <summary>
    /// Repositorio para la gestión de especialidades médicas.
    /// </summary>
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
            var especialidad = _context.Especialidades.Find(tabla.EspecialidadId);

            especialidad.Nombre = tabla.Nombre;
            especialidad.Descripcion = tabla.Descripcion;

            _context.SaveChanges();
        }

        public void Agregar(Especialidade tabla)
        {
            _context.Especialidades.Add(tabla);
            _context.SaveChanges();
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
