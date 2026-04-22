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
            foreverGroupBox10 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox11 = new ReaLTaiizor.Controls.ForeverGroupBox();
            lblAtendidos = new Label();
            lblAtendidosLabel = new Label();
            foreverGroupBox12 = new ReaLTaiizor.Controls.ForeverGroupBox();
            dgvEstadisticas = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnExportar = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            foreverGroupBox3.SuspendLayout();
            foreverGroupBox4.SuspendLayout();
            foreverGroupBox5.SuspendLayout();
            foreverGroupBox6.SuspendLayout();
            foreverGroupBox7.SuspendLayout();
            foreverGroupBox8.SuspendLayout();
            foreverGroupBox9.SuspendLayout();
            foreverGroupBox10.SuspendLayout();
            foreverGroupBox11.SuspendLayout();
            foreverGroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).BeginInit();
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
            btnFiltro.Cursor = Cursors.Hand;
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
            foreverGroupBox2.Location = new Point(8, 257);
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
            foreverGroupBox3.Size = new Size(149, 89);
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
            foreverGroupBox4.Location = new Point(172, 257);
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
            foreverGroupBox5.Size = new Size(154, 89);
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
            foreverGroupBox6.Location = new Point(335, 257);
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
            foreverGroupBox7.Size = new Size(149, 89);
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
            foreverGroupBox8.Location = new Point(497, 257);
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
            foreverGroupBox9.Size = new Size(152, 89);
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
            // foreverGroupBox10
            // 
            foreverGroupBox10.ArrowColorF = Color.Transparent;
            foreverGroupBox10.ArrowColorH = Color.Transparent;
            foreverGroupBox10.BackColor = Color.Transparent;
            foreverGroupBox10.BaseColor = Color.FromArgb(144, 238, 144);
            foreverGroupBox10.Controls.Add(foreverGroupBox11);
            foreverGroupBox10.Font = new Font("Segoe UI", 10F);
            foreverGroupBox10.Location = new Point(663, 257);
            foreverGroupBox10.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox10.Name = "foreverGroupBox10";
            foreverGroupBox10.ShowArrow = true;
            foreverGroupBox10.ShowText = true;
            foreverGroupBox10.Size = new Size(159, 89);
            foreverGroupBox10.TabIndex = 44;
            foreverGroupBox10.TextColor = Color.Transparent;
            // 
            // foreverGroupBox11
            // 
            foreverGroupBox11.ArrowColorF = Color.Transparent;
            foreverGroupBox11.ArrowColorH = Color.Transparent;
            foreverGroupBox11.BackColor = Color.Transparent;
            foreverGroupBox11.BaseColor = Color.White;
            foreverGroupBox11.Controls.Add(lblAtendidos);
            foreverGroupBox11.Controls.Add(lblAtendidosLabel);
            foreverGroupBox11.Font = new Font("Segoe UI", 10F);
            foreverGroupBox11.Location = new Point(10, 0);
            foreverGroupBox11.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox11.Name = "foreverGroupBox11";
            foreverGroupBox11.ShowArrow = true;
            foreverGroupBox11.ShowText = true;
            foreverGroupBox11.Size = new Size(162, 89);
            foreverGroupBox11.TabIndex = 45;
            foreverGroupBox11.TextColor = Color.Transparent;
            // 
            // lblAtendidos
            // 
            lblAtendidos.AutoSize = true;
            lblAtendidos.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtendidos.ForeColor = Color.FromArgb(0, 51, 82);
            lblAtendidos.Location = new Point(24, 37);
            lblAtendidos.Margin = new Padding(2, 0, 2, 0);
            lblAtendidos.Name = "lblAtendidos";
            lblAtendidos.Size = new Size(39, 46);
            lblAtendidos.TabIndex = 46;
            lblAtendidos.Text = "0";
            // 
            // lblAtendidosLabel
            // 
            lblAtendidosLabel.AutoSize = true;
            lblAtendidosLabel.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtendidosLabel.ForeColor = Color.Silver;
            lblAtendidosLabel.Location = new Point(24, 15);
            lblAtendidosLabel.Margin = new Padding(2, 0, 2, 0);
            lblAtendidosLabel.Name = "lblAtendidosLabel";
            lblAtendidosLabel.Size = new Size(76, 17);
            lblAtendidosLabel.TabIndex = 47;
            lblAtendidosLabel.Text = "ATENDIDOS";
            // 
            // foreverGroupBox12
            // 
            foreverGroupBox12.ArrowColorF = Color.Transparent;
            foreverGroupBox12.ArrowColorH = Color.Transparent;
            foreverGroupBox12.BackColor = Color.Transparent;
            foreverGroupBox12.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox12.Controls.Add(dgvEstadisticas);
            foreverGroupBox12.Font = new Font("Segoe UI", 10F);
            foreverGroupBox12.Location = new Point(55, 349);
            foreverGroupBox12.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox12.Name = "foreverGroupBox12";
            foreverGroupBox12.ShowArrow = true;
            foreverGroupBox12.ShowText = true;
            foreverGroupBox12.Size = new Size(714, 193);
            foreverGroupBox12.TabIndex = 45;
            foreverGroupBox12.TextColor = Color.Transparent;
            // 
            // dgvEstadisticas
            // 
            dgvEstadisticas.AllowUserToAddRows = false;
            dgvEstadisticas.AllowUserToDeleteRows = false;
            dgvEstadisticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstadisticas.BackgroundColor = Color.White;
            dgvEstadisticas.BorderStyle = BorderStyle.None;
            dgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadisticas.GridColor = Color.FromArgb(224, 224, 224);
            dgvEstadisticas.Location = new Point(20, 14);
            dgvEstadisticas.Margin = new Padding(2, 2, 2, 2);
            dgvEstadisticas.Name = "dgvEstadisticas";
            dgvEstadisticas.ReadOnly = true;
            dgvEstadisticas.RowHeadersVisible = false;
            dgvEstadisticas.RowHeadersWidth = 62;
            dgvEstadisticas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstadisticas.Size = new Size(671, 156);
            dgvEstadisticas.TabIndex = 0;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(204, 234, 212);
            iconButton2.Enabled = false;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconButton2.IconColor = Color.FromArgb(0, 54, 60);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 26;
            iconButton2.Location = new Point(633, 79);
            iconButton2.Margin = new Padding(2, 2, 2, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(25, 19);
            iconButton2.TabIndex = 47;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(613, 65);
            btnExportar.Margin = new Padding(2, 2, 2, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(148, 47);
            btnExportar.StateCommon.Back.Color1 = Color.FromArgb(204, 234, 212);
            btnExportar.StateCommon.Back.Color2 = Color.FromArgb(204, 234, 212);
            btnExportar.StateCommon.Back.ColorAngle = -2F;
            btnExportar.StateCommon.Border.Color1 = Color.Transparent;
            btnExportar.StateCommon.Border.Color2 = Color.Transparent;
            btnExportar.StateCommon.Border.Rounding = 20F;
            btnExportar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 54, 60);
            btnExportar.StateCommon.Content.ShortText.Color2 = Color.FromArgb(0, 54, 60);
            btnExportar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.TabIndex = 46;
            btnExportar.Values.DropDownArrowColor = Color.Empty;
            btnExportar.Values.Text = "Exportar ";
            // 
            // FormEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(844, 630);
            Controls.Add(iconButton2);
            Controls.Add(foreverGroupBox12);
            Controls.Add(label7);
            Controls.Add(btnExportar);
            Controls.Add(label4);
            Controls.Add(foreverGroupBox10);
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
            foreverGroupBox10.ResumeLayout(false);
            foreverGroupBox11.ResumeLayout(false);
            foreverGroupBox11.PerformLayout();
            foreverGroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).EndInit();
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
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox10;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox11;
        private Label lblAtendidos;
        private Label lblAtendidosLabel;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox12;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Krypton.Toolkit.KryptonButton btnExportar;
        private DataGridView dgvEstadisticas;
    }
}