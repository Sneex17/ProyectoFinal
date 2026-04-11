using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CAccesoDatos.RepositoryPattern
{
    internal interface IRepositoryGeneral<T>
    {
        IList<T> Listar();
        void Agregar(T tabla);
        void Eliminar(T tabla);
        void Actualizar(T tabla);
    }
}
