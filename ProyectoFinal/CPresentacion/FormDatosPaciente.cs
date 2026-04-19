using System;
using System.Windows.Forms;
using CEntidades.Models;

namespace CPresentacion
{
    public partial class FormDatosPaciente : Form
    {
        public string Cedula { get; private set; } = string.Empty;
        public string Nombre { get; private set; } = string.Empty;
        public string Apellido { get; private set; } = string.Empty;
        public DateOnly FechaNacimiento { get; private set; }
        public string Sexo { get; private set; } = string.Empty;
        public string? Direccion { get; private set; }
        public string? Seguro { get; private set; }
        public string? Correo { get; private set; }

        private bool _esEdicion;

        public FormDatosPaciente(Paciente? paciente = null)
        {
            InitializeComponent();
            _esEdicion = paciente != null;

            if (_esEdicion && paciente != null)
            {
                txtCedula.Text = paciente.Cedula;
                txtCedula.Enabled = false;
                txtNombre.Text = paciente.Nombre;
                txtApellido.Text = paciente.Apellido;
                dtpFechaNacimiento.Value = paciente.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
                cmbSexo.SelectedItem = paciente.Sexo;
                txtDireccion.Text = paciente.Direccion ?? "";
                txtSeguro.Text = paciente.Seguro ?? "";
                txtCorreo.Text = paciente.Correo ?? "";
                this.Text = "Editar Paciente";
            }
            else
            {
                this.Text = "Nuevo Paciente";
                cmbSexo.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el sexo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cedula = txtCedula.Text.Trim();
            Nombre = txtNombre.Text.Trim();
            Apellido = txtApellido.Text.Trim();
            FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);
            Sexo = cmbSexo.SelectedItem.ToString()!;
            Direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim();
            Seguro = string.IsNullOrWhiteSpace(txtSeguro.Text) ? null : txtSeguro.Text.Trim();
            Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}