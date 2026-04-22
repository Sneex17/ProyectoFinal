using CEntidades.Models;
using Microsoft.EntityFrameworkCore;
using CAccesoDatos.RepositoryPattern;

namespace CNegocio
{
    /// <summary>
    /// Servicio de lógica de negocio para la gestión de médicos.
    /// Provee métodos para agregar, actualizar, listar y eliminar médicos.
    /// </summary>
    public class ServiciosMedicos
    {
        /// <summary>
        /// Agrega un nuevo médico al sistema.
        /// </summary>
        /// <param name="tabla">Entidad del médico a agregar.</param>
        public static void AgregarMedico(Medico tabla)
        {
            var repoMedico = new MedicoRepository();
            repoMedico.Agregar(tabla);
        }

        /// <summary>
        /// Actualiza los datos de un médico existente.
        /// </summary>
        /// <param name="tabla">Entidad del médico con datos actualizados.</param>
        public static void ActualizarMedico(Medico tabla)
        {
            var repoMedico = new MedicoRepository();
            repoMedico.Actualizar(tabla);
        }

        /// <summary>
        /// Lista todos los médicos del sistema.
        /// </summary>
        /// <returns>Lista de médicos.</returns>
        public static IList<Medico> ListarMedicos()
        {
            var repoMedico = new MedicoRepository();
            return repoMedico.Listar();
        }

        /// <summary>
        /// Elimina un médico del sistema.
        /// </summary>
        /// <param name="tabla">Entidad del médico a eliminar.</param>
        public static void EliminarMedico(Medico tabla)
        {
            var repoMedico = new MedicoRepository();
            repoMedico.Eliminar(tabla);
        }
    }
}
