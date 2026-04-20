using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using CNegocio;

namespace CPresentacion
{
    public partial class FormRegistroEspecialidades : Form
    {
        EspecialidadesRepositoty especialidadesRepo = new EspecialidadesRepositoty();
        int IdEspecialidad = 0;
        public FormRegistroEspecialidades()
        {
            InitializeComponent();
            Load += (s,e) => CargarEventos();
            Load += (s,e) => CargarDatos();
        }

        private void CargarEventos()
        {
            btnCrear.Click += btnRegistrar_Click;
            btnEditar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            dgvEspecialidades.CellDoubleClick += DgvEspecialidades_CellDoubleClick;
        }
        private void CargarDatos()
        {
            var listaEspecialidades = especialidadesRepo.Listar();
            dgvEspecialidades.Rows.Clear();
            foreach (var Especialidad in listaEspecialidades)
            {
                dgvEspecialidades.Rows.Add(new object[] { Especialidad.EspecialidadId, 
                    Especialidad.Nombre, Especialidad.Descripcion });
            }
        }

        private void DgvEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dgvEspecialidades.Rows[e.RowIndex];
                IdEspecialidad = int.TryParse(filaSeleccionada.Cells["EspecialidadId"].Value.ToString(), out int id) ? id : 0;
                txtNombreEspecialidad.Text = filaSeleccionada.Cells["Especialidad"].Value.ToString();
                txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            }
        }
        private void LimpiarTextBox()
        {
            txtNombreEspecialidad.Clear();
            txtDescripcion.Clear();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaEspecialidad = new Especialidade()
                {
                    Nombre = txtNombreEspecialidad.Text,
                    Descripcion = txtDescripcion.Text
                };
                
                var validacion = new ValidacionEspecialidades();
                var resultado = validacion.Validate(nuevaEspecialidad);

                if (!resultado.IsValid)
                {
                    string errores = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                    throw new ControlExcepciones(errores);
                }

                var mensaje = MessageBox.Show("¿Deseas registrar esta especialidad?", "Confirmar Registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    especialidadesRepo.Agregar(nuevaEspecialidad);
                    MessageBox.Show("Especialidad registrada exitosamente.", "Registro Exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    LimpiarTextBox();
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(IdEspecialidad == 0)
                {
                    throw new ControlExcepciones("Debe selecionar una especialidad para actualizar sus datos");
                }

                var nuevaEspecialidad = new Especialidade
                {
                    EspecialidadId = IdEspecialidad,
                    Nombre = txtNombreEspecialidad.Text,
                    Descripcion = txtDescripcion.Text
                };

                var validacion = new ValidacionEspecialidades();
                var resultado = validacion.Validate(nuevaEspecialidad);

                if (!resultado.IsValid)
                {
                    string errores = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                    throw new ControlExcepciones(errores);
                }

                var mensaje = MessageBox.Show("¿Deseas actualizar esta especialidad?", "Confirmar Actualización",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    especialidadesRepo.Actualizar(nuevaEspecialidad);
                    MessageBox.Show("Especialidad actualizada exitosamente.", "Actualización Exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    LimpiarTextBox();
                }
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Implementar lógica de eliminación si es necesario
             MessageBox.Show("Funcionalidad de eliminación no implementada.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
