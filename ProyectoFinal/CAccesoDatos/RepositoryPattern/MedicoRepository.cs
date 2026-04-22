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
            if (tabla != null)
            {
            var medicoExistente = _context.Medicos.Include(u => u.Usuario)
                        .FirstOrDefault(m => m.MedicoId == tabla.MedicoId);
                if (!string.IsNullOrWhiteSpace(tabla.Usuario.Contrasena))
                {
                    UsuarioRepository.ActualizarUsuario(tabla.Usuario);
                }

                medicoExistente.Nlicencia = tabla.Nlicencia;
                medicoExistente.Nombre = tabla.Nombre;
                medicoExistente.Apellido = tabla.Apellido;
                medicoExistente.EspecialidadId = tabla.EspecialidadId;
                medicoExistente.EstadoId = tabla.EstadoId;
                medicoExistente.Usuario = tabla.Usuario;
                
                _context.SaveChanges();
            }
        }

        public void Agregar(Medico tabla)
        {
            _context.Medicos.Add(tabla);
            _context.SaveChanges();
        }

        public void Eliminar(Medico tabla)
        {
            var medicoExistente = _context.Medicos.Include(u => u.Usuario)
                .FirstOrDefault(m => m.MedicoId == tabla.MedicoId);
            if (medicoExistente != null)
            {
                medicoExistente.Usuario.EstadoId = 3;
                UsuarioRepository.DesactivarUsuario(medicoExistente.Usuario);

                medicoExistente.EstadoId = tabla.EstadoId;
                _context.SaveChanges();
            }
        }

        public IList<Medico> Listar()
        {
            return _context.Medicos
                .Include(m => m.Usuario)
                .Include(e => e.Especialidad)
                .Include(e => e.Estado).ToList();
        }
    }
}
