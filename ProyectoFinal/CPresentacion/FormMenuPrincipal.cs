using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FormMenuPrincipal : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formActivo = null;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.FromArgb(88, 97, 88);
                menuActivo.ForeColor = Color.FromArgb(240, 241, 236);
            }

            //lblWelcome.Visible = false;
            //lblRole.Visible = false;
            menu.BackColor = Color.FromArgb(88, 97, 88);
            menu.ForeColor = Color.FromArgb(240, 241, 236);
            menuActivo = menu;

            if (formActivo != null) formActivo.Close();

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.FromArgb(218, 248, 226);

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
            AbrirFormulario (menuHistorialPacientes, new FormHistorialDePacientes());
        }
    }
}
