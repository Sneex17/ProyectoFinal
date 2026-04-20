using System.Security.Cryptography;
using System.Text;
using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;

namespace CPresentacion
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            kryptonButton1.Click += btnIngresar_Click;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtNombreEspecialidad.Text.Trim();
                string contrasena = txtDescripcion.Text;

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
                {
                    MessageBox.Show("Por favor ingrese usuario y contraseña", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashContrasena = HashPassword(contrasena);

                var repo = new UsuarioRepository();
                var resultado = repo.ValidarLoginConRol(usuario, hashContrasena);

                if (resultado.HasValue)
                {
                    var (usuarioId, nombreUsuario, rolId, rolNombre, estadoId, idRelacionado) = resultado.Value;

                    if (estadoId != 1)
                    {
                        MessageBox.Show("Usuario inactivo. Contacte al administrador", "Acceso denegado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    SesionUsuario.IniciarSesion(usuarioId, nombreUsuario, rolId, rolNombre, estadoId, idRelacionado);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Clear();
                    txtDescripcion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void parrotGroupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}