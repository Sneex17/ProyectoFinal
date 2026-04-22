using System;
using System.Drawing;
using System.Windows.Forms;
using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using CNegocio;

namespace CPresentacion
{
    /// <summary>
    /// Formulario para el registro de nuevos turnos.
    /// </summary>
    public partial class FormRegistroTurno : Form
    {
        private readonly PacienteRepository _pacienteRepo;
        private readonly MedicoRepository _medicoRepo;
        private readonly RecepcionistaRepository _recepcionistaRepo;
        private readonly TurnoRepository _turnoRepo;
        private int prioridadSeleccionada = 0;
        private int? _pacienteIdSeleccionado;

        public FormRegistroTurno()
        {
            InitializeComponent();
            _pacienteRepo = new PacienteRepository();
            _medicoRepo = new MedicoRepository();
            _recepcionistaRepo = new RecepcionistaRepository();
            _turnoRepo = new TurnoRepository();

            InicializarPorRol();
            BuCrear.Click += btnAceptar_Click;
        }

        /// <summary>
        /// Inicializa los campos según el rol del usuario logueado.
        /// </summary>
        private void InicializarPorRol()
        {
            if (SesionUsuario.EsPaciente && SesionUsuario.IdRelacionado.HasValue)
            {
                txtNombrePaciente.Text = $"Paciente ID: {SesionUsuario.IdRelacionado}";
                txtNombrePaciente.Enabled = false;
                btnBuscar.Visible = false;
                _pacienteIdSeleccionado = SesionUsuario.IdRelacionado;
            }
            else
            {
                btnBuscar.Visible = true;
                txtNombrePaciente.Enabled = false;
            }

            CargarMedicos();
            CargarRecepcionistas();
        }

        /// <summary>
        /// Carga la lista de recepcionistas en el combobox.
        /// </summary>
        private void CargarRecepcionistas()
        {
            try
            {
                var recepcionistas = _recepcionistaRepo.Listar();
                cmbRecepcionista.DataSource = recepcionistas;
                cmbRecepcionista.DisplayMember = "Nombre";
                cmbRecepcionista.ValueMember = "RecepcionistaId";

                if (SesionUsuario.EsRecepcionista && SesionUsuario.IdRelacionado.HasValue)
                {
                    cmbRecepcionista.SelectedValue = SesionUsuario.IdRelacionado;
                    cmbRecepcionista.Enabled = false;
                }
                else if (SesionUsuario.EsAdmin)
                {
                    cmbRecepcionista.Enabled = true;
                }
                else
                {
                    cmbRecepcionista.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar recepcionistas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMedicos()
        {
            try
            {
                var medicos = _medicoRepo.Listar();
                cmbMedico.DataSource = medicos;
                cmbMedico.DisplayMember = "NombreCompleto";
                cmbMedico.ValueMember = "MedicoId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambiarColores()
        {
            btnAlta.StateCommon.Back.Color1 = Color.White;
            btnMedia.StateCommon.Back.Color1 = Color.White;
            btnBaja.StateCommon.Back.Color1 = Color.White;
            btnUrgente.StateCommon.Back.Color1 = Color.White;

            switch (prioridadSeleccionada)
            {
                case 1:
                    btnAlta.StateCommon.Back.Color1 = Color.FromArgb(255, 248, 234);
                    break;
                case 2:
                    btnMedia.StateCommon.Back.Color1 = Color.Honeydew;
                    break;
                case 3:
                    btnBaja.StateCommon.Back.Color1 = Color.WhiteSmoke;
                    break;
                case 4:
                    btnUrgente.StateCommon.Back.Color1 = Color.FromArgb(248, 232, 232);
                    break;
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            try
            {
                prioridadSeleccionada = 3;
                CambiarColores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                prioridadSeleccionada = 2;
                CambiarColores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                prioridadSeleccionada = 1;
                CambiarColores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUrgente_Click(object sender, EventArgs e)
        {
            try
            {
                prioridadSeleccionada = 4;
                CambiarColores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
}
        
        /// <summary>
        /// Maneja el clic en el botón de crear turno.
        /// Valida los datos y crea el turno en la base de datos.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_pacienteIdSeleccionado.HasValue)
                {
                    MessageBox.Show("Debe seleccionar un paciente", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbMedico.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un médico", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (prioridadSeleccionada == 0)
                {
                    MessageBox.Show("Debe seleccionar una prioridad", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int pacienteId = _pacienteIdSeleccionado.Value;
                int medicoId = (int)cmbMedico.SelectedValue;
                
                int recepcionistaId;
                if (cmbRecepcionista.Enabled && cmbRecepcionista.SelectedValue != null)
                {
                    recepcionistaId = (int)cmbRecepcionista.SelectedValue;
                }
                else
                {
                    recepcionistaId = SesionUsuario.IdRelacionado ?? 1;
                }
                
                string? observaciones = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text;

                var (turnoId, numeroTurno, mensaje) = ServiciosTurnos.CrearTunos(
                    pacienteId, medicoId, recepcionistaId, prioridadSeleccionada, observaciones);

                if (turnoId > 0)
                {
                    MessageBox.Show($"Turno #{numeroTurno} creado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear turno: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombrePaciente.Clear();
            txtDescripcion.Clear();
            cmbMedico.SelectedIndex = -1;
            prioridadSeleccionada = 0;
            CambiarColores();
            _pacienteIdSeleccionado = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using var form = new FormBusquedaPaciente();
            if (form.ShowDialog() == DialogResult.OK && form.PacienteSeleccionado != null)
            {
                _pacienteIdSeleccionado = form.PacienteSeleccionado.PacienteId;
                txtNombrePaciente.Text = $"{form.PacienteSeleccionado.Nombre} {form.PacienteSeleccionado.Apellido}";
            }
        }
    }
}