namespace CPresentacion
{
    partial class FormObservacion
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
            label11 = new Label();
            label12 = new Label();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox3 = new ReaLTaiizor.Controls.ForeverGroupBox();
            lblFechaAtencion = new Label();
            lblNombre = new Label();
            lblPrioridad = new Label();
            txtObservaciones = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(95, 154, 162);
            label11.Location = new Point(51, 58);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(273, 18);
            label11.TabIndex = 34;
            label11.Text = "Información pasada del paciente y su turno";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 54, 60);
            label12.Location = new Point(43, 17);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(211, 39);
            label12.TabIndex = 35;
            label12.Text = "Observaciones";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(foreverGroupBox3);
            foreverGroupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreverGroupBox1.Location = new Point(43, 78);
            foreverGroupBox1.Margin = new Padding(2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(714, 335);
            foreverGroupBox1.TabIndex = 33;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // foreverGroupBox3
            // 
            foreverGroupBox3.ArrowColorF = Color.Transparent;
            foreverGroupBox3.ArrowColorH = Color.Transparent;
            foreverGroupBox3.BackColor = Color.Transparent;
            foreverGroupBox3.BaseColor = Color.White;
            foreverGroupBox3.Controls.Add(lblFechaAtencion);
            foreverGroupBox3.Controls.Add(lblNombre);
            foreverGroupBox3.Controls.Add(lblPrioridad);
            foreverGroupBox3.Controls.Add(txtObservaciones);
            foreverGroupBox3.Controls.Add(label8);
            foreverGroupBox3.Controls.Add(label2);
            foreverGroupBox3.Controls.Add(label1);
            foreverGroupBox3.Controls.Add(label4);
            foreverGroupBox3.Controls.Add(label7);
            foreverGroupBox3.Font = new Font("Segoe UI", 10F);
            foreverGroupBox3.Location = new Point(26, 25);
            foreverGroupBox3.Margin = new Padding(2);
            foreverGroupBox3.Name = "foreverGroupBox3";
            foreverGroupBox3.ShowArrow = true;
            foreverGroupBox3.ShowText = true;
            foreverGroupBox3.Size = new Size(654, 277);
            foreverGroupBox3.TabIndex = 41;
            foreverGroupBox3.TextColor = Color.Transparent;
            // 
            // lblFechaAtencion
            // 
            lblFechaAtencion.AutoSize = true;
            lblFechaAtencion.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaAtencion.ForeColor = Color.FromArgb(0, 51, 82);
            lblFechaAtencion.Location = new Point(493, 53);
            lblFechaAtencion.Margin = new Padding(2, 0, 2, 0);
            lblFechaAtencion.Name = "lblFechaAtencion";
            lblFechaAtencion.Size = new Size(48, 18);
            lblFechaAtencion.TabIndex = 46;
            lblFechaAtencion.Text = "FECHA";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(0, 51, 82);
            lblNombre.Location = new Point(24, 53);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 18);
            lblNombre.TabIndex = 46;
            lblNombre.Text = "NOMBRE";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrioridad.ForeColor = Color.FromArgb(0, 51, 82);
            lblPrioridad.Location = new Point(359, 53);
            lblPrioridad.Margin = new Padding(2, 0, 2, 0);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(77, 18);
            lblPrioridad.TabIndex = 46;
            lblPrioridad.Text = "PRIORIDAD";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BorderStyle = BorderStyle.None;
            txtObservaciones.Font = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservaciones.ForeColor = Color.FromArgb(4, 79, 86);
            txtObservaciones.Location = new Point(24, 103);
            txtObservaciones.Margin = new Padding(2);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Sin observaciones";
            txtObservaciones.ReadOnly = true;
            txtObservaciones.Size = new Size(580, 154);
            txtObservaciones.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(24, 88);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 14);
            label8.TabIndex = 44;
            label8.Text = "OBSERVACIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(95, 154, 162);
            label2.Location = new Point(24, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 13);
            label2.TabIndex = 42;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(95, 154, 162);
            label1.Location = new Point(493, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 13);
            label1.TabIndex = 42;
            label1.Text = "FECHA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(95, 154, 162);
            label4.Location = new Point(359, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 13);
            label4.TabIndex = 42;
            label4.Text = "PRIORIDAD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(24, 15);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 14);
            label7.TabIndex = 39;
            label7.Text = "INFO. DEL TURNO";
            // 
            // FormObservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(foreverGroupBox1);
            Name = "FormObservacion";
            Text = "FormObservacion";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox3.ResumeLayout(false);
            foreverGroupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label12;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox3;
        private Label lblPrioridad;
        private TextBox txtObservaciones;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label lblFechaAtencion;
        private Label label1;
        private Label lblNombre;
        private Label label2;
    }
}