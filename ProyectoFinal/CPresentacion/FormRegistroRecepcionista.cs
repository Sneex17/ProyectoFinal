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
    public partial class FormRegistroRecepcionista : Form
    {
        public FormRegistroRecepcionista()
        {
            InitializeComponent();
            cmbRol.SelectedIndex = 0;
        }
    }
}
