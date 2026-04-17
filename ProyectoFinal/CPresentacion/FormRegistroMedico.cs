using CAccesoDatos.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades.Models;

namespace CPresentacion
{
    public partial class FormRegistroMedico : Form
    {
        public FormRegistroMedico()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var repositoryMedico = new MedicoRepository();
            dgvMedicos.DataSource = repositoryMedico.Listar();

            var repositoryEspecialidades = new EspecialidadesRepositoty();
            cmbEspecialidades.DataSource = repositoryEspecialidades.Listar();
            cmbEspecialidades.ValueMember = "EspecialidadId";
            cmbEspecialidades.DisplayMember = "Nombre";

            var repositoryUsuarios = new UsuariosRepositoty();
            cmbEspecialidades.DataSource = repositoryEspecialidades.Listar();
            cmbUsuarios.ValueMember = "UsuarioId";
            cmbUsuarios.DisplayMember = "Usuario";
        }

        private void BuCrear_Click(object sender, EventArgs e)
        {
            var repository = new MedicoRepository();
            var medico = new Medico()
            {
                Nlicencia = txtNLicencia.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                EspecialidadId = Convert.ToInt32(cmbEspecialidades.SelectedValue),
                UsuarioId = Convert.ToInt32(cmbUsuarios.SelectedValue)
            };
        }
    }
}
