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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            label5 = new Label();
            label3 = new Label();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            label2 = new Label();
            label1 = new Label();
            dtpFechaConsulta = new ReaLTaiizor.Controls.PoisonDateTime();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            label6 = new Label();
            dgvTurnos = new DataGridView();
            grpCambiarPrioridad = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnCambiarPrioridad = new Krypton.Toolkit.KryptonButton();
            cmbNuevaPrioridad = new ReaLTaiizor.Controls.PoisonComboBox();
            lblNuevaPrioridad = new Label();
            grpbRecepcionista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            grpCambiarPrioridad.SuspendLayout();
            SuspendLayout();
            // 
            // grpbRecepcionista
            // 
            grpbRecepcionista.ArrowColorF = Color.Transparent;
            grpbRecepcionista.ArrowColorH = Color.Transparent;
            grpbRecepcionista.BackColor = Color.Transparent;
            grpbRecepcionista.BaseColor = Color.FromArgb(204, 234, 212);
            grpbRecepcionista.Controls.Add(iconButton3);
            grpbRecepcionista.Controls.Add(btnBuscar);
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
            grpbRecepcionista.Size = new Size(704, 113);
            grpbRecepcionista.TabIndex = 44;
            grpbRecepcionista.TextColor = Color.Transparent;
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
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(552, 40);
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
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(621, 219);
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
            label6.Text = "Cola de Turnos Actual";
            // 
            // dgvTurnos
            // 
            dgvTurnos.BackgroundColor = Color.White;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(45, 277);
            dgvTurnos.Margin = new Padding(2, 2, 2, 2);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 62;
            dgvTurnos.Size = new Size(699, 280);
            dgvTurnos.TabIndex = 47;
            // 
            // grpCambiarPrioridad
            // 
            grpCambiarPrioridad.ArrowColorF = Color.Transparent;
            grpCambiarPrioridad.ArrowColorH = Color.Transparent;
            grpCambiarPrioridad.BackColor = Color.Transparent;
            grpCambiarPrioridad.BaseColor = Color.FromArgb(204, 234, 212);
            grpCambiarPrioridad.Controls.Add(btnCambiarPrioridad);
            grpCambiarPrioridad.Controls.Add(cmbNuevaPrioridad);
            grpCambiarPrioridad.Controls.Add(lblNuevaPrioridad);
            grpCambiarPrioridad.Font = new Font("Segoe UI", 10F);
            grpCambiarPrioridad.Location = new Point(45, 194);
            grpCambiarPrioridad.Margin = new Padding(2, 2, 2, 2);
            grpCambiarPrioridad.Name = "grpCambiarPrioridad";
            grpCambiarPrioridad.ShowArrow = true;
            grpCambiarPrioridad.ShowText = true;
            grpCambiarPrioridad.Size = new Size(282, 72);
            grpCambiarPrioridad.TabIndex = 49;
            grpCambiarPrioridad.Text = "CAMBIAR PRIORIDAD";
            grpCambiarPrioridad.TextColor = Color.Transparent;
            grpCambiarPrioridad.Visible = false;
            // 
            // btnCambiarPrioridad
            // 
            btnCambiarPrioridad.Cursor = Cursors.Hand;
            btnCambiarPrioridad.Location = new Point(169, 25);
            btnCambiarPrioridad.Margin = new Padding(2, 2, 2, 2);
            btnCambiarPrioridad.Name = "btnCambiarPrioridad";
            btnCambiarPrioridad.Size = new Size(84, 27);
            btnCambiarPrioridad.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnCambiarPrioridad.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnCambiarPrioridad.StateCommon.Back.ColorAngle = -2F;
            btnCambiarPrioridad.StateCommon.Border.Color1 = Color.Transparent;
            btnCambiarPrioridad.StateCommon.Border.Color2 = Color.Transparent;
            btnCambiarPrioridad.StateCommon.Border.Rounding = 20F;
            btnCambiarPrioridad.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarPrioridad.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCambiarPrioridad.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCambiarPrioridad.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarPrioridad.TabIndex = 50;
            btnCambiarPrioridad.Values.DropDownArrowColor = Color.Empty;
            btnCambiarPrioridad.Values.Text = "Cambiar";
            // 
            // cmbNuevaPrioridad
            // 
            cmbNuevaPrioridad.BackColor = Color.White;
            cmbNuevaPrioridad.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbNuevaPrioridad.ForeColor = Color.Black;
            cmbNuevaPrioridad.FormattingEnabled = true;
            cmbNuevaPrioridad.ItemHeight = 22;
            cmbNuevaPrioridad.Location = new Point(14, 30);
            cmbNuevaPrioridad.Margin = new Padding(2, 2, 2, 2);
            cmbNuevaPrioridad.Name = "cmbNuevaPrioridad";
            cmbNuevaPrioridad.Size = new Size(141, 28);
            cmbNuevaPrioridad.TabIndex = 51;
            cmbNuevaPrioridad.UseCustomBackColor = true;
            cmbNuevaPrioridad.UseCustomFont = true;
            cmbNuevaPrioridad.UseCustomForeColor = true;
            cmbNuevaPrioridad.UseSelectable = true;
            // 
            // lblNuevaPrioridad
            // 
            lblNuevaPrioridad.AutoSize = true;
            lblNuevaPrioridad.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevaPrioridad.ForeColor = Color.FromArgb(95, 154, 162);
            lblNuevaPrioridad.Location = new Point(14, 12);
            lblNuevaPrioridad.Margin = new Padding(2, 0, 2, 0);
            lblNuevaPrioridad.Name = "lblNuevaPrioridad";
            lblNuevaPrioridad.Size = new Size(96, 13);
            lblNuevaPrioridad.TabIndex = 52;
            lblNuevaPrioridad.Text = "NUEVA PRIORIDAD:";
            // 
            // FormColaTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(811, 600);
            Controls.Add(btnLimpiar);
            Controls.Add(grpCambiarPrioridad);
            Controls.Add(dgvTurnos);
            Controls.Add(label6);
            Controls.Add(grpbRecepcionista);
            Name = "FormColaTurno";
            Text = "FormColaTurno";
            grpbRecepcionista.ResumeLayout(false);
            grpbRecepcionista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            grpCambiarPrioridad.ResumeLayout(false);
            grpCambiarPrioridad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverGroupBox grpbRecepcionista;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Label label6;
        private DataGridView dgvTurnos;
        private ReaLTaiizor.Controls.ForeverGroupBox grpCambiarPrioridad;
        private Krypton.Toolkit.KryptonButton btnCambiarPrioridad;
        private ReaLTaiizor.Controls.PoisonComboBox cmbNuevaPrioridad;
        private Label lblNuevaPrioridad;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label5;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaConsulta;
    }
}