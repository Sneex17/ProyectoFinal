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
    public partial class FormObservacion : Form
    {
        public FormObservacion(string prioridad, DateTime? fechaAtencion, string observaciones, string nombre)
        {
            InitializeComponent();

            lblPrioridad.Text = prioridad;
            lblFechaAtencion.Text = fechaAtencion?.ToString("g") ?? "No registrada"; 
            txtObservaciones.Text = observaciones;
            lblNombre.Text = nombre;
        }
    }
}
