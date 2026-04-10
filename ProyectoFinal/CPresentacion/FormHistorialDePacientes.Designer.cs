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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label7 = new Label();
            label6 = new Label();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnFiltro = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            txtFiltro = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label4 = new Label();
            cmbMedico = new ReaLTaiizor.Controls.PoisonComboBox();
            label3 = new Label();
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            cmbEstadoTurno = new ReaLTaiizor.Controls.PoisonComboBox();
            label2 = new Label();
            label1 = new Label();
            dtpFechaConsulta = new ReaLTaiizor.Controls.PoisonDateTime();
            dgvPacientes = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnExportar = new Krypton.Toolkit.KryptonButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(73, 121);
            label7.Name = "label7";
            label7.Size = new Size(421, 27);
            label7.TabIndex = 26;
            label7.Text = "Gestión y visualización de la actividad clínica ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(62, 53);
            label6.Name = "label6";
            label6.Size = new Size(602, 59);
            label6.TabIndex = 27;
            label6.Text = "Historial de pacientes del día";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(btnFiltro);
            foreverGroupBox1.Controls.Add(foreverGroupBox2);
            foreverGroupBox1.Controls.Add(label5);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Controls.Add(cmbMedico);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(cmbEspecialidades);
            foreverGroupBox1.Controls.Add(cmbEstadoTurno);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Controls.Add(dtpFechaConsulta);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(101, 184);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(1020, 308);
            foreverGroupBox1.TabIndex = 28;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(795, 195);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(165, 48);
            btnFiltro.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnFiltro.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnFiltro.StateCommon.Back.ColorAngle = -2F;
            btnFiltro.StateCommon.Border.Color1 = Color.Transparent;
            btnFiltro.StateCommon.Border.Color2 = Color.Transparent;
            btnFiltro.StateCommon.Border.Rounding = 20F;
            btnFiltro.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltro.StateCommon.Content.ShortText.Color1 = Color.White;
            btnFiltro.StateCommon.Content.ShortText.Color2 = Color.White;
            btnFiltro.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltro.TabIndex = 29;
            btnFiltro.Values.DropDownArrowColor = Color.Empty;
            btnFiltro.Values.Text = "Buscar";
            // 
            // foreverGroupBox2
            // 
            foreverGroupBox2.ArrowColorF = Color.Transparent;
            foreverGroupBox2.ArrowColorH = Color.Transparent;
            foreverGroupBox2.BackColor = Color.Transparent;
            foreverGroupBox2.BaseColor = Color.White;
            foreverGroupBox2.Controls.Add(txtFiltro);
            foreverGroupBox2.Controls.Add(iconButton1);
            foreverGroupBox2.Font = new Font("Segoe UI", 10F);
            foreverGroupBox2.Location = new Point(60, 186);
            foreverGroupBox2.Name = "foreverGroupBox2";
            foreverGroupBox2.ShowArrow = true;
            foreverGroupBox2.ShowText = true;
            foreverGroupBox2.Size = new Size(729, 68);
            foreverGroupBox2.TabIndex = 29;
            foreverGroupBox2.TextColor = Color.Transparent;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.None;
            txtFiltro.Font = new Font("Corbel", 12F);
            txtFiltro.ForeColor = Color.FromArgb(4, 79, 86);
            txtFiltro.Location = new Point(56, 17);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Nombre, apellido...";
            txtFiltro.Size = new Size(650, 30);
            txtFiltro.TabIndex = 38;
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
            iconButton1.Location = new Point(14, 17);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 36);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(95, 154, 162);
            label5.Location = new Point(60, 164);
            label5.Name = "label5";
            label5.Size = new Size(165, 19);
            label5.TabIndex = 37;
            label5.Text = "BUSCAR POR PACIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(95, 154, 162);
            label4.Location = new Point(773, 69);
            label4.Name = "label4";
            label4.Size = new Size(166, 19);
            label4.TabIndex = 36;
            label4.Text = "MÉDICO RESPONSABLE";
            // 
            // cmbMedico
            // 
            cmbMedico.BackColor = Color.White;
            cmbMedico.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMedico.ForeColor = Color.Black;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.ItemHeight = 31;
            cmbMedico.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbMedico.Location = new Point(773, 97);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(187, 37);
            cmbMedico.TabIndex = 35;
            cmbMedico.UseCustomBackColor = true;
            cmbMedico.UseCustomFont = true;
            cmbMedico.UseCustomForeColor = true;
            cmbMedico.UseSelectable = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(95, 154, 162);
            label3.Location = new Point(551, 69);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 34;
            label3.Text = "ESPECIALIDAD";
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.BackColor = Color.White;
            cmbEspecialidades.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidades.ForeColor = Color.Black;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.ItemHeight = 31;
            cmbEspecialidades.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbEspecialidades.Location = new Point(551, 97);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(187, 37);
            cmbEspecialidades.TabIndex = 33;
            cmbEspecialidades.UseCustomBackColor = true;
            cmbEspecialidades.UseCustomFont = true;
            cmbEspecialidades.UseCustomForeColor = true;
            cmbEspecialidades.UseSelectable = true;
            // 
            // cmbEstadoTurno
            // 
            cmbEstadoTurno.BackColor = Color.White;
            cmbEstadoTurno.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstadoTurno.ForeColor = Color.Black;
            cmbEstadoTurno.FormattingEnabled = true;
            cmbEstadoTurno.ItemHeight = 31;
            cmbEstadoTurno.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbEstadoTurno.Location = new Point(321, 99);
            cmbEstadoTurno.Name = "cmbEstadoTurno";
            cmbEstadoTurno.Size = new Size(187, 37);
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
            label2.Location = new Point(321, 69);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 31;
            label2.Text = "ESTADO DE LA CITA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(95, 154, 162);
            label1.Location = new Point(60, 69);
            label1.Name = "label1";
            label1.Size = new Size(149, 19);
            label1.TabIndex = 30;
            label1.Text = "FECHA DE CONSULTA";
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.CalendarFont = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaConsulta.CalendarForeColor = Color.FromArgb(4, 79, 86);
            dtpFechaConsulta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFechaConsulta.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtpFechaConsulta.Format = DateTimePickerFormat.Short;
            dtpFechaConsulta.Location = new Point(60, 99);
            dtpFechaConsulta.MinimumSize = new Size(0, 35);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.RightToLeft = RightToLeft.No;
            dtpFechaConsulta.Size = new Size(201, 35);
            dtpFechaConsulta.TabIndex = 29;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToResizeRows = false;
            dgvPacientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPacientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvPacientes.GridColor = Color.FromArgb(255, 255, 255);
            dgvPacientes.Location = new Point(111, 517);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPacientes.RowHeadersWidth = 62;
            dgvPacientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(997, 415);
            dgvPacientes.TabIndex = 29;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(896, 121);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(212, 57);
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
            iconButton2.Location = new Point(925, 130);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(36, 32);
            iconButton2.TabIndex = 39;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // FormHistorialDePacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(1205, 1050);
            Controls.Add(iconButton2);
            Controls.Add(btnExportar);
            Controls.Add(dgvPacientes);
            Controls.Add(foreverGroupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "FormHistorialDePacientes";
            Text = "FormHistorialDePacientes";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaConsulta;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEstadoTurno;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private Label label4;
        private ReaLTaiizor.Controls.PoisonComboBox cmbMedico;
        private Label label5;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtFiltro;
        private Krypton.Toolkit.KryptonButton btnFiltro;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvPacientes;
        private Krypton.Toolkit.KryptonButton btnExportar;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}