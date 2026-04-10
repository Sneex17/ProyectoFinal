namespace CPresentacion
{
    partial class FormRegistroMedico
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
            dgvMedicos = new ReaLTaiizor.Controls.PoisonDataGridView();
            BuDesactivar = new Krypton.Toolkit.KryptonButton();
            BuEditar = new Krypton.Toolkit.KryptonButton();
            BuCrear = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtApellido = new TextBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            textBox1 = new TextBox();
            cmbUsuarios = new ReaLTaiizor.Controls.PoisonComboBox();
            label4 = new Label();
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            label3 = new Label();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNombre = new TextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNLicencia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            foreverGroupBox1.SuspendLayout();
            parrotGroupBox4.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(54, 77);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(283, 18);
            label7.TabIndex = 17;
            label7.Text = "Registro y consulta de médicos en el sistema";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(46, 37);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(285, 39);
            label6.TabIndex = 18;
            label6.Text = "Registro de Médicos";
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToResizeRows = false;
            dgvMedicos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvMedicos.BorderStyle = BorderStyle.None;
            dgvMedicos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMedicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMedicos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMedicos.EnableHeadersVisualStyles = false;
            dgvMedicos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvMedicos.GridColor = Color.FromArgb(255, 255, 255);
            dgvMedicos.Location = new Point(442, 118);
            dgvMedicos.Margin = new Padding(2, 2, 2, 2);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMedicos.RowHeadersWidth = 62;
            dgvMedicos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.Size = new Size(355, 421);
            dgvMedicos.TabIndex = 16;
            // 
            // BuDesactivar
            // 
            BuDesactivar.Location = new Point(54, 542);
            BuDesactivar.Margin = new Padding(2, 2, 2, 2);
            BuDesactivar.Name = "BuDesactivar";
            BuDesactivar.Size = new Size(100, 51);
            BuDesactivar.StateCommon.Back.Color1 = Color.IndianRed;
            BuDesactivar.StateCommon.Back.Color2 = Color.Brown;
            BuDesactivar.StateCommon.Back.ColorAngle = -2F;
            BuDesactivar.StateCommon.Border.Color1 = Color.Transparent;
            BuDesactivar.StateCommon.Border.Color2 = Color.Transparent;
            BuDesactivar.StateCommon.Border.Rounding = 40F;
            BuDesactivar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuDesactivar.StateCommon.Content.ShortText.Color1 = Color.White;
            BuDesactivar.StateCommon.Content.ShortText.Color2 = Color.White;
            BuDesactivar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuDesactivar.TabIndex = 15;
            BuDesactivar.Values.DropDownArrowColor = Color.Empty;
            BuDesactivar.Values.Text = "Desactivar";
            // 
            // BuEditar
            // 
            BuEditar.Location = new Point(172, 542);
            BuEditar.Margin = new Padding(2, 2, 2, 2);
            BuEditar.Name = "BuEditar";
            BuEditar.Size = new Size(100, 51);
            BuEditar.StateCommon.Back.Color1 = Color.FromArgb(254, 219, 151);
            BuEditar.StateCommon.Back.Color2 = Color.FromArgb(254, 219, 151);
            BuEditar.StateCommon.Back.ColorAngle = -2F;
            BuEditar.StateCommon.Border.Color1 = Color.Transparent;
            BuEditar.StateCommon.Border.Color2 = Color.Transparent;
            BuEditar.StateCommon.Border.Rounding = 40F;
            BuEditar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuEditar.StateCommon.Content.ShortText.Color1 = Color.White;
            BuEditar.StateCommon.Content.ShortText.Color2 = Color.White;
            BuEditar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuEditar.TabIndex = 14;
            BuEditar.Values.DropDownArrowColor = Color.Empty;
            BuEditar.Values.Text = "Editar";
            // 
            // BuCrear
            // 
            BuCrear.Location = new Point(289, 542);
            BuCrear.Margin = new Padding(2, 2, 2, 2);
            BuCrear.Name = "BuCrear";
            BuCrear.Size = new Size(100, 51);
            BuCrear.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            BuCrear.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            BuCrear.StateCommon.Back.ColorAngle = -2F;
            BuCrear.StateCommon.Border.Color1 = Color.Transparent;
            BuCrear.StateCommon.Border.Color2 = Color.Transparent;
            BuCrear.StateCommon.Border.Rounding = 40F;
            BuCrear.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuCrear.StateCommon.Content.ShortText.Color1 = Color.White;
            BuCrear.StateCommon.Content.ShortText.Color2 = Color.White;
            BuCrear.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuCrear.TabIndex = 13;
            BuCrear.Values.DropDownArrowColor = Color.Empty;
            BuCrear.Values.Text = "Crear";
            BuCrear.Click += BuCrear_Click;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.White;
            foreverGroupBox1.Controls.Add(parrotGroupBox4);
            foreverGroupBox1.Controls.Add(parrotGroupBox3);
            foreverGroupBox1.Controls.Add(cmbUsuarios);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Controls.Add(cmbEspecialidades);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(parrotGroupBox2);
            foreverGroupBox1.Controls.Add(parrotGroupBox1);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(46, 118);
            foreverGroupBox1.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(356, 421);
            foreverGroupBox1.TabIndex = 12;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // parrotGroupBox4
            // 
            parrotGroupBox4.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox4.BorderWidth = 3;
            parrotGroupBox4.Controls.Add(txtApellido);
            parrotGroupBox4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox4.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox4.Location = new Point(181, 142);
            parrotGroupBox4.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox4.Name = "parrotGroupBox4";
            parrotGroupBox4.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox4.ShowText = true;
            parrotGroupBox4.Size = new Size(133, 41);
            parrotGroupBox4.TabIndex = 3;
            parrotGroupBox4.TabStop = false;
            parrotGroupBox4.Text = "APELLIDOS";
            parrotGroupBox4.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.ForeColor = Color.FromArgb(4, 79, 86);
            txtApellido.Location = new Point(11, 17);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(110, 20);
            txtApellido.TabIndex = 1;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.BorderWidth = 3;
            parrotGroupBox3.Controls.Add(textBox1);
            parrotGroupBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox3.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.Location = new Point(39, 200);
            parrotGroupBox3.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(275, 41);
            parrotGroupBox3.TabIndex = 10;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "CONTRASEÑA";
            parrotGroupBox3.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Corbel", 12F);
            textBox1.ForeColor = Color.FromArgb(4, 79, 86);
            textBox1.Location = new Point(8, 17);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Confirmar contraseña";
            textBox1.Size = new Size(252, 20);
            textBox1.TabIndex = 1;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.BackColor = Color.FromArgb(218, 248, 226);
            cmbUsuarios.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUsuarios.ForeColor = Color.Black;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.ItemHeight = 22;
            cmbUsuarios.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbUsuarios.Location = new Point(36, 371);
            cmbUsuarios.Margin = new Padding(2, 2, 2, 2);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(279, 28);
            cmbUsuarios.TabIndex = 7;
            cmbUsuarios.UseCustomBackColor = true;
            cmbUsuarios.UseCustomFont = true;
            cmbUsuarios.UseCustomForeColor = true;
            cmbUsuarios.UseSelectable = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 79, 86);
            label4.Location = new Point(39, 340);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 18);
            label4.TabIndex = 6;
            label4.Text = "USUARIO ASIGNADO";
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.BackColor = Color.FromArgb(218, 248, 226);
            cmbEspecialidades.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidades.ForeColor = Color.Black;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.ItemHeight = 22;
            cmbEspecialidades.Location = new Point(36, 292);
            cmbEspecialidades.Margin = new Padding(2, 2, 2, 2);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(279, 28);
            cmbEspecialidades.TabIndex = 5;
            cmbEspecialidades.UseCustomBackColor = true;
            cmbEspecialidades.UseCustomFont = true;
            cmbEspecialidades.UseCustomForeColor = true;
            cmbEspecialidades.UseSelectable = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 79, 86);
            label3.Location = new Point(39, 260);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 4;
            label3.Text = "ESPECIALIDAD";
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox2.BorderWidth = 3;
            parrotGroupBox2.Controls.Add(txtNombre);
            parrotGroupBox2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox2.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox2.Location = new Point(39, 142);
            parrotGroupBox2.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(133, 41);
            parrotGroupBox2.TabIndex = 2;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "NOMBRE";
            parrotGroupBox2.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.FromArgb(4, 79, 86);
            txtNombre.Location = new Point(11, 17);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 20);
            txtNombre.TabIndex = 1;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.BorderWidth = 3;
            parrotGroupBox1.Controls.Add(txtNLicencia);
            parrotGroupBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Location = new Point(39, 80);
            parrotGroupBox1.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(275, 41);
            parrotGroupBox1.TabIndex = 1;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "NO. DE LICENCIA";
            parrotGroupBox1.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtNLicencia
            // 
            txtNLicencia.BorderStyle = BorderStyle.None;
            txtNLicencia.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNLicencia.ForeColor = Color.FromArgb(4, 79, 86);
            txtNLicencia.Location = new Point(11, 17);
            txtNLicencia.Margin = new Padding(2, 2, 2, 2);
            txtNLicencia.Name = "txtNLicencia";
            txtNLicencia.PlaceholderText = "Ej: LIC-000-2026";
            txtNLicencia.Size = new Size(252, 20);
            txtNLicencia.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(4, 79, 86);
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(39, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(7, 25);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(50, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 27);
            label1.TabIndex = 2;
            label1.Text = "Detalles de Médico";
            // 
            // FormRegistroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(844, 630);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvMedicos);
            Controls.Add(BuDesactivar);
            Controls.Add(BuEditar);
            Controls.Add(BuCrear);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormRegistroMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistroMedico";
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            parrotGroupBox4.ResumeLayout(false);
            parrotGroupBox4.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvMedicos;
        private Krypton.Toolkit.KryptonButton BuDesactivar;
        private Krypton.Toolkit.KryptonButton BuEditar;
        private Krypton.Toolkit.KryptonButton BuCrear;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private TextBox txtNombre;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private TextBox txtNLicencia;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private TextBox txtApellido;
        private ReaLTaiizor.Controls.PoisonComboBox cmbUsuarios;
        private Label label4;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private Label label3;
    }
}