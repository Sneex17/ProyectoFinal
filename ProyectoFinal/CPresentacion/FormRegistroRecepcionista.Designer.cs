namespace CPresentacion
{
    partial class FormRegistroRecepcionista
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
            label6 = new Label();
            label7 = new Label();
            BuDesactivar = new Krypton.Toolkit.KryptonButton();
            BuEditar = new Krypton.Toolkit.KryptonButton();
            BuCrear = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            parrotGroupBox5 = new ReaLTaiizor.Controls.ParrotGroupBox();
            textBox2 = new TextBox();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            label4 = new Label();
            cmbRol = new ReaLTaiizor.Controls.PoisonComboBox();
            label5 = new Label();
            parrotGroupBox6 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtContrasena = new TextBox();
            parrotGroupBox7 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtUsuario = new TextBox();
            label8 = new Label();
            label9 = new Label();
            parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtApellido = new TextBox();
            cmbArea = new ReaLTaiizor.Controls.PoisonComboBox();
            label3 = new Label();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvRecepcionistas = new DataGridView();
            foreverGroupBox1.SuspendLayout();
            parrotGroupBox5.SuspendLayout();
            parrotGroupBox6.SuspendLayout();
            parrotGroupBox7.SuspendLayout();
            parrotGroupBox4.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecepcionistas).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(77, 36);
            label6.Name = "label6";
            label6.Size = new Size(534, 59);
            label6.TabIndex = 11;
            label6.Text = "Registro de Recepcionista";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(88, 104);
            label7.Name = "label7";
            label7.Size = new Size(474, 27);
            label7.TabIndex = 11;
            label7.Text = "Registro y consulta de recepcionistas en el sistema";
            // 
            // BuDesactivar
            // 
            BuDesactivar.Location = new Point(238, 782);
            BuDesactivar.Name = "BuDesactivar";
            BuDesactivar.Size = new Size(143, 85);
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
            BuDesactivar.TabIndex = 20;
            BuDesactivar.Values.DropDownArrowColor = Color.Empty;
            BuDesactivar.Values.Text = "Desactivar";
            // 
            // BuEditar
            // 
            BuEditar.Location = new Point(398, 782);
            BuEditar.Name = "BuEditar";
            BuEditar.Size = new Size(143, 85);
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
            BuEditar.TabIndex = 19;
            BuEditar.Values.DropDownArrowColor = Color.Empty;
            BuEditar.Values.Text = "Editar";
            // 
            // BuCrear
            // 
            BuCrear.Location = new Point(559, 782);
            BuCrear.Name = "BuCrear";
            BuCrear.Size = new Size(143, 85);
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
            BuCrear.TabIndex = 18;
            BuCrear.Values.DropDownArrowColor = Color.Empty;
            BuCrear.Values.Text = "Crear";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.White;
            foreverGroupBox1.Controls.Add(parrotGroupBox5);
            foreverGroupBox1.Controls.Add(poisonComboBox1);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Controls.Add(cmbRol);
            foreverGroupBox1.Controls.Add(label5);
            foreverGroupBox1.Controls.Add(parrotGroupBox6);
            foreverGroupBox1.Controls.Add(parrotGroupBox7);
            foreverGroupBox1.Controls.Add(label8);
            foreverGroupBox1.Controls.Add(label9);
            foreverGroupBox1.Controls.Add(parrotGroupBox4);
            foreverGroupBox1.Controls.Add(cmbArea);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(parrotGroupBox2);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(39, 174);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(885, 602);
            foreverGroupBox1.TabIndex = 17;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // parrotGroupBox5
            // 
            parrotGroupBox5.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox5.BorderWidth = 3;
            parrotGroupBox5.Controls.Add(textBox2);
            parrotGroupBox5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox5.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox5.Location = new Point(475, 333);
            parrotGroupBox5.Name = "parrotGroupBox5";
            parrotGroupBox5.ShowText = true;
            parrotGroupBox5.Size = new Size(352, 68);
            parrotGroupBox5.TabIndex = 19;
            parrotGroupBox5.TabStop = false;
            parrotGroupBox5.Text = "CONTRASEÑA";
            parrotGroupBox5.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Corbel", 12F);
            textBox2.ForeColor = Color.FromArgb(4, 79, 86);
            textBox2.Location = new Point(12, 28);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Confirmar contraseña";
            textBox2.Size = new Size(334, 30);
            textBox2.TabIndex = 1;
            // 
            // poisonComboBox1
            // 
            poisonComboBox1.BackColor = Color.FromArgb(218, 248, 226);
            poisonComboBox1.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poisonComboBox1.ForeColor = Color.Black;
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 31;
            poisonComboBox1.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            poisonComboBox1.Location = new Point(658, 485);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.Size = new Size(163, 37);
            poisonComboBox1.TabIndex = 18;
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
            label4.Location = new Point(658, 433);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 17;
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
            cmbRol.Location = new Point(475, 485);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(163, 37);
            cmbRol.TabIndex = 16;
            cmbRol.UseCustomBackColor = true;
            cmbRol.UseCustomFont = true;
            cmbRol.UseCustomForeColor = true;
            cmbRol.UseSelectable = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 79, 86);
            label5.Location = new Point(475, 433);
            label5.Name = "label5";
            label5.Size = new Size(48, 27);
            label5.TabIndex = 15;
            label5.Text = "ROL";
            // 
            // parrotGroupBox6
            // 
            parrotGroupBox6.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox6.BorderWidth = 3;
            parrotGroupBox6.Controls.Add(txtContrasena);
            parrotGroupBox6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox6.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox6.Location = new Point(475, 236);
            parrotGroupBox6.Name = "parrotGroupBox6";
            parrotGroupBox6.ShowText = true;
            parrotGroupBox6.Size = new Size(352, 68);
            parrotGroupBox6.TabIndex = 12;
            parrotGroupBox6.TabStop = false;
            parrotGroupBox6.Text = "CONTRASEÑA";
            parrotGroupBox6.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.FromArgb(4, 79, 86);
            txtContrasena.Location = new Point(16, 28);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(330, 30);
            txtContrasena.TabIndex = 1;
            // 
            // parrotGroupBox7
            // 
            parrotGroupBox7.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox7.BorderWidth = 3;
            parrotGroupBox7.Controls.Add(txtUsuario);
            parrotGroupBox7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox7.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox7.Location = new Point(475, 134);
            parrotGroupBox7.Name = "parrotGroupBox7";
            parrotGroupBox7.ShowText = true;
            parrotGroupBox7.Size = new Size(352, 68);
            parrotGroupBox7.TabIndex = 11;
            parrotGroupBox7.TabStop = false;
            parrotGroupBox7.Text = "USUARIO";
            parrotGroupBox7.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Corbel", 12F);
            txtUsuario.ForeColor = Color.FromArgb(4, 79, 86);
            txtUsuario.Location = new Point(16, 28);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ej: username";
            txtUsuario.Size = new Size(269, 30);
            txtUsuario.TabIndex = 1;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(4, 79, 86);
            label8.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(4, 79, 86);
            label8.Location = new Point(475, 52);
            label8.Name = "label8";
            label8.Size = new Size(10, 41);
            label8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(4, 79, 86);
            label9.Location = new Point(491, 52);
            label9.Name = "label9";
            label9.Size = new Size(275, 39);
            label9.TabIndex = 13;
            label9.Text = "Detalles de Usuario";
            // 
            // parrotGroupBox4
            // 
            parrotGroupBox4.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox4.BorderWidth = 3;
            parrotGroupBox4.Controls.Add(txtApellido);
            parrotGroupBox4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox4.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox4.Location = new Point(56, 230);
            parrotGroupBox4.Name = "parrotGroupBox4";
            parrotGroupBox4.ShowText = true;
            parrotGroupBox4.Size = new Size(346, 68);
            parrotGroupBox4.TabIndex = 3;
            parrotGroupBox4.TabStop = false;
            parrotGroupBox4.Text = "APELLIDO";
            parrotGroupBox4.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.ForeColor = Color.FromArgb(4, 79, 86);
            txtApellido.Location = new Point(16, 28);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(324, 30);
            txtApellido.TabIndex = 1;
            // 
            // cmbArea
            // 
            cmbArea.BackColor = Color.FromArgb(218, 248, 226);
            cmbArea.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbArea.ForeColor = Color.Black;
            cmbArea.FormattingEnabled = true;
            cmbArea.ItemHeight = 31;
            cmbArea.Location = new Point(56, 367);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(346, 37);
            cmbArea.TabIndex = 5;
            cmbArea.UseCustomBackColor = true;
            cmbArea.UseCustomFont = true;
            cmbArea.UseCustomForeColor = true;
            cmbArea.UseSelectable = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 79, 86);
            label3.Location = new Point(49, 322);
            label3.Name = "label3";
            label3.Size = new Size(61, 27);
            label3.TabIndex = 4;
            label3.Text = "ÁREA";
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox2.BorderWidth = 3;
            parrotGroupBox2.Controls.Add(txtNombre);
            parrotGroupBox2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox2.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox2.Location = new Point(56, 134);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(346, 68);
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
            txtNombre.Location = new Point(16, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 30);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(4, 79, 86);
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(56, 52);
            label2.Name = "label2";
            label2.Size = new Size(10, 42);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(71, 52);
            label1.Name = "label1";
            label1.Size = new Size(355, 39);
            label1.TabIndex = 2;
            label1.Text = "Detalles de Recepcionista";
            // 
            // dgvRecepcionistas
            // 
            dgvRecepcionistas.BackgroundColor = Color.White;
            dgvRecepcionistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecepcionistas.Location = new Point(951, 183);
            dgvRecepcionistas.Name = "dgvRecepcionistas";
            dgvRecepcionistas.RowHeadersWidth = 62;
            dgvRecepcionistas.Size = new Size(471, 593);
            dgvRecepcionistas.TabIndex = 43;
            // 
            // FormRegistroRecepcionista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(1454, 1050);
            Controls.Add(dgvRecepcionistas);
            Controls.Add(BuDesactivar);
            Controls.Add(BuEditar);
            Controls.Add(BuCrear);
            Controls.Add(foreverGroupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "FormRegistroRecepcionista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuarios";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            parrotGroupBox5.ResumeLayout(false);
            parrotGroupBox5.PerformLayout();
            parrotGroupBox6.ResumeLayout(false);
            parrotGroupBox6.PerformLayout();
            parrotGroupBox7.ResumeLayout(false);
            parrotGroupBox7.PerformLayout();
            parrotGroupBox4.ResumeLayout(false);
            parrotGroupBox4.PerformLayout();
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecepcionistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private Krypton.Toolkit.KryptonButton BuDesactivar;
        private Krypton.Toolkit.KryptonButton BuEditar;
        private Krypton.Toolkit.KryptonButton BuCrear;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox5;
        private TextBox textBox2;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private Label label4;
        private ReaLTaiizor.Controls.PoisonComboBox cmbRol;
        private Label label5;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox6;
        private TextBox txtContrasena;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox7;
        private TextBox txtUsuario;
        private Label label8;
        private Label label9;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private TextBox txtApellido;
        private ReaLTaiizor.Controls.PoisonComboBox cmbArea;
        private Label label3;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private DataGridView dgvRecepcionistas;
    }
}