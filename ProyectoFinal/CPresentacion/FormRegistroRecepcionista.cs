using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;
using CInfraestructura;
using CNegocio;
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
        int idRecepcionista;
        public FormRegistroRecepcionista()
        {
            InitializeComponent();
            Load += (s, e) => CargarDatos();
            Load += (s, e) => DatosGridView();
            dgvRecepcionistas.CellDoubleClick += CellRecepcionistas_CellDoubleClick;
        }
        private void DatosGridView()
        {
            var repositoryRecepcionista = new RecepcionistaRepository();
            dgvRecepcionistas.Rows.Clear();
            foreach (var recepcionista in repositoryRecepcionista.Listar())
            {
                dgvRecepcionistas.Rows.Add(new object[] { recepcionista.RecepcionistaId,
                    recepcionista.Nombre, recepcionista.Apellido, recepcionista.Area.Nombre,
                    recepcionista.UsuarioId, recepcionista.Estado.Nombre });
            }
        }
        private void CellRecepcionistas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dgvRecepcionistas.Rows[e.RowIndex];
                int recepcionistaId = int.TryParse(filaSeleccionada.Cells["RecepcionistaId"].Value.ToString(), out int id) ? id : 0;
                var repositoryRecepcionista = new RecepcionistaRepository();
                var recepcionista = repositoryRecepcionista.Listar().FirstOrDefault(r => r.RecepcionistaId == recepcionistaId);
                if (recepcionista != null)
                {
                    idRecepcionista = recepcionista.RecepcionistaId;
                    txtNombre.Text = recepcionista.Nombre;
                    txtApellido.Text = recepcionista.Apellido;
                    cmbArea.SelectedValue = recepcionista.AreaId;
                    cmbEstados.SelectedValue = recepcionista.EstadoId;
                    cmbRol.SelectedValue = recepcionista.Usuario.RolId;
                    txtUsuario.Text = recepcionista.Usuario.Usuario1;
                }
            }
        }

        private void LimpiarTextBox()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarPass.Clear();
        }
        private void CargarDatos()
        {
            var repositoryEstados = new EstadoRepository();
            cmbEstados.DataSource = repositoryEstados.Listar();
            cmbEstados.ValueMember = "EstadoId";
            cmbEstados.DisplayMember = "Nombre";

            var repositoryRoles = new RolRepository();
            cmbRol.DataSource = repositoryRoles.Listar();
            cmbRol.ValueMember = "RolId";
            cmbRol.DisplayMember = "Nombre";

            var repositoryAreas = new AreaRepository();
            cmbArea.DataSource = repositoryAreas.Listar();
            cmbArea.ValueMember = "AreaId";
            cmbArea.DisplayMember = "Nombre";
        }

        private void BuCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var repository = new RecepcionistaRepository();
                var recepcionista = new Recepcionista()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    AreaId = Convert.ToInt32(cmbArea.SelectedValue),
                    UsuarioId = CrearUsuario(),
                    EstadoId = Convert.ToInt32(cmbEstados.SelectedValue)
                };

                var validacion = new ValidacionRecepcionista();
                var resultado = validacion.Validate(recepcionista);

                if (!resultado.IsValid)
                {
                    string mensaje = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                    throw new ControlExcepciones(mensaje);
                }
                var mensajes = MessageBox.Show("¿Desea registrar el médico?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajes == DialogResult.Yes)
                {
                    repository.Agregar(recepcionista);

                    MessageBox.Show("Recepcionista registrado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTextBox();
                    DatosGridView();
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
        private int CrearUsuario()
        {
            var repositoryUsuario = new UsuarioRepository();
            var usuario = new Usuario()
            {
                Usuario1 = txtUsuario.Text,
                Contrasena = Hast.HashPassword(txtContrasena.Text),
                FechaCreacion = DateTime.Now,
                EstadoId = Convert.ToInt32(cmbEstados.SelectedValue),
                RolId = Convert.ToInt32(cmbRol.SelectedValue)
            };

            var validacion = new ValidacionUsuario();
            var resultado = validacion.Validate(usuario);

            if (!resultado.IsValid)
            {
                string mensaje = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                throw new ControlExcepciones(mensaje);
            }

            if (txtContrasena.Text != txtConfirmarPass.Text)
            {
                throw new ControlExcepciones("Las contraseñas no coinciden.");
            }

            return UsuarioRepository.AgregarUsuario(usuario);
        }
        private void BuEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idRecepcionista == 0)
                {
                    throw new ControlExcepciones("Seleccione un médico para editar.");
                }

                var repository = new RecepcionistaRepository();
                var recepcionista = new Recepcionista()
                {
                    RecepcionistaId = idRecepcionista,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    AreaId =  Convert.ToInt32(cmbArea.SelectedValue),
                    EstadoId = Convert.ToInt32(cmbEstados.SelectedValue)
                };

                var validacion = new ValidacionRecepcionista();
                var resultado = validacion.Validate(recepcionista);

                if (!resultado.IsValid)
                {
                    string mensaje = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                    throw new ControlExcepciones(mensaje);
                }
                var mensajes = MessageBox.Show("¿Desea actualizar el recepcionista?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajes == DialogResult.Yes)
                {
                    repository.Actualizar(recepcionista);

                    MessageBox.Show("Recepcionista actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTextBox();
                    DatosGridView();
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

        private void BuDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idRecepcionista == 0)
                {
                    throw new ControlExcepciones("Seleccione un recepcionista para desactivar.");
                }

                var repository = new RecepcionistaRepository();
                var recepcionista = new Recepcionista()
                {
                    RecepcionistaId = idRecepcionista,
                    EstadoId = 3
                };

                var mensajes = MessageBox.Show("¿Desea desactivar el recepcionista?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajes == DialogResult.Yes)
                {
                    repository.Eliminar(recepcionista);

                    MessageBox.Show("Recepcionista desactivado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTextBox();
                    DatosGridView();
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
    }
}
