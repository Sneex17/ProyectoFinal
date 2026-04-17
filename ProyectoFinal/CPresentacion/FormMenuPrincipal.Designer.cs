namespace CPresentacion
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuRegistrarTurno, menuRegistrarMedico, menuRegistrarEspecialidades, menuRegistroRecepcionista, menuEstadisticas, menuHistorialTurno, menuHistorialPacientes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(252, 1050);
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
            menuRegistrarTurno.Size = new Size(239, 32);
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
            menuRegistrarMedico.Size = new Size(239, 29);
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
            menuRegistrarEspecialidades.Size = new Size(239, 29);
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
            menuRegistroRecepcionista.Size = new Size(239, 29);
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
            menuEstadisticas.Size = new Size(239, 29);
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
            menuHistorialTurno.Size = new Size(239, 29);
            menuHistorialTurno.Text = "Historial de Turno";
            // 
            // menuHistorialPacientes
            // 
            menuHistorialPacientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuHistorialPacientes.ForeColor = Color.White;
            menuHistorialPacientes.IconChar = FontAwesome.Sharp.IconChar.None;
            menuHistorialPacientes.IconColor = Color.Black;
            menuHistorialPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuHistorialPacientes.Name = "menuHistorialPacientes";
            menuHistorialPacientes.Size = new Size(239, 29);
            menuHistorialPacientes.Text = "Historial Pacientes";
            menuHistorialPacientes.Click += menuHistorialPacientes_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(252, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 1050);
            panel1.TabIndex = 1;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 1050);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenuPrincipal";
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
        private Panel panel1;
    }
}