namespace CEntidades.Models
{
    public static class SesionUsuario
    {
        public static int UsuarioId { get; private set; }
        public static string NombreUsuario { get; private set; } = string.Empty;
        public static int RolId { get; private set; }
        public static string RolNombre { get; private set; } = string.Empty;
        public static int EstadoId { get; private set; }
        public static int? IdRelacionado { get; private set; }

        public static bool EstaLogueado => UsuarioId > 0;

        public static void IniciarSesion(int usuarioId, string nombreUsuario, int rolId, string rolNombre, int estadoId, int? idRelacionado)
        {
            UsuarioId = usuarioId;
            NombreUsuario = nombreUsuario;
            RolId = rolId;
            RolNombre = rolNombre;
            EstadoId = estadoId;
            IdRelacionado = idRelacionado;
        }

        public static void CerrarSesion()
        {
            UsuarioId = 0;
            NombreUsuario = string.Empty;
            RolId = 0;
            RolNombre = string.Empty;
            EstadoId = 0;
            IdRelacionado = null;
        }

        public static bool EsAdmin => RolId == 1;
        public static bool EsMedico => RolId == 2;
        public static bool EsRecepcionista => RolId == 3;
        public static bool EsPaciente => RolId == 4;
    }
}