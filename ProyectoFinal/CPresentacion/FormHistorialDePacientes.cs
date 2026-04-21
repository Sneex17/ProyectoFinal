using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
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
    public partial class FormHistorialDePacientes : Form
    {

        private readonly TurnoRepository _turnoRepo;
        private readonly EspecialidadesRepositoty _especialidadRepo;
        private MedicoRepository _medicoRepo;
        public FormHistorialDePacientes()
        {
            InitializeComponent();
            _turnoRepo = new TurnoRepository();
            _especialidadRepo = new EspecialidadesRepositoty();
            _medicoRepo = new MedicoRepository();
        }

        private void FormHistorialDePacientes_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarSegunRol();
            CargarDatos();
        }

        private void CargarCombos()
        {
           
            var especialidades = new List<Especialidade> { new Especialidade { EspecialidadId = 0, Nombre = "Todas" } };
            especialidades.AddRange(_especialidadRepo.Listar());
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.DisplayMember = "Nombre";
            cmbEspecialidades.ValueMember = "EspecialidadId";

          
            var estados = new List<EstadoTurno> { new EstadoTurno { EstadoTurnoId = 0, Nombre = "Todos" } };
            estados.AddRange(_turnoRepo.ListarEstadosTurno());
            cmbEstadoTurno.DataSource = estados;
            cmbEstadoTurno.DisplayMember = "Nombre";
            cmbEstadoTurno.ValueMember = "EstadoTurnoId";
        }

        private void ConfigurarSegunRol()
        {
            if (SesionUsuario.EsMedico)
            {
                label4.Visible = false;
                label6.Text = "Historial del Paciente";
                txtMedico.Visible = false;
                txtMedico.Enabled = false;

                // Opcional: obtener y mostrar el nombre del médico actual
                //var medicoActual = _medicoRepo.Listar().FirstOrDefault(m => m.UsuarioId == SesionUsuario.UsuarioId);
                //if (medicoActual != null)
                //{
                //    txtMedico.Text = medicoActual.NombreCompleto;
                //}
                label2.Visible = false;
                cmbEstadoTurno.SelectedValue = 3;
                cmbEstadoTurno.Visible = false;
                foreverGroupBox3.Visible = false;
            }
            else if (SesionUsuario.EsAdmin)
            {
                label4.Visible = true;
                label6.Text = "Historial de Turnos";
                txtMedico.Visible = true;
                txtMedico.Enabled = true;
                label2.Visible = true;
                cmbEstadoTurno.Visible = true;
            }
            else
            {
               
                MessageBox.Show("No tiene permisos para ver esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void CargarDatos()
        {
            string? pacienteNombre = string.IsNullOrWhiteSpace(txtPaciente.Text) ? null : txtPaciente.Text;
            string? medicoNombre = string.IsNullOrWhiteSpace(txtMedico.Text) || !txtMedico.Enabled ? null : txtMedico.Text;
            DateTime? fechaInicio = dtpFecha.Checked ? dtpFecha.Value.Date : (DateTime?)null;
            int? especialidadId = (int)cmbEspecialidades.SelectedValue == 0 ? null : (int)cmbEspecialidades.SelectedValue;
            int? estadoTurnoId = (int)cmbEstadoTurno.SelectedValue == 0 ? null : (int)cmbEstadoTurno.SelectedValue;

           

            int? medicoIdLogin = SesionUsuario.EsMedico ? SesionUsuario.IdRelacionado : null;

         
            var historial = _turnoRepo.FiltrarHistorial(pacienteNombre, medicoNombre, fechaInicio, especialidadId, estadoTurnoId, medicoIdLogin);

           
            dgvHistorial.DataSource = historial;
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            if (dgvHistorial.Columns.Count == 0) return;

           
            dgvHistorial.Columns["TurnoId"].Visible = false;
            dgvHistorial.Columns["PacienteId"].Visible = false;
            dgvHistorial.Columns["Observaciones"].Visible = false;

            if (SesionUsuario.EsMedico)
            {
                dgvHistorial.Columns["NumeroTurno"].Visible = false;
                dgvHistorial.Columns["FechaHoraFin"].Visible = false;
                dgvHistorial.Columns["FechaHoraInicio"].HeaderText = "Fecha de Atención";
            }


            dgvHistorial.Columns["NumeroTurno"].HeaderText = "N° Turno";
            dgvHistorial.Columns["Especialidad"].HeaderText = "Especialidad";
            dgvHistorial.Columns["FechaHoraInicio"].HeaderText = "Inicio Atención";
            dgvHistorial.Columns["FechaHoraFin"].HeaderText = "Fin Atención";

          
            dgvHistorial.Columns["FechaHoraInicio"].DefaultCellStyle.Format = "g";
            dgvHistorial.Columns["FechaHoraFin"].DefaultCellStyle.Format = "g";
            dgvHistorial.Columns["FechaHoraCreacion"].Visible = false; 

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPaciente.Clear();
            if (SesionUsuario.EsAdmin) txtMedico.Clear(); 

            dtpFecha.Value = DateTime.Now;
            dtpFecha.Checked = false; 
            cmbEspecialidades.SelectedValue = 0;
            cmbEstadoTurno.SelectedValue = 0;

            if (SesionUsuario.EsMedico)
            {
                cmbEstadoTurno.SelectedValue = 3;
            }

            CargarDatos();
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!SesionUsuario.EsMedico || e.RowIndex < 0) return;

            var filaSeleccionada = dgvHistorial.Rows[e.RowIndex].DataBoundItem as TurnoHistorialDto;
            if (filaSeleccionada == null) return;

            var formob = new FormObservacion(
                filaSeleccionada.Prioridad,
                filaSeleccionada.FechaHoraFin,
                filaSeleccionada.Observaciones,
                filaSeleccionada.Paciente
            )
            {

            };
            formob.ShowDialog();
        }
    }
}
