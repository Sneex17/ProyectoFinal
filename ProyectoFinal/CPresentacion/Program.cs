using Microsoft.Extensions.Configuration;
using CAccesoDatos;
using CEntidades.Models;

namespace CPresentacion
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            ConexionAppDB.Instanciar(configuration);

            ApplicationConfiguration.Initialize();

            Application.Run(new FormLogIn());

            if (SesionUsuario.EstaLogueado)
            {
                Application.Run(new FormMenuPrincipal());
            }
        }
    }
}