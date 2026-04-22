namespace CPresentacion
{
    partial class FormDatosPaciente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new ReaLTaiizor.Controls.PoisonDateTime();
            cmbSexo = new ReaLTaiizor.Controls.PoisonComboBox();
            txtDireccion = new TextBox();
            txtSeguro = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(21, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 0;
            label1.Text = "CÉDULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(21, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 79, 86);
            label3.Location = new Point(21, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 4;
            label3.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 79, 86);
            label4.Location = new Point(21, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 19);
            label4.TabIndex = 6;
            label4.Text = "FECHA NACIMIENTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 79, 86);
            label5.Location = new Point(21, 177);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 8;
            label5.Text = "SEXO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 79, 86);
            label6.Location = new Point(21, 222);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 10;
            label6.Text = "DIRECCIÓN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(4, 79, 86);
            label7.Location = new Point(21, 261);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 12;
            label7.Text = "SEGURO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(4, 79, 86);
            label8.Location = new Point(21, 300);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 14;
            label8.Text = "CORREO";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Corbel", 11F);
            txtCedula.Location = new Point(21, 33);
            txtCedula.Margin = new Padding(2, 2, 2, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(211, 25);
            txtCedula.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Corbel", 11F);
            txtNombre.Location = new Point(21, 72);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 25);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Corbel", 11F);
            txtApellido.Location = new Point(21, 111);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 25);
            txtApellido.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.BackColor = Color.FromArgb(218, 248, 226);
            dtpFechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFechaNacimiento.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpFechaNacimiento.Location = new Point(21, 150);
            dtpFechaNacimiento.Margin = new Padding(2, 2, 2, 2);
            dtpFechaNacimiento.MinimumSize = new Size(0, 29);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(141, 29);
            dtpFechaNacimiento.TabIndex = 7;
            dtpFechaNacimiento.UseCustomBackColor = true;
            // 
            // cmbSexo
            // 
            cmbSexo.BackColor = Color.FromArgb(218, 248, 226);
            cmbSexo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbSexo.ForeColor = Color.Black;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.ItemHeight = 23;
            cmbSexo.Items.AddRange(new object[] { "M", "F" });
            cmbSexo.Location = new Point(21, 192);
            cmbSexo.Margin = new Padding(2, 2, 2, 2);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(71, 29);
            cmbSexo.TabIndex = 9;
            cmbSexo.UseCustomBackColor = true;
            cmbSexo.UseSelectable = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Corbel", 11F);
            txtDireccion.Location = new Point(21, 237);
            txtDireccion.Margin = new Padding(2, 2, 2, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 25);
            txtDireccion.TabIndex = 11;
            // 
            // txtSeguro
            // 
            txtSeguro.Font = new Font("Corbel", 11F);
            txtSeguro.Location = new Point(21, 276);
            txtSeguro.Margin = new Padding(2, 2, 2, 2);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(211, 25);
            txtSeguro.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Corbel", 11F);
            txtCorreo.Location = new Point(21, 315);
            txtCorreo.Margin = new Padding(2, 2, 2, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(211, 25);
            txtCorreo.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Location = new Point(56, 348);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 27);
            btnGuardar.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnGuardar.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            btnGuardar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGuardar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold);
            btnGuardar.TabIndex = 16;
            btnGuardar.Values.DropDownArrowColor = Color.Empty;
            btnGuardar.Values.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(154, 348);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 27);
            btnCancelar.StateCommon.Back.Color1 = Color.IndianRed;
            btnCancelar.StateCommon.Back.Color2 = Color.Brown;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold);
            btnCancelar.TabIndex = 17;
            btnCancelar.Values.DropDownArrowColor = Color.Empty;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormDatosPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(259, 390);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(label8);
            Controls.Add(txtSeguro);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(cmbSexo);
            Controls.Add(label5);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCedula);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormDatosPaciente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Datos del Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaNacimiento;
        private ReaLTaiizor.Controls.PoisonComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtCorreo;
        private Krypton.Toolkit.KryptonButton btnGuardar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
    }
}