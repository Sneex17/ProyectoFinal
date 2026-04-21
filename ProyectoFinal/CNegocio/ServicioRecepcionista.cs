using CEntidades.Models;
using CAccesoDatos.RepositoryPattern;

namespace CNegocio
{
    public class ServicioRecepcionista
    {
        public static void AgregarRecepcionista(Recepcionista tabla)
        {
            var repoRecepcionista = new RecepcionistaRepository();
            repoRecepcionista.Agregar(tabla);
        }
        public static void ActualizarRecepcionista(Recepcionista tabla)
        {
            var repoRecepcionista = new RecepcionistaRepository();
            repoRecepcionista.Actualizar(tabla);
        }
        public static IList<Recepcionista> ListarRecepcionistas()
        {
            var repoRecepcionista = new RecepcionistaRepository();
            return repoRecepcionista.Listar();
        }
        public static void EliminarRecepcionista(Recepcionista tabla)
        {
            var repoRecepcionista = new RecepcionistaRepository();
            repoRecepcionista.Eliminar(tabla);
        }
    }
}
