using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using CEntidades.Models;

namespace CPresentacion
{
    public partial class FormMenuPrincipal : Form
    {
        private static IconMenuItem? menuActivo = null;
        private static Form? formActivo = null;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            ConfigurarMenuPorRol();
            MostrarBienvenida();
        }

        private void ConfigurarMenuPorRol()
        {
            if (!SesionUsuario.EstaLogueado) return;

            switch (SesionUsuario.RolId)
            {
                case 1:
                    ConfigurarMenuAdmin();
                    break;
                case 2:
                    ConfigurarMenuMedico();
                    break;
                case 3:
                    ConfigurarMenuRecepcionista();
                    break;
                case 4:
                    ConfigurarMenuPaciente();
                    break;
            }
        }

        private void ConfigurarMenuAdmin()
        {
            menuRegistrarTurno.Visible = true;
            menuRegistrarMedico.Visible = true;
            menuRegistrarEspecialidades.Visible = true;
            menuRegistroRecepcionista.Visible = true;
            menuEstadisticas.Visible = true;
            menuHistorialTurno.Visible = true;
            menuHistorialPacientes.Visible = false;
            menuColaTurnos.Visible = true;
            menuAtencion.Visible = true;
            menuGestionPacientes.Visible = true;
            menuCerrarSesion.Visible = true;
        }

        private void ConfigurarMenuMedico()
        {
            menuRegistrarTurno.Visible = false;
            menuRegistrarMedico.Visible = false;
            menuRegistrarEspecialidades.Visible = false;
            menuRegistroRecepcionista.Visible = false;
            menuEstadisticas.Visible = false;
            menuHistorialTurno.Visible = false;
            menuHistorialPacientes.Visible = true;
            menuColaTurnos.Visible = true;
            menuAtencion.Visible = true;
            menuGestionPacientes.Visible = false;
            menuCerrarSesion.Visible = true;
        }

        private void ConfigurarMenuRecepcionista()
        {
            menuRegistrarTurno.Visible = true;
            menuRegistrarMedico.Visible = false;
            menuRegistrarEspecialidades.Visible = false;
            menuRegistroRecepcionista.Visible = false;
            menuEstadisticas.Visible = false;
            menuHistorialTurno.Visible = false;
            menuHistorialPacientes.Visible = false;
            menuColaTurnos.Visible = true;
            menuAtencion.Visible = false;
            menuGestionPacientes.Visible = true;
            menuCerrarSesion.Visible = true;
        }

        private void ConfigurarMenuPaciente()
        {
            menuRegistrarTurno.Visible = false;
            menuRegistrarMedico.Visible = false;
            menuRegistrarEspecialidades.Visible = false;
            menuRegistroRecepcionista.Visible = false;
            menuEstadisticas.Visible = false;
            menuHistorialTurno.Visible = false;
            menuHistorialPacientes.Visible = false;
            menuColaTurnos.Visible = true;
            menuAtencion.Visible = false;
            menuGestionPacientes.Visible = false;
            menuCerrarSesion.Visible = true;
        }

        private void MostrarBienvenida()
        {
            lblBienvenido.Text = $"Bienvenido, {SesionUsuario.NombreUsuario} ({SesionUsuario.RolNombre})";
        }

        private void AbrirFormulario(IconMenuItem menu, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.FromArgb(88, 97, 88);
                menuActivo.ForeColor = Color.FromArgb(240, 241, 236);
            }

            menu.BackColor = Color.FromArgb(88, 97, 88);
            menu.ForeColor = Color.FromArgb(240, 241, 236);
            menuActivo = menu;

            if (formActivo != null) formActivo.Close();

            lblBienvenido.Visible = false;
            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.FromArgb(218, 248, 226);

            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Show();
        }

        private void menuRegistrarTurno_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuRegistrarTurno, new FormRegistroTurno());
        }

        private void menuRegistrarMedico_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuRegistrarMedico, new FormRegistroMedico());
        }

        private void menuRegistrarEspecialidades_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuRegistrarEspecialidades, new FormRegistroEspecialidades());
        }

        private void menuRegistroRecepcionista_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuRegistroRecepcionista, new FormRegistroRecepcionista());
        }

        private void menuEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuEstadisticas, new FormEstadisticas());
        }

        private void menuHistorialPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuHistorialPacientes, new FormHistorialDePacientes());
        }

        private void menuColaTurnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuColaTurnos, new FormColaTurno());
        }

        private void menuAtencion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAtencion, new FormAtencion());
        }

        private void menuGestionPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuGestionPacientes, new FormGestionPacientes());
        }

        private void menuHistorialTurno_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menuHistorialPacientes, new FormHistorialDePacientes());

        }

        private void menuCerrarSesion_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SesionUsuario.CerrarSesion();
                this.Close();
                Application.Restart();
            }
        }
    }
}