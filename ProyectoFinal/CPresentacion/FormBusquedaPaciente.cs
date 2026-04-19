using System;
using System.Windows.Forms;
using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;

namespace CPresentacion
{
    public partial class FormBusquedaPaciente : Form
    {
        private readonly PacienteRepository _pacienteRepo;
        public Paciente? PacienteSeleccionado { get; private set; }

        public FormBusquedaPaciente()
        {
            InitializeComponent();
            _pacienteRepo = new PacienteRepository();
            CargarPacientes();

            btnBuscar.Click += btnBuscar_Click;
            btnSeleccionar.Click += btnSeleccionar_Click;
            btnCancelar.Click += btnCancelar_Click;
            dgvPacientes.DoubleClick += dgvPacientes_DoubleClick;
        }

        private void CargarPacientes()
        {
            try
            {
                string? buscar = string.IsNullOrWhiteSpace(txtFiltro.Text) ? null : txtFiltro.Text.Trim();
                var (pacientes, _) = _pacienteRepo.Listar(1, 50, buscar);

                dgvPacientes.DataSource = pacientes;
                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            if (dgvPacientes.Columns.Count > 0)
            {
                dgvPacientes.Columns["PacienteId"].HeaderText = "Código";
                dgvPacientes.Columns["Cedula"].HeaderText = "Cédula";
                dgvPacientes.Columns["Nombre"].HeaderText = "Nombre";
                dgvPacientes.Columns["Apellido"].HeaderText = "Apellido";
                dgvPacientes.Columns["FechaNacimiento"].HeaderText = "Fecha Nac.";
                dgvPacientes.Columns["Sexo"].HeaderText = "Sexo";
                dgvPacientes.Columns["Direccion"].Visible = false;
                dgvPacientes.Columns["Seguro"].Visible = false;
                dgvPacientes.Columns["Correo"].Visible = false;
                dgvPacientes.Columns["Turnos"].Visible = false;

                dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPacientes.ReadOnly = true;
                dgvPacientes.MultiSelect = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un paciente", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PacienteSeleccionado = (Paciente)dgvPacientes.SelectedRows[0].DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvPacientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                PacienteSeleccionado = (Paciente)dgvPacientes.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}