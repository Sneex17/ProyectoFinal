using System;
using System.Windows.Forms;
using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;

namespace CPresentacion
{
    public partial class FormGestionPacientes : Form
    {
        private readonly PacienteRepository _pacienteRepo;
        private int _paginaActual = 1;
        private int _totalPaginas = 1;
        private int _pageSize = 10;

        public FormGestionPacientes()
        {
            InitializeComponent();
            _pacienteRepo = new PacienteRepository();
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            try
            {
                string? buscar = string.IsNullOrWhiteSpace(txtBuscar.Text) ? null : txtBuscar.Text.Trim();
                var (pacientes, totalRegistros) = _pacienteRepo.Listar(_paginaActual, _pageSize, buscar);

                dataGridView1.DataSource = pacientes;

                int totalPages = (int)Math.Ceiling((double)totalRegistros / _pageSize);
                totalPages = totalPages == 0 ? 1 : totalPages;
                _totalPaginas = totalPages;

                lblPagina.Text = $"Página {_paginaActual} de {_totalPaginas}";

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
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["PacienteId"].HeaderText = "Código";
                dataGridView1.Columns["Cedula"].HeaderText = "Cédula";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["FechaNacimiento"].HeaderText = "Fecha Nac.";
                dataGridView1.Columns["Sexo"].HeaderText = "Sexo";
                dataGridView1.Columns["Direccion"].HeaderText = "Dirección";
                dataGridView1.Columns["Seguro"].HeaderText = "Seguro";
                dataGridView1.Columns["Correo"].HeaderText = "Correo";

                dataGridView1.Columns["PacienteId"].Width = 60;
                dataGridView1.Columns["Cedula"].Width = 100;
                dataGridView1.Columns["Nombre"].Width = 120;
                dataGridView1.Columns["Apellido"].Width = 120;
                dataGridView1.Columns["FechaNacimiento"].Width = 90;
                dataGridView1.Columns["Sexo"].Width = 50;
                dataGridView1.Columns["Direccion"].Width = 150;
                dataGridView1.Columns["Seguro"].Width = 100;
                dataGridView1.Columns["Correo"].Width = 150;
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            using var form = new FormDatosPaciente();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _pacienteRepo.Insertar(
                        form.Cedula,
                        form.Nombre,
                        form.Apellido,
                        form.FechaNacimiento,
                        form.Sexo,
                        form.Direccion,
                        form.Seguro,
                        form.Correo
                    );
                    MessageBox.Show("Paciente registrado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPacientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un paciente para editar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var paciente = (Paciente)dataGridView1.SelectedRows[0].DataBoundItem;

            using var form = new FormDatosPaciente(paciente);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _pacienteRepo.Actualizar(
                        paciente.PacienteId,
                        form.Nombre,
                        form.Apellido,
                        form.FechaNacimiento,
                        form.Sexo,
                        form.Direccion,
                        form.Seguro,
                        form.Correo
                    );
                    MessageBox.Show("Paciente actualizado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPacientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un paciente para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("¿Está seguro de eliminar este paciente?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var paciente = (Paciente)dataGridView1.SelectedRows[0].DataBoundItem;
                try
                {
                    var (success, mensaje) = _pacienteRepo.Eliminar(paciente.PacienteId);
                    MessageBox.Show(mensaje, success ? "Éxito" : "Error",
                        MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    CargarPacientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            _paginaActual = 1;
            CargarPacientes();
        }

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            _paginaActual = 1;
            CargarPacientes();
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                _paginaActual--;
                CargarPacientes();
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (_paginaActual < _totalPaginas)
            {
                _paginaActual++;
                CargarPacientes();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            _paginaActual = _totalPaginas;
            CargarPacientes();
        }
    }
}