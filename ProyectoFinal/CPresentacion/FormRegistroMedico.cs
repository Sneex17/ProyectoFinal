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
using CEntidades.Models;
using CInfraestructura;
using CNegocio;
using System.Security.AccessControl;

namespace CPresentacion
{
    public partial class FormRegistroMedico : Form
    {
        int idMedico;
        public FormRegistroMedico()
        {
            InitializeComponent();
            Load += (s, e) => CargarDatos();
            Load += (s, e) => DatosGridView();
            dgvMedicos.CellDoubleClick += CellMedicos_CellDoubleClick;
        }
        private void DatosGridView()
        {
            var repositoryMedico = new MedicoRepository();
            dgvMedicos.Rows.Clear();
            foreach (var medico in repositoryMedico.Listar())
            {
                dgvMedicos.Rows.Add(new object[] { medico.MedicoId, medico.Nlicencia, medico.Nombre, medico.Apellido,
                    medico.Especialidad.Nombre, medico.UsuarioId, medico.Estado.Nombre });
            }
        }
        private void LimpiarTextBox()
        {
            txtNLicencia.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarPass.Clear();
        }
        private void CellMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dgvMedicos.Rows[e.RowIndex];
                int medicoId = int.TryParse(filaSeleccionada.Cells["MedicoId"].Value.ToString(), out int id) ? id : 0;
                var repositoryMedico = new MedicoRepository();
                var medico = repositoryMedico.Listar().FirstOrDefault(m => m.MedicoId == medicoId);
                if (medico != null)
                {
                    idMedico = medico.MedicoId;
                    txtNLicencia.Text = medico.Nlicencia;
                    txtNombre.Text = medico.Nombre;
                    txtApellido.Text = medico.Apellido;
                    cmbEspecialidades.SelectedValue = medico.EspecialidadId;
                    cmbEstados.SelectedValue = medico.EstadoId;
                    cmbRol.SelectedValue = medico.Usuario.RolId;
                    txtUsuario.Text = medico.Usuario.Usuario1;
                }
            }
        }
        private void CargarDatos()
        {
            var repositoryEspecialidades = new EspecialidadesRepositoty();
            cmbEspecialidades.DataSource = repositoryEspecialidades.Listar();
            cmbEspecialidades.ValueMember = "EspecialidadId";
            cmbEspecialidades.DisplayMember = "Nombre";

            var repositoryEstados = new EstadoRepository();
            cmbEstados.DataSource = repositoryEstados.Listar();
            cmbEstados.ValueMember = "EstadoId";
            cmbEstados.DisplayMember = "Nombre";


            var repositoryRoles = new RolRepository();
            cmbRol.DataSource = repositoryRoles.Listar();
            cmbRol.ValueMember = "RolId";
            cmbRol.DisplayMember = "Nombre";
        }

        private void BuCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var repository = new MedicoRepository();
                var medico = new Medico()
                {
                    Nlicencia = txtNLicencia.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    EspecialidadId = Convert.ToInt32(cmbEspecialidades.SelectedValue),
                    UsuarioId = CrearUsuario(),
                    EstadoId = Convert.ToInt32(cmbEstados.SelectedValue)
                };

                var validacion = new ValidacionMedico();
                var resultado = validacion.Validate(medico);

                if (!resultado.IsValid)
                {
                    string mensaje = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                    throw new ControlExcepciones(mensaje);
                }
                var mensajes = MessageBox.Show("¿Desea registrar el médico?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajes == DialogResult.Yes)
                {
                    repository.Agregar(medico);

                    MessageBox.Show("Médico registrado exitosamente.", "Éxito",
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
        private void BuEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMedico == 0)
                {
                    throw new ControlExcepciones("Seleccione un médico para editar.");
                }

                var repository = new MedicoRepository();
                var medico = new Medico()
                {
                    MedicoId = idMedico,
                    Nlicencia = txtNLicencia.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    EspecialidadId = Convert.ToInt32(cmbEspecialidades.SelectedValue),

                    EstadoId = Convert.ToInt32(cmbEstados.SelectedValue)
                };

                var validacion = new ValidacionMedico();
                var resultado = validacion.Validate(medico);

                if (!resultado.IsValid)
                {
                    string mensaje = string.Join("\n", resultado.Errors.Select(err => err.ErrorMessage));
                    throw new ControlExcepciones(mensaje);
                }
                var mensajes = MessageBox.Show("¿Desea actualizar el médico?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajes == DialogResult.Yes)
                {
                    repository.Actualizar(medico);

                    MessageBox.Show("Médico actualizado exitosamente.", "Éxito",
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

        private void BuDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMedico == 0)
                {
                    throw new ControlExcepciones("Seleccione un médico para desactivar.");
                }

                var repository = new MedicoRepository();
                var medico = new Medico()
                {
                    MedicoId = idMedico,
                    EstadoId = 3
                };

                var mensajes = MessageBox.Show("¿Desea desactivar el médico?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensajes == DialogResult.Yes)
                {
                    repository.Eliminar(medico);

                    MessageBox.Show("Médico desactivado exitosamente.", "Éxito",
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
