using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FormAtencion : Form
    {
        private readonly TurnoRepository _turnoRepo;
        private readonly PacienteRepository _pacienteRepo;
        private Turno? _turnoActual;
        private int? _turnoIdActual;
        private bool _turnoEnAtencion;

        public FormAtencion()
        {
            InitializeComponent();
            _turnoRepo = new TurnoRepository();
            _pacienteRepo = new PacienteRepository();
            _turnoEnAtencion = false;

            Load += FormAtencion_Load;
            btnAtender.Click += btnAtender_Click;
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            if (!SesionUsuario.EsMedico)
            {
                MessageBox.Show("Solo los médicos pueden atender turnos", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAtender.Enabled = false;
                return;
            }

            if (!SesionUsuario.IdRelacionado.HasValue)
            {
                MessageBox.Show("No se encontró el ID del médico", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var turnoEnAtencion = _turnoRepo.ObtenerTurnoEnAtencion(SesionUsuario.IdRelacionado.Value);
            
            if (turnoEnAtencion != null)
            {
                _turnoActual = turnoEnAtencion;
                _turnoIdActual = turnoEnAtencion.TurnoId;
                CargarDatosPaciente(_turnoActual.PacienteId);
                CargarDatosTurno(_turnoActual);
                
                _turnoEnAtencion = true;
                btnAtender.Text = "FINALIZAR ATENCIÓN";
            }
            else
            {
                CargarSiguienteTurno(false);
            }
        }

        private void CargarSiguienteTurno(bool iniciarAhora)
        {
            try
            {
                var turnos = _turnoRepo.ObtenerColaTurnos(SesionUsuario.IdRelacionado, null);
                
                if (turnos.Count > 0)
                {
                    _turnoActual = turnos[0];
                    _turnoIdActual = _turnoActual.TurnoId;
                    
                    if (iniciarAhora && !_turnoEnAtencion)
                    {
                        _turnoRepo.CambiarEstadoTurno(_turnoIdActual!.Value, 2);
                        _turnoEnAtencion = true;
                        btnAtender.Text = "FINALIZAR ATENCIÓN";
                    }
                    else
                    {
                        var estado = _turnoRepo.ObtenerEstadoTurno(_turnoIdActual!.Value);
                        if (estado == 2)
                        {
                            _turnoEnAtencion = true;
                            btnAtender.Text = "FINALIZAR ATENCIÓN";
                        }
                        else
                        {
                            _turnoEnAtencion = false;
                            btnAtender.Text = "INICIAR ATENCIÓN";
                        }
                    }
                    
                    CargarDatosPaciente(_turnoActual.PacienteId);
                    CargarDatosTurno(_turnoActual);
                }
                else
                {
                    LimpiarCampos();
                    label12.Text = "No hay turnos pendientes";
                    btnAtender.Text = "SIN TURNOS";
                    btnAtender.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar turno: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosPaciente(int pacienteId)
        {
            var paciente = _pacienteRepo.ObtenerPorId(pacienteId);
            if (paciente != null)
            {
                lblNombreCompleto.Text = $"{paciente.Nombre} {paciente.Apellido}";
                lblCedula.Text = paciente.Cedula;
                lblEdad.Text = paciente.FechaNacimiento.ToString("dd/MM/yyyy");
                lblSeguro.Text = paciente.Seguro ?? "Sin seguro";
            }
        }

        private void CargarDatosTurno(Turno turno)
        {
            txtObservaciones.Text = turno.Observaciones ?? "Sin observaciones";
            
            lblPrioridad.Text = turno.Prioridad?.Nombre ?? "Normal";
            
            var colorPrioridad = turno.PrioridadId switch
            {
                4 => Color.Red,
                1 => Color.Gold,
                2 => Color.Green,
                3 => Color.Gray,
                _ => Color.Black
            };
            lblPrioridad.ForeColor = colorPrioridad;
        }

        private void LimpiarCampos()
        {
            lblNombreCompleto.Text = "-";
            lblCedula.Text = "-";
            lblEdad.Text = "-";
            lblSeguro.Text = "-";
            txtObservaciones.Text = "-";
            lblPrioridad.Text = "-";
            _turnoActual = null;
            _turnoIdActual = null;
            _turnoEnAtencion = false;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (!_turnoIdActual.HasValue)
            {
                MessageBox.Show("No hay turno seleccionado", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int estadoActual = _turnoRepo.ObtenerEstadoTurno(_turnoIdActual.Value);

            if (estadoActual == 1)
            {
                IniciarAtencion();
            }
            else if (estadoActual == 2)
            {
                FinalizarAtencion();
            }
            else
            {
                MessageBox.Show("Este turno ya fue atendido o cancelado", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSiguienteTurno(false);
            }
        }

        private void IniciarAtencion()
        {
            try
            {
                if (_turnoRepo.ValidarMedicoOcupado(SesionUsuario.IdRelacionado!.Value))
                {
                    MessageBox.Show("Ya tiene un turno en atención", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _turnoRepo.CambiarEstadoTurno(_turnoIdActual!.Value, 2);
                
                MessageBox.Show("Turno en atención", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _turnoEnAtencion = true;
                btnAtender.Text = "FINALIZAR ATENCIÓN";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalizarAtencion()
        {
            try
            {
                var (nuevoEstado, _) = _turnoRepo.CambiarEstadoTurno(_turnoIdActual!.Value, 3);
                
                var resultado = MessageBox.Show(
                    "¿Desea iniciar el siguiente turno?",
                    "Turno Finalizado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                _turnoEnAtencion = false;

                if (resultado == DialogResult.Yes)
                {
                    CargarSiguienteTurno(true);
                }
                else
                {
                    LimpiarCampos();
                    label12.Text = "Sin turno activo";
                    btnAtender.Text = "CARGAR SIGUIENTE";
                    btnAtender.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}