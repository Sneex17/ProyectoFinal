using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using CEntidades.TurnoDecorator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FormColaTurno : Form
    {
        private readonly TurnoRepository _turnoRepo;
        private readonly MedicoRepository _medicoRepo;
        private List<Turno> _turnos;

        public FormColaTurno()
        {
            InitializeComponent();
            _turnoRepo = new TurnoRepository();
            _medicoRepo = new MedicoRepository();
            _turnos = new List<Turno>();

            Load += FormColaTurno_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void FormColaTurno_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            CargarColaTurnos();
        }

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

                _turnos = _turnoRepo.ObtenerColaTurnos(medicoId, especialidadId);

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
            txtFiltro.Clear();
            CargarColaTurnos();
        }

        private void foreverGroupBox1_Click(object sender, EventArgs e)
        {
        }
    }
}