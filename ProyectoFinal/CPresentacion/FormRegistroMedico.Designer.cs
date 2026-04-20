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
            label7 = new Label();
            label6 = new Label();
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
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            label3 = new Label();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNombre = new TextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNLicencia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvMedicos = new DataGridView();
            foreverGroupBox1.SuspendLayout();
            parrotGroupBox5.SuspendLayout();
            parrotGroupBox6.SuspendLayout();
            parrotGroupBox7.SuspendLayout();
            parrotGroupBox4.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(62, 102);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(364, 23);
            label7.TabIndex = 17;
            label7.Text = "Registro y consulta de médicos en el sistema";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(53, 50);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(359, 49);
            label6.TabIndex = 18;
            label6.Text = "Registro de Médicos";
            // 
            // BuDesactivar
            // 
            BuDesactivar.Location = new Point(212, 644);
            BuDesactivar.Margin = new Padding(2, 2, 2, 2);
            BuDesactivar.Name = "BuDesactivar";
            BuDesactivar.Size = new Size(114, 68);
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
            BuDesactivar.Click += BuDesactivar_Click;
            // 
            // BuEditar
            // 
            BuEditar.Location = new Point(340, 644);
            BuEditar.Margin = new Padding(2, 2, 2, 2);
            BuEditar.Name = "BuEditar";
            BuEditar.Size = new Size(114, 68);
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
            BuCrear.Location = new Point(469, 644);
            BuCrear.Margin = new Padding(2, 2, 2, 2);
            BuCrear.Name = "BuCrear";
            BuCrear.Size = new Size(114, 68);
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
            foreverGroupBox1.Controls.Add(cmbEspecialidades);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(parrotGroupBox2);
            foreverGroupBox1.Controls.Add(parrotGroupBox1);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(53, 158);
            foreverGroupBox1.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(708, 482);
            foreverGroupBox1.TabIndex = 12;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // parrotGroupBox5
            // 
            parrotGroupBox5.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox5.BorderWidth = 3;
            parrotGroupBox5.Controls.Add(textBox2);
            parrotGroupBox5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox5.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox5.Location = new Point(380, 266);
            parrotGroupBox5.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox5.Name = "parrotGroupBox5";
            parrotGroupBox5.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox5.ShowText = true;
            parrotGroupBox5.Size = new Size(282, 54);
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
            textBox2.Location = new Point(10, 22);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Confirmar contraseña";
            textBox2.Size = new Size(267, 25);
            textBox2.TabIndex = 1;
            // 
            // poisonComboBox1
            // 
            poisonComboBox1.BackColor = Color.FromArgb(218, 248, 226);
            poisonComboBox1.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poisonComboBox1.ForeColor = Color.Black;
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 27;
            poisonComboBox1.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            poisonComboBox1.Location = new Point(526, 388);
            poisonComboBox1.Margin = new Padding(2, 2, 2, 2);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.Size = new Size(131, 33);
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
            label4.Location = new Point(526, 346);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 17;
            label4.Text = "ESTADO";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.FromArgb(218, 248, 226);
            cmbRol.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.ForeColor = Color.Black;
            cmbRol.FormattingEnabled = true;
            cmbRol.ItemHeight = 27;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Medico", "Recepcionista" });
            cmbRol.Location = new Point(380, 388);
            cmbRol.Margin = new Padding(2, 2, 2, 2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(131, 33);
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
            label5.Location = new Point(380, 346);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
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
            parrotGroupBox6.Location = new Point(380, 189);
            parrotGroupBox6.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox6.Name = "parrotGroupBox6";
            parrotGroupBox6.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox6.ShowText = true;
            parrotGroupBox6.Size = new Size(282, 54);
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
            txtContrasena.Location = new Point(13, 22);
            txtContrasena.Margin = new Padding(2, 2, 2, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(264, 25);
            txtContrasena.TabIndex = 1;
            // 
            // parrotGroupBox7
            // 
            parrotGroupBox7.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox7.BorderWidth = 3;
            parrotGroupBox7.Controls.Add(txtUsuario);
            parrotGroupBox7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox7.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox7.Location = new Point(380, 107);
            parrotGroupBox7.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox7.Name = "parrotGroupBox7";
            parrotGroupBox7.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox7.ShowText = true;
            parrotGroupBox7.Size = new Size(282, 54);
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
            txtUsuario.Location = new Point(13, 22);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ej: username";
            txtUsuario.Size = new Size(215, 25);
            txtUsuario.TabIndex = 1;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(4, 79, 86);
            label8.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(4, 79, 86);
            label8.Location = new Point(380, 42);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(8, 33);
            label8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(4, 79, 86);
            label9.Location = new Point(393, 42);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(235, 33);
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
            parrotGroupBox4.Location = new Point(45, 266);
            parrotGroupBox4.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox4.Name = "parrotGroupBox4";
            parrotGroupBox4.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox4.ShowText = true;
            parrotGroupBox4.Size = new Size(277, 54);
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
            txtApellido.Location = new Point(13, 22);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(259, 25);
            txtApellido.TabIndex = 1;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.BackColor = Color.FromArgb(218, 248, 226);
            cmbEspecialidades.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidades.ForeColor = Color.Black;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.ItemHeight = 27;
            cmbEspecialidades.Location = new Point(45, 382);
            cmbEspecialidades.Margin = new Padding(2, 2, 2, 2);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(278, 33);
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
            label3.Location = new Point(45, 346);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
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
            parrotGroupBox2.Location = new Point(45, 190);
            parrotGroupBox2.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(277, 54);
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
            txtNombre.Location = new Point(13, 22);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 25);
            txtNombre.TabIndex = 1;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.BorderWidth = 3;
            parrotGroupBox1.Controls.Add(txtNLicencia);
            parrotGroupBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Location = new Point(45, 106);
            parrotGroupBox1.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(277, 54);
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
            txtNLicencia.Location = new Point(13, 22);
            txtNLicencia.Margin = new Padding(2, 2, 2, 2);
            txtNLicencia.Name = "txtNLicencia";
            txtNLicencia.PlaceholderText = "Ej: LIC-000-2026";
            txtNLicencia.Size = new Size(259, 25);
            txtNLicencia.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(4, 79, 86);
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(45, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(8, 34);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(57, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 33);
            label1.TabIndex = 2;
            label1.Text = "Detalles de Médico";
            // 
            // dgvMedicos
            // 
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(777, 165);
            dgvMedicos.Margin = new Padding(2, 2, 2, 2);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.RowHeadersWidth = 62;
            dgvMedicos.Size = new Size(377, 474);
            dgvMedicos.TabIndex = 42;
            // 
            // FormRegistroMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(1163, 840);
            Controls.Add(dgvMedicos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BuDesactivar);
            Controls.Add(BuEditar);
            Controls.Add(BuCrear);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormRegistroMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistroMedico";
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
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Krypton.Toolkit.KryptonButton BuDesactivar;
        private Krypton.Toolkit.KryptonButton BuEditar;
        private Krypton.Toolkit.KryptonButton BuCrear;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private TextBox txtNombre;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private TextBox txtNLicencia;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private TextBox txtApellido;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private Label label3;
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
        private DataGridView dgvMedicos;
    }
}