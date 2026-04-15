using CEntidades.Models;
using CEntidades.TurnoDecorator;
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
    public partial class FormColaTurno : Form
    {
        public FormColaTurno()
        {
            InitializeComponent();
        }

        private void foreverGroupBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Aplica los colores de cada fila según el tipo de turno usando el Decorator.
        /// Llamar al final del método que carga los turnos en el DataGridView para que se apliquen los colores correspondientes
        /// </summary>
        private void AplicarColoresDecorator(List<Turno> turnos)
        {
            for (int i = 0; i < dgvTurnos.Rows.Count; i++)
            {
                Turno turno = turnos[i];
                ITurno decorado = TurnoDecoradorFactory.Decorar(turno);
                Color color = Color.FromName(decorado.GetColorFila());

                dgvTurnos.Rows[i].DefaultCellStyle.BackColor = color;
                foreach (DataGridViewCell celda in dgvTurnos.Rows[i].Cells)
                    celda.ToolTipText = decorado.GetDescripcion();
            }
        }
    }
}
