using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
using CAccesoDatos.RepositoryPattern;

namespace CNegocio
{
    public class ServiciosMedicos
    {
        public static void AgregarMedico(Medico tabla)
        {
            var repoMedico = new MedicoRepository();
            repoMedico.Agregar(tabla);
        }

        public static void ActualizarMedico(Medico tabla)
        {
            var repoMedico = new MedicoRepository();
            repoMedico.Actualizar(tabla);
        }

        public static IList<Medico> ListarMedicos()
        {
            var repoMedico = new MedicoRepository();
            return repoMedico.Listar();
        }

        public static void EliminarMedico(Medico tabla)
        {
            var repoMedico = new MedicoRepository();
            repoMedico.Eliminar(tabla);
        }
    }
}
