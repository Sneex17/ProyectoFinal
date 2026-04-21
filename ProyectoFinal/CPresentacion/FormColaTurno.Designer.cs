namespace CPresentacion
{
    partial class FormColaTurno
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
            grpbRecepcionista = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            txtFiltro = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            label2 = new Label();
            label1 = new Label();
            dtpFechaConsulta = new ReaLTaiizor.Controls.PoisonDateTime();
            label6 = new Label();
            dgvTurnos = new DataGridView();
            grpbRecepcionista.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // grpbRecepcionista
            // 
            grpbRecepcionista.ArrowColorF = Color.Transparent;
            grpbRecepcionista.ArrowColorH = Color.Transparent;
            grpbRecepcionista.BackColor = Color.Transparent;
            grpbRecepcionista.BaseColor = Color.FromArgb(204, 234, 212);
            grpbRecepcionista.Controls.Add(btnLimpiar);
            grpbRecepcionista.Controls.Add(iconButton3);
            grpbRecepcionista.Controls.Add(btnBuscar);
            grpbRecepcionista.Controls.Add(foreverGroupBox2);
            grpbRecepcionista.Controls.Add(label4);
            grpbRecepcionista.Controls.Add(label5);
            grpbRecepcionista.Controls.Add(label3);
            grpbRecepcionista.Controls.Add(poisonComboBox1);
            grpbRecepcionista.Controls.Add(cmbEspecialidades);
            grpbRecepcionista.Controls.Add(label2);
            grpbRecepcionista.Controls.Add(label1);
            grpbRecepcionista.Controls.Add(dtpFechaConsulta);
            grpbRecepcionista.Font = new Font("Segoe UI", 10F);
            grpbRecepcionista.Location = new Point(40, 72);
            grpbRecepcionista.Margin = new Padding(2, 2, 2, 2);
            grpbRecepcionista.Name = "grpbRecepcionista";
            grpbRecepcionista.ShowArrow = true;
            grpbRecepcionista.ShowText = true;
            grpbRecepcionista.Size = new Size(704, 185);
            grpbRecepcionista.TabIndex = 44;
            grpbRecepcionista.TextColor = Color.Transparent;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(556, 40);
            btnLimpiar.Margin = new Padding(2, 2, 2, 2);
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
            btnLimpiar.TabIndex = 48;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "Limpiar";
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
            iconButton3.Location = new Point(28, 59);
            iconButton3.Margin = new Padding(2, 2, 2, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(25, 13);
            iconButton3.TabIndex = 48;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(556, 114);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 34);
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
            foreverGroupBox2.Location = new Point(42, 112);
            foreverGroupBox2.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox2.Name = "foreverGroupBox2";
            foreverGroupBox2.ShowArrow = true;
            foreverGroupBox2.ShowText = true;
            foreverGroupBox2.Size = new Size(510, 41);
            foreverGroupBox2.TabIndex = 29;
            foreverGroupBox2.TextColor = Color.Transparent;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.None;
            txtFiltro.Font = new Font("Corbel", 12F);
            txtFiltro.ForeColor = Color.FromArgb(4, 79, 86);
            txtFiltro.Location = new Point(39, 10);
            txtFiltro.Margin = new Padding(2, 2, 2, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Nombre, apellido...";
            txtFiltro.Size = new Size(455, 20);
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
            iconButton1.Location = new Point(10, 10);
            iconButton1.Margin = new Padding(2, 2, 2, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(25, 22);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(95, 154, 162);
            label4.Location = new Point(52, 97);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 13);
            label4.TabIndex = 36;
            label4.Text = "BUSCAR POR PACIENTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(95, 154, 162);
            label5.Location = new Point(390, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 13);
            label5.TabIndex = 34;
            label5.Text = "MEDICO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(95, 154, 162);
            label3.Location = new Point(254, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 13);
            label3.TabIndex = 34;
            label3.Text = "ESPECIALIDAD";
            // 
            // poisonComboBox1
            // 
            poisonComboBox1.BackColor = Color.White;
            poisonComboBox1.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poisonComboBox1.ForeColor = Color.Black;
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 22;
            poisonComboBox1.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            poisonComboBox1.Location = new Point(390, 52);
            poisonComboBox1.Margin = new Padding(2, 2, 2, 2);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.Size = new Size(132, 28);
            poisonComboBox1.TabIndex = 33;
            poisonComboBox1.UseCustomBackColor = true;
            poisonComboBox1.UseCustomFont = true;
            poisonComboBox1.UseCustomForeColor = true;
            poisonComboBox1.UseSelectable = true;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.BackColor = Color.White;
            cmbEspecialidades.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidades.ForeColor = Color.Black;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.ItemHeight = 22;
            cmbEspecialidades.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbEspecialidades.Location = new Point(254, 52);
            cmbEspecialidades.Margin = new Padding(2, 2, 2, 2);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(132, 28);
            cmbEspecialidades.TabIndex = 33;
            cmbEspecialidades.UseCustomBackColor = true;
            cmbEspecialidades.UseCustomFont = true;
            cmbEspecialidades.UseCustomForeColor = true;
            cmbEspecialidades.UseSelectable = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(95, 154, 162);
            label2.Location = new Point(49, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 13);
            label2.TabIndex = 30;
            label2.Text = "FILTRO: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(95, 154, 162);
            label1.Location = new Point(95, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 13);
            label1.TabIndex = 30;
            label1.Text = "FECHA DE CONSULTA";
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.CalendarFont = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaConsulta.CalendarForeColor = Color.FromArgb(4, 79, 86);
            dtpFechaConsulta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFechaConsulta.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtpFechaConsulta.Format = DateTimePickerFormat.Short;
            dtpFechaConsulta.Location = new Point(95, 52);
            dtpFechaConsulta.Margin = new Padding(2, 2, 2, 2);
            dtpFechaConsulta.MinimumSize = new Size(0, 35);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.RightToLeft = RightToLeft.No;
            dtpFechaConsulta.Size = new Size(142, 35);
            dtpFechaConsulta.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(27, 22);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(302, 39);
            label6.TabIndex = 46;
            label6.Text = "Cola da Turnos Actual";
            // 
            // dgvTurnos
            // 
            dgvTurnos.BackgroundColor = Color.White;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(45, 277);
            dgvTurnos.Margin = new Padding(2, 2, 2, 2);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 62;
            dgvTurnos.Size = new Size(699, 241);
            dgvTurnos.TabIndex = 47;
            // 
            // FormColaTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(959, 449);
            Controls.Add(dgvTurnos);
            Controls.Add(label6);
            Controls.Add(grpbRecepcionista);
            Name = "FormColaTurno";
            Text = "FormColaTurno";
            grpbRecepcionista.ResumeLayout(false);
            grpbRecepcionista.PerformLayout();
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverGroupBox grpbRecepcionista;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private TextBox txtFiltro;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label4;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaConsulta;
        private Label label6;
        private Label label5;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private DataGridView dgvTurnos;
    }
}