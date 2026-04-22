using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using CEntidades.TurnoDecorator;
using CNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPresentacion
{
    /// <summary>
    /// Formulario para visualizar y gestionar la cola de turnos.
    /// </summary>
    public partial class FormColaTurno : Form
    {
        private readonly ServiciosTurnos _turnoServicio = new ServiciosTurnos();
        private List<Turno> _turnos;

        public FormColaTurno()
        {
            InitializeComponent();
            _turnos = new List<Turno>();

            Load += FormColaTurno_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            dgvTurnos.SelectionChanged += dgvTurnos_SelectionChanged;
            btnCambiarPrioridad.Click += btnCambiarPrioridad_Click;
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// Inicializa los filtros y carga la cola de turnos.
        /// </summary>
        private void FormColaTurno_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            CargarPrioridades();
            MostrarPanelPrioridad();
            CargarColaTurnos();
        }

        /// <summary>
        /// Muestra u oculta el panel de cambio de prioridad según el rol del usuario.
        /// </summary>
        private void MostrarPanelPrioridad()
        {
            if (SesionUsuario.EsRecepcionista || SesionUsuario.EsAdmin)
            {
                grpCambiarPrioridad.Visible = true;
                cmbNuevaPrioridad.Enabled = false;
                btnCambiarPrioridad.Enabled = false;
            }
        }

        private void CargarPrioridades()
        {
            var prioridades = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(4, "Urgente"),
                new KeyValuePair<int, string>(1, "Alta"),
                new KeyValuePair<int, string>(2, "Media"),
                new KeyValuePair<int, string>(3, "Baja")
            };
            cmbNuevaPrioridad.DataSource = prioridades;
            cmbNuevaPrioridad.DisplayMember = "Value";
            cmbNuevaPrioridad.ValueMember = "Key";
        }

        private int? _turnoIdSeleccionado;

        private void dgvTurnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTurnos.SelectedRows.Count > 0 && grpCambiarPrioridad.Visible)
            {
                var fila = dgvTurnos.SelectedRows[0];
                _turnoIdSeleccionado = _turnos[fila.Index].TurnoId;
                cmbNuevaPrioridad.Enabled = true;
                btnCambiarPrioridad.Enabled = true;
            }
            else
            {
                _turnoIdSeleccionado = null;
                if (grpCambiarPrioridad.Visible)
                {
                    cmbNuevaPrioridad.Enabled = false;
                    btnCambiarPrioridad.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Maneja el clic en el botón de cambio de prioridad.
        /// Actualiza la prioridad del turno seleccionado.
        /// </summary>
        private void btnCambiarPrioridad_Click(object sender, EventArgs e)
        {
            if (!_turnoIdSeleccionado.HasValue)
            {
                MessageBox.Show("Seleccione un turno primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbNuevaPrioridad.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una prioridad.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int nuevaPrioridadId = (int)cmbNuevaPrioridad.SelectedValue;
                bool resultado = _turnoServicio.CambiarPrioridadTurno(_turnoIdSeleccionado.Value, nuevaPrioridadId);

                if (resultado)
                {
                    MessageBox.Show("Prioridad actualizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarColaTurnos();
                    cmbNuevaPrioridad.Enabled = false;
                    btnCambiarPrioridad.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al actualizar la prioridad.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga las especialidades en el combobox.
        /// </summary>
        private void CargarEspecialidades()
        {
            try
            {
                var especialidadRepo = new EspecialidadesRepositoty();
                var especialidades = especialidadRepo.Listar();
                cmbEspecialidades.DataSource = especialidades;
                cmbEspecialidades.DisplayMember = "Nombre";
                cmbEspecialidades.ValueMember = "EspecialidadId";
                cmbEspecialidades.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar especialidades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarColaTurnos()
        {
            try
            {
                int? medicoId = null;
                int? especialidadId = null;

                if (SesionUsuario.EsMedico && SesionUsuario.IdRelacionado.HasValue)
                {
                    medicoId = SesionUsuario.IdRelacionado;
                }
                else if (cmbEspecialidades.SelectedValue != null)
                {
                    especialidadId = (int)cmbEspecialidades.SelectedValue;
                }

                _turnos = ServiciosTurnos.ColaDeTurnos(medicoId, especialidadId);

                dgvTurnos.DataSource = null;
                dgvTurnos.Columns.Clear();
                dgvTurnos.Rows.Clear();

                dgvTurnos.Columns.Add("Posicion", "Posición");
                dgvTurnos.Columns.Add("NumeroTurno", "N°");
                dgvTurnos.Columns.Add("Paciente", "Paciente");
                dgvTurnos.Columns.Add("Medico", "Médico");
                dgvTurnos.Columns.Add("Prioridad", "Prioridad");
                dgvTurnos.Columns.Add("Hora", "Hora");

                dgvTurnos.Columns["Posicion"].Width = 60;
                dgvTurnos.Columns["NumeroTurno"].Width = 40;
                dgvTurnos.Columns["Paciente"].Width = 150;
                dgvTurnos.Columns["Medico"].Width = 150;
                dgvTurnos.Columns["Prioridad"].Width = 80;
                dgvTurnos.Columns["Hora"].Width = 70;

                foreach (var turno in _turnos)
                {
                    int rowIndex = dgvTurnos.Rows.Add();

                    dgvTurnos.Rows[rowIndex].Cells["Posicion"].Value = rowIndex + 1;
                    dgvTurnos.Rows[rowIndex].Cells["NumeroTurno"].Value = turno.NumeroTurno;
                    dgvTurnos.Rows[rowIndex].Cells["Paciente"].Value = turno.Paciente?.NombreCompleto ?? "";
                    dgvTurnos.Rows[rowIndex].Cells["Medico"].Value = turno.Medico?.NombreCompleto ?? "";
                    dgvTurnos.Rows[rowIndex].Cells["Prioridad"].Value = turno.Prioridad?.Nombre ?? "";
                    dgvTurnos.Rows[rowIndex].Cells["Hora"].Value = turno.FechaHoraCreacion?.ToString("HH:mm") ?? "";

                    var turnoDecorado = TurnoDecoradorFactory.Decorar(turno);
                    dgvTurnos.Rows[rowIndex].DefaultCellStyle.BackColor = turnoDecorado.GetColor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar turnos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarColaTurnos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEspecialidades.SelectedIndex = -1;
            CargarColaTurnos();
        }

        private void foreverGroupBox1_Click(object sender, EventArgs e)
        {
        }
    }
}