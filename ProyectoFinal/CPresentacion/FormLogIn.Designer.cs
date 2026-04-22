namespace CPresentacion
{
    partial class FormLogIn
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
            grpbLogIn = new ReaLTaiizor.Controls.ForeverGroupBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNombreEspecialidad = new TextBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtDescripcion = new TextBox();
            label11 = new Label();
            label6 = new Label();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            grpbLogIn.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpbLogIn
            // 
            grpbLogIn.ArrowColorF = Color.Transparent;
            grpbLogIn.ArrowColorH = Color.Transparent;
            grpbLogIn.BackColor = Color.Transparent;
            grpbLogIn.BaseColor = Color.White;
            grpbLogIn.Controls.Add(kryptonButton1);
            grpbLogIn.Controls.Add(parrotGroupBox1);
            grpbLogIn.Controls.Add(parrotGroupBox3);
            grpbLogIn.Controls.Add(label11);
            grpbLogIn.Font = new Font("Segoe UI", 10F);
            grpbLogIn.Location = new Point(67, 105);
            grpbLogIn.Name = "grpbLogIn";
            grpbLogIn.ShowArrow = true;
            grpbLogIn.ShowText = true;
            grpbLogIn.Size = new Size(647, 530);
            grpbLogIn.TabIndex = 49;
            grpbLogIn.TextColor = Color.Transparent;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(236, 330);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(0, 51, 82);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(23, 74, 111);
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
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(0, 51, 82);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(23, 74, 111);
            kryptonButton1.TabIndex = 53;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Ingresar";
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BackColor = Color.Transparent;
            parrotGroupBox1.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.BorderWidth = 3;
            parrotGroupBox1.Controls.Add(txtNombreEspecialidad);
            parrotGroupBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Location = new Point(121, 125);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(393, 68);
            parrotGroupBox1.TabIndex = 51;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "USUARIO";
            parrotGroupBox1.TextColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Enter += parrotGroupBox1_Enter;
            // 
            // txtNombreEspecialidad
            // 
            txtNombreEspecialidad.BorderStyle = BorderStyle.None;
            txtNombreEspecialidad.Font = new Font("Corbel", 12F);
            txtNombreEspecialidad.ForeColor = Color.FromArgb(4, 79, 86);
            txtNombreEspecialidad.Location = new Point(16, 28);
            txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            txtNombreEspecialidad.PlaceholderText = "Ej: Manuel aka Fransisco";
            txtNombreEspecialidad.Size = new Size(363, 30);
            txtNombreEspecialidad.TabIndex = 39;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.BorderWidth = 3;
            parrotGroupBox3.Controls.Add(txtDescripcion);
            parrotGroupBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox3.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.Location = new Point(121, 217);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(393, 75);
            parrotGroupBox3.TabIndex = 52;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "CONTRASEÑA";
            parrotGroupBox3.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Corbel", 12F);
            txtDescripcion.ForeColor = Color.FromArgb(4, 79, 86);
            txtDescripcion.Location = new Point(16, 28);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '*';
            txtDescripcion.Size = new Size(363, 40);
            txtDescripcion.TabIndex = 40;
            txtDescripcion.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(95, 154, 162);
            label11.Location = new Point(223, 38);
            label11.Name = "label11";
            label11.Size = new Size(163, 59);
            label11.TabIndex = 30;
            label11.Text = "LOG IN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(240, 37);
            label6.Name = "label6";
            label6.Size = new Size(297, 59);
            label6.TabIndex = 50;
            label6.Text = "UCE MEDICAL";
            label6.Click += label6_Click;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(grpbLogIn);
            foreverGroupBox1.Controls.Add(label6);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(169, 18);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(777, 703);
            foreverGroupBox1.TabIndex = 54;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // FormLogIn
            // 
            AcceptButton = kryptonButton1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(1143, 750);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogIn";
            Load += FormLogIn_Load;
            grpbLogIn.ResumeLayout(false);
            grpbLogIn.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverGroupBox grpbLogIn;
        private Label label11;
        private Label label6;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private TextBox txtNombreEspecialidad;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private TextBox txtDescripcion;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
    }
}