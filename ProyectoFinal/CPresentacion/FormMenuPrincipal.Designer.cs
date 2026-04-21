namespace CPresentacion
{
    partial class FormMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuRegistrarTurno = new FontAwesome.Sharp.IconMenuItem();
            menuRegistrarMedico = new FontAwesome.Sharp.IconMenuItem();
            menuRegistrarEspecialidades = new FontAwesome.Sharp.IconMenuItem();
            menuRegistroRecepcionista = new FontAwesome.Sharp.IconMenuItem();
            menuEstadisticas = new FontAwesome.Sharp.IconMenuItem();
            menuHistorialTurno = new FontAwesome.Sharp.IconMenuItem();
            menuHistorialPacientes = new FontAwesome.Sharp.IconMenuItem();
            menuColaTurnos = new FontAwesome.Sharp.IconMenuItem();
            menuAtencion = new FontAwesome.Sharp.IconMenuItem();
            menuGestionPacientes = new FontAwesome.Sharp.IconMenuItem();
            menuCerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            lblBienvenido = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 40, 66);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuRegistrarTurno, menuRegistrarMedico, menuRegistrarEspecialidades, menuRegistroRecepcionista, menuEstadisticas, menuHistorialTurno, menuHistorialPacientes, menuColaTurnos, menuAtencion, menuGestionPacientes, menuCerrarSesion });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(169, 630);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuRegistrarTurno
            // 
            menuRegistrarTurno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuRegistrarTurno.ForeColor = Color.White;
            menuRegistrarTurno.IconChar = FontAwesome.Sharp.IconChar.None;
            menuRegistrarTurno.IconColor = Color.Black;
            menuRegistrarTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRegistrarTurno.Name = "menuRegistrarTurno";
            menuRegistrarTurno.Size = new Size(160, 28);
            menuRegistrarTurno.Text = "Registrar Turno";
            menuRegistrarTurno.Click += menuRegistrarTurno_Click;
            // 
            // menuRegistrarMedico
            // 
            menuRegistrarMedico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuRegistrarMedico.ForeColor = Color.White;
            menuRegistrarMedico.IconChar = FontAwesome.Sharp.IconChar.None;
            menuRegistrarMedico.IconColor = Color.Black;
            menuRegistrarMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRegistrarMedico.Name = "menuRegistrarMedico";
            menuRegistrarMedico.Size = new Size(160, 28);
            menuRegistrarMedico.Text = "Registrar Medico";
            menuRegistrarMedico.Click += menuRegistrarMedico_Click;
            // 
            // menuRegistrarEspecialidades
            // 
            menuRegistrarEspecialidades.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuRegistrarEspecialidades.ForeColor = Color.White;
            menuRegistrarEspecialidades.IconChar = FontAwesome.Sharp.IconChar.None;
            menuRegistrarEspecialidades.IconColor = Color.Black;
            menuRegistrarEspecialidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRegistrarEspecialidades.Name = "menuRegistrarEspecialidades";
            menuRegistrarEspecialidades.Size = new Size(160, 28);
            menuRegistrarEspecialidades.Text = "Registrar Especialidad";
            menuRegistrarEspecialidades.Click += menuRegistrarEspecialidades_Click;
            // 
            // menuRegistroRecepcionista
            // 
            menuRegistroRecepcionista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuRegistroRecepcionista.ForeColor = Color.White;
            menuRegistroRecepcionista.IconChar = FontAwesome.Sharp.IconChar.None;
            menuRegistroRecepcionista.IconColor = Color.Black;
            menuRegistroRecepcionista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRegistroRecepcionista.Name = "menuRegistroRecepcionista";
            menuRegistroRecepcionista.Size = new Size(160, 28);
            menuRegistroRecepcionista.Text = "Registrar Recepcionista";
            menuRegistroRecepcionista.Click += menuRegistroRecepcionista_Click;
            // 
            // menuEstadisticas
            // 
            menuEstadisticas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuEstadisticas.ForeColor = Color.White;
            menuEstadisticas.IconChar = FontAwesome.Sharp.IconChar.None;
            menuEstadisticas.IconColor = Color.Black;
            menuEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuEstadisticas.Name = "menuEstadisticas";
            menuEstadisticas.Size = new Size(160, 28);
            menuEstadisticas.Text = "Estadísticas";
            menuEstadisticas.Click += menuEstadisticas_Click;
            // 
            // menuHistorialTurno
            // 
            menuHistorialTurno.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuHistorialTurno.ForeColor = Color.White;
            menuHistorialTurno.IconChar = FontAwesome.Sharp.IconChar.None;
            menuHistorialTurno.IconColor = Color.Black;
            menuHistorialTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuHistorialTurno.Name = "menuHistorialTurno";
            menuHistorialTurno.Size = new Size(160, 28);
            menuHistorialTurno.Text = "Historial de Turno";
            menuHistorialTurno.Click += menuHistorialTurno_Click;
            // 
            // menuHistorialPacientes
            // 
            menuHistorialPacientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuHistorialPacientes.ForeColor = Color.White;
            menuHistorialPacientes.IconChar = FontAwesome.Sharp.IconChar.None;
            menuHistorialPacientes.IconColor = Color.Black;
            menuHistorialPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuHistorialPacientes.Name = "menuHistorialPacientes";
            menuHistorialPacientes.Size = new Size(160, 28);
            menuHistorialPacientes.Text = "Historial Pacientes";
            menuHistorialPacientes.Click += menuHistorialPacientes_Click;
            // 
            // menuColaTurnos
            // 
            menuColaTurnos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuColaTurnos.ForeColor = Color.White;
            menuColaTurnos.IconChar = FontAwesome.Sharp.IconChar.None;
            menuColaTurnos.IconColor = Color.Black;
            menuColaTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuColaTurnos.Name = "menuColaTurnos";
            menuColaTurnos.Size = new Size(160, 28);
            menuColaTurnos.Text = "Cola de Turnos";
            menuColaTurnos.Click += menuColaTurnos_Click;
            // 
            // menuAtencion
            // 
            menuAtencion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuAtencion.ForeColor = Color.White;
            menuAtencion.IconChar = FontAwesome.Sharp.IconChar.None;
            menuAtencion.IconColor = Color.Black;
            menuAtencion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAtencion.Name = "menuAtencion";
            menuAtencion.Size = new Size(160, 28);
            menuAtencion.Text = "Atención";
            menuAtencion.Click += menuAtencion_Click;
            // 
            // menuGestionPacientes
            // 
            menuGestionPacientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuGestionPacientes.ForeColor = Color.White;
            menuGestionPacientes.IconChar = FontAwesome.Sharp.IconChar.None;
            menuGestionPacientes.IconColor = Color.Black;
            menuGestionPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuGestionPacientes.Name = "menuGestionPacientes";
            menuGestionPacientes.Size = new Size(160, 28);
            menuGestionPacientes.Text = "Gestión Pacientes";
            menuGestionPacientes.Click += menuGestionPacientes_Click;
            // 
            // menuCerrarSesion
            // 
            menuCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuCerrarSesion.ForeColor = Color.White;
            menuCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            menuCerrarSesion.IconColor = Color.Black;
            menuCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCerrarSesion.Name = "menuCerrarSesion";
            menuCerrarSesion.Size = new Size(160, 28);
            menuCerrarSesion.Text = "Cerrar Sesión";
            menuCerrarSesion.Click += menuCerrarSesion_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBienvenido.ForeColor = Color.FromArgb(0, 54, 60);
            lblBienvenido.Location = new Point(189, 12);
            lblBienvenido.Margin = new Padding(2, 0, 2, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(0, 21);
            lblBienvenido.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(169, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 630);
            panel1.TabIndex = 1;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 630);
            Controls.Add(lblBienvenido);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuRegistrarTurno;
        private FontAwesome.Sharp.IconMenuItem menuRegistrarMedico;
        private FontAwesome.Sharp.IconMenuItem menuRegistrarEspecialidades;
        private FontAwesome.Sharp.IconMenuItem menuRegistroRecepcionista;
        private FontAwesome.Sharp.IconMenuItem menuEstadisticas;
        private FontAwesome.Sharp.IconMenuItem menuHistorialTurno;
        private FontAwesome.Sharp.IconMenuItem menuHistorialPacientes;
        private FontAwesome.Sharp.IconMenuItem menuColaTurnos;
        private FontAwesome.Sharp.IconMenuItem menuAtencion;
        private FontAwesome.Sharp.IconMenuItem menuGestionPacientes;
        private FontAwesome.Sharp.IconMenuItem menuCerrarSesion;
        private Label lblBienvenido;
        private Panel panel1;
    }
}