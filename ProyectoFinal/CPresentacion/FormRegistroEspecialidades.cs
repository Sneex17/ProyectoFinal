using CAccesoDatos.RepositoryPattern;
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

    public partial class FormRegistroEspecialidades : Form
    {
        public EspecialidadesRepositoty especialidadesRepositoty = new EspecialidadesRepositoty();
        public FormRegistroEspecialidades()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            especialidadesRepositoty.Eliminar(new CEntidades.Models.Especialidade
            { Nombre = txtNombreEspecialidad.Text, Descripcion = txtDescripcion.Text });


        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            especialidadesRepositoty.Agregar(new CEntidades.Models.Especialidade
            { Nombre = txtNombreEspecialidad.Text, Descripcion = txtDescripcion.Text });

        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            especialidadesRepositoty.Actualizar(new CEntidades.Models.Especialidade
            { Nombre = txtNombreEspecialidad.Text, Descripcion = txtDescripcion.Text });

        }

        private void CargarDatos()
        {
            var repositoryEspecialidades = new EspecialidadesRepositoty();
            dgvEspecialidades.DataSource = repositoryEspecialidades.Listar();


        }

        private void dgvEspecialidades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEspecialidades.CurrentRow != null)
            {
                var fila = dgvEspecialidades.CurrentRow;

                txtNombreEspecialidad.Text = fila.Cells["Nombre"].Value?.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
            }
        }
    }
}
