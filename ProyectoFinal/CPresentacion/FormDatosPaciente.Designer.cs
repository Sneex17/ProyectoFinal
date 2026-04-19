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
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 0;
            label1.Text = "CÉDULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 29);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 79, 86);
            label3.Location = new Point(30, 160);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 4;
            label3.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 79, 86);
            label4.Location = new Point(30, 225);
            label4.Name = "label4";
            label4.Size = new Size(216, 29);
            label4.TabIndex = 6;
            label4.Text = "FECHA NACIMIENTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 79, 86);
            label5.Location = new Point(30, 295);
            label5.Name = "label5";
            label5.Size = new Size(64, 29);
            label5.TabIndex = 8;
            label5.Text = "SEXO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 79, 86);
            label6.Location = new Point(30, 370);
            label6.Name = "label6";
            label6.Size = new Size(124, 29);
            label6.TabIndex = 10;
            label6.Text = "DIRECCIÓN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(4, 79, 86);
            label7.Location = new Point(30, 435);
            label7.Name = "label7";
            label7.Size = new Size(97, 29);
            label7.TabIndex = 12;
            label7.Text = "SEGURO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(4, 79, 86);
            label8.Location = new Point(30, 500);
            label8.Name = "label8";
            label8.Size = new Size(98, 29);
            label8.TabIndex = 14;
            label8.Text = "CORREO";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Corbel", 11F);
            txtCedula.Location = new Point(30, 55);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(300, 34);
            txtCedula.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Corbel", 11F);
            txtNombre.Location = new Point(30, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 34);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Corbel", 11F);
            txtApellido.Location = new Point(30, 185);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 34);
            txtApellido.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.BackColor = Color.FromArgb(218, 248, 226);
            dtpFechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFechaNacimiento.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpFechaNacimiento.Location = new Point(30, 250);
            dtpFechaNacimiento.MinimumSize = new Size(0, 29);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 34);
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
            cmbSexo.Location = new Point(30, 320);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(100, 29);
            cmbSexo.TabIndex = 9;
            cmbSexo.UseCustomBackColor = true;
            cmbSexo.UseSelectable = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Corbel", 11F);
            txtDireccion.Location = new Point(30, 395);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 34);
            txtDireccion.TabIndex = 11;
            // 
            // txtSeguro
            // 
            txtSeguro.Font = new Font("Corbel", 11F);
            txtSeguro.Location = new Point(30, 460);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(300, 34);
            txtSeguro.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Corbel", 11F);
            txtCorreo.Location = new Point(30, 525);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(300, 34);
            txtCorreo.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(80, 580);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 45);
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
            btnCancelar.Location = new Point(220, 580);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 45);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(370, 650);
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