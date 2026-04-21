namespace CPresentacion
{
    partial class FormRegistroUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            textBox1 = new TextBox();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            label5 = new Label();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            label4 = new Label();
            cmbRol = new ReaLTaiizor.Controls.PoisonComboBox();
            label3 = new Label();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtContrasena = new TextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            dgvUsuarios = new ReaLTaiizor.Controls.PoisonDataGridView();
            label6 = new Label();
            label7 = new Label();
            foreverGroupBox1.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.White;
            foreverGroupBox1.Controls.Add(parrotGroupBox3);
            foreverGroupBox1.Controls.Add(poisonDateTime1);
            foreverGroupBox1.Controls.Add(label5);
            foreverGroupBox1.Controls.Add(poisonComboBox1);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Controls.Add(cmbRol);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(parrotGroupBox2);
            foreverGroupBox1.Controls.Add(parrotGroupBox1);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(77, 171);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(509, 702);
            foreverGroupBox1.TabIndex = 0;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.BorderWidth = 3;
            parrotGroupBox3.Controls.Add(textBox1);
            parrotGroupBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox3.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.Location = new Point(56, 333);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(393, 68);
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
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Confirmar contraseña";
            textBox1.Size = new Size(360, 30);
            textBox1.TabIndex = 1;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.CalendarFont = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            poisonDateTime1.CalendarForeColor = Color.FromArgb(4, 79, 86);
            poisonDateTime1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDateTime1.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            poisonDateTime1.Format = DateTimePickerFormat.Short;
            poisonDateTime1.Location = new Point(56, 621);
            poisonDateTime1.MinimumSize = new Size(0, 35);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.RightToLeft = RightToLeft.No;
            poisonDateTime1.Size = new Size(393, 35);
            poisonDateTime1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 79, 86);
            label5.Location = new Point(60, 572);
            label5.Name = "label5";
            label5.Size = new Size(202, 27);
            label5.TabIndex = 8;
            label5.Text = "FECHA DE CREACIÓN";
            // 
            // poisonComboBox1
            // 
            poisonComboBox1.BackColor = Color.FromArgb(218, 248, 226);
            poisonComboBox1.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poisonComboBox1.ForeColor = Color.Black;
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 31;
            poisonComboBox1.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            poisonComboBox1.Location = new Point(275, 510);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.Size = new Size(174, 37);
            poisonComboBox1.TabIndex = 7;
            poisonComboBox1.UseCustomBackColor = true;
            poisonComboBox1.UseCustomFont = true;
            poisonComboBox1.UseCustomForeColor = true;
            poisonComboBox1.UseSelectable = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 79, 86);
            label4.Location = new Point(279, 458);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 6;
            label4.Text = "ESTADO";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.FromArgb(218, 248, 226);
            cmbRol.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.ForeColor = Color.Black;
            cmbRol.FormattingEnabled = true;
            cmbRol.ItemHeight = 31;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Medico", "Recepcionista" });
            cmbRol.Location = new Point(56, 510);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(174, 37);
            cmbRol.TabIndex = 5;
            cmbRol.UseCustomBackColor = true;
            cmbRol.UseCustomFont = true;
            cmbRol.UseCustomForeColor = true;
            cmbRol.UseSelectable = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 79, 86);
            label3.Location = new Point(60, 458);
            label3.Name = "label3";
            label3.Size = new Size(48, 27);
            label3.TabIndex = 4;
            label3.Text = "ROL";
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox2.BorderWidth = 3;
            parrotGroupBox2.Controls.Add(txtContrasena);
            parrotGroupBox2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox2.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox2.Location = new Point(56, 236);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(393, 68);
            parrotGroupBox2.TabIndex = 2;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "CONTRASEÑA";
            parrotGroupBox2.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.FromArgb(4, 79, 86);
            txtContrasena.Location = new Point(16, 28);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(360, 30);
            txtContrasena.TabIndex = 1;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.BorderWidth = 3;
            parrotGroupBox1.Controls.Add(txtUsuario);
            parrotGroupBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Location = new Point(56, 134);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(393, 68);
            parrotGroupBox1.TabIndex = 1;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "USUARIO";
            parrotGroupBox1.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Corbel", 12F);
            txtUsuario.ForeColor = Color.FromArgb(4, 79, 86);
            txtUsuario.Location = new Point(16, 28);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ej: naranjaboy";
            txtUsuario.Size = new Size(360, 30);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(4, 79, 86);
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(56, 52);
            label2.Name = "label2";
            label2.Size = new Size(10, 41);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(72, 52);
            label1.Name = "label1";
            label1.Size = new Size(275, 39);
            label1.TabIndex = 2;
            label1.Text = "Detalles de Usuario";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(424, 879);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(143, 85);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            kryptonButton1.StateCommon.Back.ColorAngle = -2F;
            kryptonButton1.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Border.Rounding = 40F;
            kryptonButton1.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Crear";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(256, 879);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(143, 85);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(254, 219, 151);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(254, 219, 151);
            kryptonButton2.StateCommon.Back.ColorAngle = -2F;
            kryptonButton2.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton2.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton2.StateCommon.Border.Rounding = 40F;
            kryptonButton2.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.TabIndex = 2;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Editar";
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(88, 879);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(143, 85);
            kryptonButton3.StateCommon.Back.Color1 = Color.IndianRed;
            kryptonButton3.StateCommon.Back.Color2 = Color.Brown;
            kryptonButton3.StateCommon.Back.ColorAngle = -2F;
            kryptonButton3.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton3.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton3.StateCommon.Border.Rounding = 40F;
            kryptonButton3.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.TabIndex = 3;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "Desactivar";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvUsuarios.GridColor = Color.FromArgb(255, 255, 255);
            dgvUsuarios.Location = new Point(642, 171);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(507, 702);
            dgvUsuarios.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(77, 36);
            label6.Name = "label6";
            label6.Size = new Size(433, 59);
            label6.TabIndex = 11;
            label6.Text = "Registro de Usuarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(88, 104);
            label7.Name = "label7";
            label7.Size = new Size(421, 27);
            label7.TabIndex = 11;
            label7.Text = "Registro y consulta de usuarios en el sistema";
            // 
            // FormRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(1205, 1050);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvUsuarios);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(foreverGroupBox1);
            Name = "FormRegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuarios";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private TextBox txtContrasena;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox cmbRol;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private TextBox textBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvUsuarios;
        private Label label6;
        private Label label7;
    }
}