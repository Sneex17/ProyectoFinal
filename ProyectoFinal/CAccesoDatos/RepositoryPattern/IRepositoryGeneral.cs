using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAccesoDatos.RepositoryPattern
{
    /// <summary>
    /// Interfaz genérica para el patrón Repository.
    /// Define las operaciones CRUD básicas para cualquier entidad.
    /// </summary>
    /// <typeparam name="T">Tipo de entidad.</typeparam>
    internal interface IRepositoryGeneral<T>
    {
        /// <summary>
        /// Lista todas las entidades.
        /// </summary>
        IList<T> Listar();
        
        /// <summary>
        /// Agrega una nueva entidad.
        /// </summary>
        void Agregar(T tabla);
        
        /// <summary>
        /// Elimina una entidad.
        /// </summary>
        void Eliminar(T tabla);
        
        /// <summary>
        /// Actualiza una entidad existente.
        /// </summary>
        void Actualizar(T tabla);
    }
}
