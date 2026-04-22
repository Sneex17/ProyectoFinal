using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using CNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FormHistorialDeTurno : Form
    {

        public FormHistorialDeTurno()
        {
            InitializeComponent();
            Load += FormHistorialDeTurno_Load;
        }

        private void FormHistorialDeTurno_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            try
            {
                List<Turno> turnos;

                if (SesionUsuario.EsPaciente && SesionUsuario.IdRelacionado.HasValue)
                {
                    turnos = ServiciosTurnos.HistorialPaciente(SesionUsuario.IdRelacionado.Value);
                }
                else
                {
                    return;
                }

                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = turnos;

                if (dgvTurnos.Columns["TurnoId"] != null)
                    dgvTurnos.Columns["TurnoId"].HeaderText = "ID";
                if (dgvTurnos.Columns["NumeroTurno"] != null)
                    dgvTurnos.Columns["NumeroTurno"].HeaderText = "N°";
                if (dgvTurnos.Columns["FechaHoraCreacion"] != null)
                    dgvTurnos.Columns["FechaHoraCreacion"].HeaderText = "Fecha";
                if (dgvTurnos.Columns["EstadoTurno"] != null)
                    dgvTurnos.Columns["EstadoTurno"].HeaderText = "Estado";
                if (dgvTurnos.Columns["Prioridad"] != null)
                    dgvTurnos.Columns["Prioridad"].HeaderText = "Prioridad";
                if (dgvTurnos.Columns["Medico"] != null)
                    dgvTurnos.Columns["Medico"].HeaderText = "Médico";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar historial: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}