using CEntidades.Models;
using CAccesoDatos.RepositoryPattern;

namespace CNegocio
{
    /// <summary>
    /// Servicio de lógica de negocio para la gestión de recepcionistas.
    /// Provee métodos para agregar, actualizar, listar y eliminar recepcionistas.
    /// </summary>
    public class ServicioRecepcionista
    {
        /// <summary>
        /// Agrega un nuevo recepcionista al sistema.
        /// </summary>
        /// <param name="tabla">Entidad del recepcionista a agregar.</param>
        public static void AgregarRecepcionista(Recepcionista tabla)
        {
            var repoRecepcionista = new RecepcionistaRepository();
            repoRecepcionista.Agregar(tabla);
        }

        /// <summary>
        /// Actualiza los datos de un recepcionista existente.
        /// </summary>
        /// <param name="tabla">Entidad del recepcionista con datos actualizados.</param>
        public static void ActualizarRecepcionista(Recepcionista tabla)
        {
            var repoRecepcionista = new RecepcionistaRepository();
            repoRecepcionista.Actualizar(tabla);
        }

        /// <summary>
        /// Lista todos los recepcionistas del sistema.
        /// </summary>
        /// <returns>Lista de recepcionistas.</returns>
        public static IList<Recepcionista> ListarRecepcionistas()
        {
            var repoRecepcionista = new RecepcionistaRepository();
            return repoRecepcionista.Listar();
        }

        /// <summary>
        /// Elimina un recepcionista del sistema.
        /// </summary>
        /// <param name="tabla">Entidad del recepcionista a eliminar.</param>
        public static void EliminarRecepcionista(Recepcionista tabla)
        {
            var repoRecepcionista = new RecepcionistaRepository();
            repoRecepcionista.Eliminar(tabla);
        }
    }
}
