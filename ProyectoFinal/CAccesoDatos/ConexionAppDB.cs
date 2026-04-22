using Microsoft.Extensions.Configuration;

namespace CAccesoDatos
{
    /// <summary>
    /// Provee acceso centralizado a la cadena de conexión de la base de datos de la aplicación.
    /// Implementa un patrón de configuración estática que debe ser inicializado una única vez
    /// al arranque de la aplicación antes de ser utilizado.
    /// </summary>
    /// <remarks>
    /// El método <see cref="Instanciar"/> debe invocarse durante el inicio de la aplicación
    /// (por ejemplo, en <c>Program.cs</c>) antes de realizar cualquier acceso a
    /// <see cref="ConnectionString"/>. De lo contrario, se lanzará una excepción.
    /// <para>
    /// Ejemplo de uso en <c>Program.cs</c>:
    /// <code>
    /// ConexionAppDB.Instanciar(builder.Configuration);
    /// </code>
    /// </para>
    /// </remarks>
    public class ConexionAppDB
    {
        /// <summary>
        /// Instancia de configuración inyectada al inicio de la aplicación.
        /// Permanece nula hasta que <see cref="Instanciar"/> sea invocado.
        /// </summary>
        private static IConfiguration? _configuration;
        /// <summary>
        /// Inicializa la clase con la configuración de la aplicación, habilitando
        /// el acceso posterior a la cadena de conexión.
        /// Este método debe llamarse una única vez durante el arranque de la aplicación.
        /// </summary>
        /// <param name="configuration">
        /// La instancia de <see cref="IConfiguration"/> provista por el contenedor
        /// de dependencias de la aplicación.
        /// </param>
        public static void Instanciar(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Obtiene la cadena de conexión a la base de datos definida bajo la clave
        /// <c>"ConexionDB"</c> en el archivo de configuración (<c>appsettings.json</c>).
        /// </summary>
        /// <value>
        /// La cadena de conexión configurada para el acceso a la base de datos.
        /// </value>
        /// <exception cref="InvalidOperationException">
        /// Se lanza si <see cref="Instanciar"/> no fue invocado previamente,
        /// o si la clave <c>"ConexionDB"</c> no existe en la configuración.
        /// </exception>
        public static string ConnectionString =>
            _configuration?.GetConnectionString("ConexionDB")
            ?? throw new InvalidOperationException("ConnectionString no configurada.");
    }
}
