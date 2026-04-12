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
    public partial class FormRegistroTurno : Form
    {
        private int prioridadSeleccionada = 0; // Variable para almacenar la prioridad seleccionada, cambia con el click en un botón
        public FormRegistroTurno()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            // Se pinta background del botón y se cambia variable de prioridad seleccionada
            try
            {
                btnBaja.BackColor = Color.LightBlue;
                prioridadSeleccionada = 3; // Prioridad baja

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
                btnMedia.BackColor = Color.LightGreen;
                prioridadSeleccionada = 2; // Prioridad media

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
                btnAlta.BackColor = Color.LightYellow;
                prioridadSeleccionada = 1; // Prioridad alta

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
                btnUrgente.BackColor = Color.LightPink;
                prioridadSeleccionada = 4; // Prioridad urgente

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
