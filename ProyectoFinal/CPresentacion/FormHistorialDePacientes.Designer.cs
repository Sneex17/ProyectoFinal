namespace CPresentacion
{
    partial class FormHistorialDePacientes
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
            label7 = new Label();
            label6 = new Label();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label8 = new Label();
            dtpFecha = new ReaLTaiizor.Controls.PoisonDateTime();
            label3 = new Label();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox3 = new ReaLTaiizor.Controls.ForeverGroupBox();
            txtMedico = new TextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            label4 = new Label();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            txtPaciente = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            cmbEstadoTurno = new ReaLTaiizor.Controls.PoisonComboBox();
            label2 = new Label();
            btnExportar = new Krypton.Toolkit.KryptonButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dgvHistorial = new DataGridView();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox3.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(51, 73);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(286, 18);
            label7.TabIndex = 26;
            label7.Text = "Gestión y visualización de la actividad clínica ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(43, 32);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(303, 39);
            label6.TabIndex = 27;
            label6.Text = "Historial de pacientes";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(btnLimpiar);
            foreverGroupBox1.Controls.Add(iconButton3);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Controls.Add(label8);
            foreverGroupBox1.Controls.Add(dtpFecha);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(btnBuscar);
            foreverGroupBox1.Controls.Add(foreverGroupBox3);
            foreverGroupBox1.Controls.Add(cmbEspecialidades);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Controls.Add(foreverGroupBox2);
            foreverGroupBox1.Controls.Add(label5);
            foreverGroupBox1.Controls.Add(cmbEstadoTurno);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(71, 96);
            foreverGroupBox1.Margin = new Padding(2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(714, 214);
            foreverGroupBox1.TabIndex = 28;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(556, 47);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 34);
            btnLimpiar.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnLimpiar.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnLimpiar.StateCommon.Back.ColorAngle = -2F;
            btnLimpiar.StateCommon.Border.Color1 = Color.Transparent;
            btnLimpiar.StateCommon.Border.Color2 = Color.Transparent;
            btnLimpiar.StateCommon.Border.Rounding = 20F;
            btnLimpiar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLimpiar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLimpiar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.TabIndex = 53;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(204, 234, 212);
            iconButton3.Enabled = false;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Filter;
            iconButton3.IconColor = Color.FromArgb(0, 54, 60);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 26;
            iconButton3.Location = new Point(14, 60);
            iconButton3.Margin = new Padding(2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(25, 13);
            iconButton3.TabIndex = 52;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(95, 154, 162);
            label1.Location = new Point(35, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 13);
            label1.TabIndex = 50;
            label1.Text = "FILTRO: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(95, 154, 162);
            label8.Location = new Point(81, 35);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 13);
            label8.TabIndex = 51;
            label8.Text = "FECHA DE CONSULTA";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.CalendarForeColor = Color.FromArgb(4, 79, 86);
            dtpFecha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFecha.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(81, 53);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.MinimumSize = new Size(0, 35);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.RightToLeft = RightToLeft.No;
            dtpFecha.Size = new Size(142, 35);
            dtpFecha.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(95, 154, 162);
            label3.Location = new Point(237, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 13);
            label3.TabIndex = 42;
            label3.Text = "ESPECIALIDAD";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(556, 117);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 29);
            btnBuscar.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnBuscar.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnBuscar.StateCommon.Back.ColorAngle = -2F;
            btnBuscar.StateCommon.Border.Color1 = Color.Transparent;
            btnBuscar.StateCommon.Border.Color2 = Color.Transparent;
            btnBuscar.StateCommon.Border.Rounding = 20F;
            btnBuscar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.TabIndex = 29;
            btnBuscar.Values.DropDownArrowColor = Color.Empty;
            btnBuscar.Values.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // foreverGroupBox3
            // 
            foreverGroupBox3.ArrowColorF = Color.Transparent;
            foreverGroupBox3.ArrowColorH = Color.Transparent;
            foreverGroupBox3.BackColor = Color.Transparent;
            foreverGroupBox3.BaseColor = Color.White;
            foreverGroupBox3.Controls.Add(txtMedico);
            foreverGroupBox3.Controls.Add(iconButton4);
            foreverGroupBox3.Font = new Font("Segoe UI", 10F);
            foreverGroupBox3.Location = new Point(42, 159);
            foreverGroupBox3.Margin = new Padding(2);
            foreverGroupBox3.Name = "foreverGroupBox3";
            foreverGroupBox3.ShowArrow = true;
            foreverGroupBox3.ShowText = true;
            foreverGroupBox3.Size = new Size(510, 41);
            foreverGroupBox3.TabIndex = 29;
            foreverGroupBox3.TextColor = Color.Transparent;
            // 
            // txtMedico
            // 
            txtMedico.BorderStyle = BorderStyle.None;
            txtMedico.Font = new Font("Corbel", 12F);
            txtMedico.ForeColor = Color.FromArgb(4, 79, 86);
            txtMedico.Location = new Point(39, 10);
            txtMedico.Margin = new Padding(2);
            txtMedico.Name = "txtMedico";
            txtMedico.PlaceholderText = "Nombre, apellido...";
            txtMedico.Size = new Size(455, 20);
            txtMedico.TabIndex = 38;
            // 
            // iconButton4
            // 
            iconButton4.Enabled = false;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton4.IconColor = Color.FromArgb(95, 154, 162);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 28;
            iconButton4.Location = new Point(10, 10);
            iconButton4.Margin = new Padding(2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(25, 22);
            iconButton4.TabIndex = 0;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.BackColor = Color.White;
            cmbEspecialidades.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidades.ForeColor = Color.Black;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.ItemHeight = 22;
            cmbEspecialidades.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbEspecialidades.Location = new Point(237, 55);
            cmbEspecialidades.Margin = new Padding(2);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(132, 28);
            cmbEspecialidades.TabIndex = 41;
            cmbEspecialidades.UseCustomBackColor = true;
            cmbEspecialidades.UseCustomFont = true;
            cmbEspecialidades.UseCustomForeColor = true;
            cmbEspecialidades.UseSelectable = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(95, 154, 162);
            label4.Location = new Point(42, 148);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 13);
            label4.TabIndex = 37;
            label4.Text = "BUSCAR POR MEDICO";
            // 
            // foreverGroupBox2
            // 
            foreverGroupBox2.ArrowColorF = Color.Transparent;
            foreverGroupBox2.ArrowColorH = Color.Transparent;
            foreverGroupBox2.BackColor = Color.Transparent;
            foreverGroupBox2.BaseColor = Color.White;
            foreverGroupBox2.Controls.Add(txtPaciente);
            foreverGroupBox2.Controls.Add(iconButton1);
            foreverGroupBox2.Font = new Font("Segoe UI", 10F);
            foreverGroupBox2.Location = new Point(42, 112);
            foreverGroupBox2.Margin = new Padding(2);
            foreverGroupBox2.Name = "foreverGroupBox2";
            foreverGroupBox2.ShowArrow = true;
            foreverGroupBox2.ShowText = true;
            foreverGroupBox2.Size = new Size(510, 41);
            foreverGroupBox2.TabIndex = 29;
            foreverGroupBox2.TextColor = Color.Transparent;
            // 
            // txtPaciente
            // 
            txtPaciente.BorderStyle = BorderStyle.None;
            txtPaciente.Font = new Font("Corbel", 12F);
            txtPaciente.ForeColor = Color.FromArgb(4, 79, 86);
            txtPaciente.Location = new Point(39, 10);
            txtPaciente.Margin = new Padding(2);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.PlaceholderText = "Nombre, apellido...";
            txtPaciente.Size = new Size(455, 20);
            txtPaciente.TabIndex = 38;
            // 
            // iconButton1
            // 
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.FromArgb(95, 154, 162);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(10, 10);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(25, 22);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(95, 154, 162);
            label5.Location = new Point(42, 100);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 13);
            label5.TabIndex = 37;
            label5.Text = "BUSCAR POR PACIENTE";
            // 
            // cmbEstadoTurno
            // 
            cmbEstadoTurno.BackColor = Color.White;
            cmbEstadoTurno.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstadoTurno.ForeColor = Color.Black;
            cmbEstadoTurno.FormattingEnabled = true;
            cmbEstadoTurno.ItemHeight = 22;
            cmbEstadoTurno.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbEstadoTurno.Location = new Point(373, 55);
            cmbEstadoTurno.Margin = new Padding(2);
            cmbEstadoTurno.Name = "cmbEstadoTurno";
            cmbEstadoTurno.Size = new Size(132, 28);
            cmbEstadoTurno.TabIndex = 32;
            cmbEstadoTurno.UseCustomBackColor = true;
            cmbEstadoTurno.UseCustomFont = true;
            cmbEstadoTurno.UseCustomForeColor = true;
            cmbEstadoTurno.UseSelectable = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(95, 154, 162);
            label2.Location = new Point(373, 37);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 13);
            label2.TabIndex = 31;
            label2.Text = "ESTADO DE LA CITA";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(627, 51);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(148, 47);
            btnExportar.StateCommon.Back.Color1 = Color.FromArgb(204, 234, 212);
            btnExportar.StateCommon.Back.Color2 = Color.FromArgb(204, 234, 212);
            btnExportar.StateCommon.Back.ColorAngle = -2F;
            btnExportar.StateCommon.Border.Color1 = Color.Transparent;
            btnExportar.StateCommon.Border.Color2 = Color.Transparent;
            btnExportar.StateCommon.Border.Rounding = 20F;
            btnExportar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 54, 60);
            btnExportar.StateCommon.Content.ShortText.Color2 = Color.FromArgb(0, 54, 60);
            btnExportar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.TabIndex = 38;
            btnExportar.Values.DropDownArrowColor = Color.Empty;
            btnExportar.Values.Text = "Exportar ";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(204, 234, 212);
            iconButton2.Enabled = false;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconButton2.IconColor = Color.FromArgb(0, 54, 60);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 26;
            iconButton2.Location = new Point(647, 62);
            iconButton2.Margin = new Padding(2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(25, 19);
            iconButton2.TabIndex = 39;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(77, 314);
            dgvHistorial.Margin = new Padding(2);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.Size = new Size(699, 273);
            dgvHistorial.TabIndex = 40;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            // 
            // FormHistorialDePacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(844, 630);
            Controls.Add(dgvHistorial);
            Controls.Add(iconButton2);
            Controls.Add(btnExportar);
            Controls.Add(foreverGroupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Margin = new Padding(2);
            Name = "FormHistorialDePacientes";
            Text = "FormHistorialDePacientes";
            Load += FormHistorialDePacientes_Load;
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            foreverGroupBox3.ResumeLayout(false);
            foreverGroupBox3.PerformLayout();
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private Label label2;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEstadoTurno;
        private Label label5;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtPaciente;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonButton btnExportar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridView dgvHistorial;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label1;
        private Label label8;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFecha;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox3;
        private TextBox txtMedico;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label4;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
    }
}