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

        private void CambiarColores ()
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
            // Se cambia variable de prioridad seleccionada
            try
            {
                prioridadSeleccionada = 3; // Prioridad baja
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

                prioridadSeleccionada = 2; // Prioridad media
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
                prioridadSeleccionada = 1; // Prioridad alta
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
                prioridadSeleccionada = 4; // Prioridad urgente
                CambiarColores();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
