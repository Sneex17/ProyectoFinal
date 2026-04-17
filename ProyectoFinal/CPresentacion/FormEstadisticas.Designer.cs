namespace CPresentacion
{
    partial class FormEstadisticas
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
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            label3 = new Label();
            cmbEspecialidades = new ReaLTaiizor.Controls.PoisonComboBox();
            dtpHasta = new ReaLTaiizor.Controls.PoisonDateTime();
            btnFiltro = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            dtpDesde = new ReaLTaiizor.Controls.PoisonDateTime();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox3 = new ReaLTaiizor.Controls.ForeverGroupBox();
            lblPacientes = new Label();
            label2 = new Label();
            foreverGroupBox4 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox5 = new ReaLTaiizor.Controls.ForeverGroupBox();
            lblEnEspera = new Label();
            label6 = new Label();
            foreverGroupBox6 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox7 = new ReaLTaiizor.Controls.ForeverGroupBox();
            lblEnAtencion = new Label();
            label8 = new Label();
            foreverGroupBox8 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox9 = new ReaLTaiizor.Controls.ForeverGroupBox();
            lblCanceladas = new Label();
            label10 = new Label();
            label7 = new Label();
            label4 = new Label();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            foreverGroupBox3.SuspendLayout();
            foreverGroupBox4.SuspendLayout();
            foreverGroupBox5.SuspendLayout();
            foreverGroupBox6.SuspendLayout();
            foreverGroupBox7.SuspendLayout();
            foreverGroupBox8.SuspendLayout();
            foreverGroupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(label3);
            foreverGroupBox1.Controls.Add(cmbEspecialidades);
            foreverGroupBox1.Controls.Add(dtpHasta);
            foreverGroupBox1.Controls.Add(btnFiltro);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Controls.Add(dtpDesde);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(55, 123);
            foreverGroupBox1.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(714, 130);
            foreverGroupBox1.TabIndex = 29;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(95, 154, 162);
            label3.Location = new Point(389, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 13);
            label3.TabIndex = 36;
            label3.Text = "ESPECIALIDAD";
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.BackColor = Color.White;
            cmbEspecialidades.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidades.ForeColor = Color.Black;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.ItemHeight = 22;
            cmbEspecialidades.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido" });
            cmbEspecialidades.Location = new Point(389, 58);
            cmbEspecialidades.Margin = new Padding(2, 2, 2, 2);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(132, 28);
            cmbEspecialidades.TabIndex = 35;
            cmbEspecialidades.UseCustomBackColor = true;
            cmbEspecialidades.UseCustomFont = true;
            cmbEspecialidades.UseCustomForeColor = true;
            cmbEspecialidades.UseSelectable = true;
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.CalendarForeColor = Color.FromArgb(4, 79, 86);
            dtpHasta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpHasta.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(224, 59);
            dtpHasta.Margin = new Padding(2, 2, 2, 2);
            dtpHasta.MinimumSize = new Size(0, 35);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.RightToLeft = RightToLeft.No;
            dtpHasta.Size = new Size(142, 35);
            dtpHasta.TabIndex = 38;
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(545, 52);
            btnFiltro.Margin = new Padding(2, 2, 2, 2);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(116, 29);
            btnFiltro.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnFiltro.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnFiltro.StateCommon.Back.ColorAngle = -2F;
            btnFiltro.StateCommon.Border.Color1 = Color.Transparent;
            btnFiltro.StateCommon.Border.Color2 = Color.Transparent;
            btnFiltro.StateCommon.Border.Rounding = 20F;
            btnFiltro.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltro.StateCommon.Content.ShortText.Color1 = Color.White;
            btnFiltro.StateCommon.Content.ShortText.Color2 = Color.White;
            btnFiltro.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltro.TabIndex = 29;
            btnFiltro.Values.DropDownArrowColor = Color.Empty;
            btnFiltro.Values.Text = "Buscar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(95, 154, 162);
            label1.Location = new Point(69, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 13);
            label1.TabIndex = 30;
            label1.Text = "FECHA DE FECHAS";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.CalendarForeColor = Color.FromArgb(4, 79, 86);
            dtpDesde.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpDesde.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(69, 59);
            dtpDesde.Margin = new Padding(2, 2, 2, 2);
            dtpDesde.MinimumSize = new Size(0, 35);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.RightToLeft = RightToLeft.No;
            dtpDesde.Size = new Size(142, 35);
            dtpDesde.TabIndex = 29;
            // 
            // foreverGroupBox2
            // 
            foreverGroupBox2.ArrowColorF = Color.Transparent;
            foreverGroupBox2.ArrowColorH = Color.Transparent;
            foreverGroupBox2.BackColor = Color.Transparent;
            foreverGroupBox2.BaseColor = Color.FromArgb(41, 103, 111);
            foreverGroupBox2.Controls.Add(foreverGroupBox3);
            foreverGroupBox2.Font = new Font("Segoe UI", 10F);
            foreverGroupBox2.Location = new Point(93, 257);
            foreverGroupBox2.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox2.Name = "foreverGroupBox2";
            foreverGroupBox2.ShowArrow = true;
            foreverGroupBox2.ShowText = true;
            foreverGroupBox2.Size = new Size(159, 89);
            foreverGroupBox2.TabIndex = 39;
            foreverGroupBox2.TextColor = Color.Transparent;
            // 
            // foreverGroupBox3
            // 
            foreverGroupBox3.ArrowColorF = Color.Transparent;
            foreverGroupBox3.ArrowColorH = Color.Transparent;
            foreverGroupBox3.BackColor = Color.Transparent;
            foreverGroupBox3.BaseColor = Color.White;
            foreverGroupBox3.Controls.Add(lblPacientes);
            foreverGroupBox3.Controls.Add(label2);
            foreverGroupBox3.Font = new Font("Segoe UI", 10F);
            foreverGroupBox3.Location = new Point(10, 0);
            foreverGroupBox3.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox3.Name = "foreverGroupBox3";
            foreverGroupBox3.ShowArrow = true;
            foreverGroupBox3.ShowText = true;
            foreverGroupBox3.Size = new Size(148, 89);
            foreverGroupBox3.TabIndex = 40;
            foreverGroupBox3.TextColor = Color.Transparent;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.FromArgb(0, 51, 82);
            lblPacientes.Location = new Point(24, 37);
            lblPacientes.Margin = new Padding(2, 0, 2, 0);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(39, 46);
            lblPacientes.TabIndex = 40;
            lblPacientes.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(24, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 39;
            label2.Text = "PACIENTES ";
            // 
            // foreverGroupBox4
            // 
            foreverGroupBox4.ArrowColorF = Color.Transparent;
            foreverGroupBox4.ArrowColorH = Color.Transparent;
            foreverGroupBox4.BackColor = Color.Transparent;
            foreverGroupBox4.BaseColor = Color.FromArgb(68, 128, 136);
            foreverGroupBox4.Controls.Add(foreverGroupBox5);
            foreverGroupBox4.Font = new Font("Segoe UI", 10F);
            foreverGroupBox4.Location = new Point(256, 257);
            foreverGroupBox4.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox4.Name = "foreverGroupBox4";
            foreverGroupBox4.ShowArrow = true;
            foreverGroupBox4.ShowText = true;
            foreverGroupBox4.Size = new Size(159, 89);
            foreverGroupBox4.TabIndex = 40;
            foreverGroupBox4.TextColor = Color.Transparent;
            // 
            // foreverGroupBox5
            // 
            foreverGroupBox5.ArrowColorF = Color.Transparent;
            foreverGroupBox5.ArrowColorH = Color.Transparent;
            foreverGroupBox5.BackColor = Color.Transparent;
            foreverGroupBox5.BaseColor = Color.White;
            foreverGroupBox5.Controls.Add(lblEnEspera);
            foreverGroupBox5.Controls.Add(label6);
            foreverGroupBox5.Font = new Font("Segoe UI", 10F);
            foreverGroupBox5.Location = new Point(10, 0);
            foreverGroupBox5.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox5.Name = "foreverGroupBox5";
            foreverGroupBox5.ShowArrow = true;
            foreverGroupBox5.ShowText = true;
            foreverGroupBox5.Size = new Size(148, 89);
            foreverGroupBox5.TabIndex = 40;
            foreverGroupBox5.TextColor = Color.Transparent;
            // 
            // lblEnEspera
            // 
            lblEnEspera.AutoSize = true;
            lblEnEspera.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnEspera.ForeColor = Color.FromArgb(0, 51, 82);
            lblEnEspera.Location = new Point(24, 37);
            lblEnEspera.Margin = new Padding(2, 0, 2, 0);
            lblEnEspera.Name = "lblEnEspera";
            lblEnEspera.Size = new Size(39, 46);
            lblEnEspera.TabIndex = 40;
            lblEnEspera.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(24, 15);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 39;
            label6.Text = "EN ESPERA";
            // 
            // foreverGroupBox6
            // 
            foreverGroupBox6.ArrowColorF = Color.Transparent;
            foreverGroupBox6.ArrowColorH = Color.Transparent;
            foreverGroupBox6.BackColor = Color.Transparent;
            foreverGroupBox6.BaseColor = Color.FromArgb(149, 208, 217);
            foreverGroupBox6.Controls.Add(foreverGroupBox7);
            foreverGroupBox6.Font = new Font("Segoe UI", 10F);
            foreverGroupBox6.Location = new Point(419, 257);
            foreverGroupBox6.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox6.Name = "foreverGroupBox6";
            foreverGroupBox6.ShowArrow = true;
            foreverGroupBox6.ShowText = true;
            foreverGroupBox6.Size = new Size(159, 89);
            foreverGroupBox6.TabIndex = 41;
            foreverGroupBox6.TextColor = Color.Transparent;
            // 
            // foreverGroupBox7
            // 
            foreverGroupBox7.ArrowColorF = Color.Transparent;
            foreverGroupBox7.ArrowColorH = Color.Transparent;
            foreverGroupBox7.BackColor = Color.Transparent;
            foreverGroupBox7.BaseColor = Color.White;
            foreverGroupBox7.Controls.Add(lblEnAtencion);
            foreverGroupBox7.Controls.Add(label8);
            foreverGroupBox7.Font = new Font("Segoe UI", 10F);
            foreverGroupBox7.Location = new Point(10, 0);
            foreverGroupBox7.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox7.Name = "foreverGroupBox7";
            foreverGroupBox7.ShowArrow = true;
            foreverGroupBox7.ShowText = true;
            foreverGroupBox7.Size = new Size(148, 89);
            foreverGroupBox7.TabIndex = 40;
            foreverGroupBox7.TextColor = Color.Transparent;
            // 
            // lblEnAtencion
            // 
            lblEnAtencion.AutoSize = true;
            lblEnAtencion.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnAtencion.ForeColor = Color.FromArgb(0, 51, 82);
            lblEnAtencion.Location = new Point(24, 37);
            lblEnAtencion.Margin = new Padding(2, 0, 2, 0);
            lblEnAtencion.Name = "lblEnAtencion";
            lblEnAtencion.Size = new Size(39, 46);
            lblEnAtencion.TabIndex = 40;
            lblEnAtencion.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(24, 15);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(86, 17);
            label8.TabIndex = 39;
            label8.Text = "EN ATENCIÓN";
            // 
            // foreverGroupBox8
            // 
            foreverGroupBox8.ArrowColorF = Color.Transparent;
            foreverGroupBox8.ArrowColorH = Color.Transparent;
            foreverGroupBox8.BackColor = Color.Transparent;
            foreverGroupBox8.BaseColor = Color.FromArgb(255, 192, 192);
            foreverGroupBox8.Controls.Add(foreverGroupBox9);
            foreverGroupBox8.Font = new Font("Segoe UI", 10F);
            foreverGroupBox8.Location = new Point(582, 257);
            foreverGroupBox8.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox8.Name = "foreverGroupBox8";
            foreverGroupBox8.ShowArrow = true;
            foreverGroupBox8.ShowText = true;
            foreverGroupBox8.Size = new Size(159, 89);
            foreverGroupBox8.TabIndex = 42;
            foreverGroupBox8.TextColor = Color.Transparent;
            // 
            // foreverGroupBox9
            // 
            foreverGroupBox9.ArrowColorF = Color.Transparent;
            foreverGroupBox9.ArrowColorH = Color.Transparent;
            foreverGroupBox9.BackColor = Color.Transparent;
            foreverGroupBox9.BaseColor = Color.White;
            foreverGroupBox9.Controls.Add(lblCanceladas);
            foreverGroupBox9.Controls.Add(label10);
            foreverGroupBox9.Font = new Font("Segoe UI", 10F);
            foreverGroupBox9.Location = new Point(10, 0);
            foreverGroupBox9.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox9.Name = "foreverGroupBox9";
            foreverGroupBox9.ShowArrow = true;
            foreverGroupBox9.ShowText = true;
            foreverGroupBox9.Size = new Size(148, 89);
            foreverGroupBox9.TabIndex = 40;
            foreverGroupBox9.TextColor = Color.Transparent;
            // 
            // lblCanceladas
            // 
            lblCanceladas.AutoSize = true;
            lblCanceladas.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCanceladas.ForeColor = Color.FromArgb(0, 51, 82);
            lblCanceladas.Location = new Point(24, 37);
            lblCanceladas.Margin = new Padding(2, 0, 2, 0);
            lblCanceladas.Name = "lblCanceladas";
            lblCanceladas.Size = new Size(39, 46);
            lblCanceladas.TabIndex = 40;
            lblCanceladas.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(24, 15);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(84, 17);
            label10.TabIndex = 39;
            label10.Text = "CANCELADAS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(43, 88);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(471, 18);
            label7.TabIndex = 43;
            label7.Text = "Vea las métricas del sistema importantes con filtros de fecha y especialidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 54, 60);
            label4.Location = new Point(35, 47);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(332, 39);
            label4.TabIndex = 44;
            label4.Text = "Estadísticas del Sistema";
            // 
            // FormEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(844, 449);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(foreverGroupBox8);
            Controls.Add(foreverGroupBox6);
            Controls.Add(foreverGroupBox4);
            Controls.Add(foreverGroupBox2);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormEstadisticas";
            Text = "FormEstadisticas";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox3.ResumeLayout(false);
            foreverGroupBox3.PerformLayout();
            foreverGroupBox4.ResumeLayout(false);
            foreverGroupBox5.ResumeLayout(false);
            foreverGroupBox5.PerformLayout();
            foreverGroupBox6.ResumeLayout(false);
            foreverGroupBox7.ResumeLayout(false);
            foreverGroupBox7.PerformLayout();
            foreverGroupBox8.ResumeLayout(false);
            foreverGroupBox9.ResumeLayout(false);
            foreverGroupBox9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.PoisonDateTime dtpHasta;
        private Krypton.Toolkit.KryptonButton btnFiltro;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtpDesde;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox3;
        private Label label2;
        private Label lblPacientes;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox4;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox5;
        private Label lblEnEspera;
        private Label label6;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox6;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox7;
        private Label lblEnAtencion;
        private Label label8;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox8;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox9;
        private Label lblCanceladas;
        private Label label10;
        private Label label7;
        private Label label4;
    }
}