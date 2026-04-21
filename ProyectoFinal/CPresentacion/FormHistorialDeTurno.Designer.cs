namespace CPresentacion
{
    partial class FormHistorialDeTurno
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
            dgvTurnos = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnExportar = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            txtFiltro = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTurnos
            // 
            dgvTurnos.BackgroundColor = Color.White;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(57, 292);
            dgvTurnos.Margin = new Padding(2);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 62;
            dgvTurnos.Size = new Size(699, 241);
            dgvTurnos.TabIndex = 46;
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
            iconButton2.Location = new Point(625, 55);
            iconButton2.Margin = new Padding(2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(25, 19);
            iconButton2.TabIndex = 45;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(608, 41);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(148, 46);
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
            btnExportar.TabIndex = 44;
            btnExportar.Values.DropDownArrowColor = Color.Empty;
            btnExportar.Values.Text = "Exportar ";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(btnLimpiar);
            foreverGroupBox1.Controls.Add(btnBuscar);
            foreverGroupBox1.Controls.Add(foreverGroupBox2);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(42, 91);
            foreverGroupBox1.Margin = new Padding(2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(714, 185);
            foreverGroupBox1.TabIndex = 43;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(436, 49);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 34);
            btnLimpiar.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnLimpiar.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnLimpiar.StateCommon.Back.ColorAngle = -2F;
            btnLimpiar.StateCommon.Border.Color1 = Color.Transparent;
            btnLimpiar.StateCommon.Border.Color2 = Color.Transparent;
            btnLimpiar.StateCommon.Border.Rounding = 20F;
            btnLimpiar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLimpiar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLimpiar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.TabIndex = 48;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "Limpiar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(556, 114);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 34);
            btnBuscar.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnBuscar.StateCommon.Back.Color2 = Color.FromArgb(0, 54, 60);
            btnBuscar.StateCommon.Back.ColorAngle = -2F;
            btnBuscar.StateCommon.Border.Color1 = Color.Transparent;
            btnBuscar.StateCommon.Border.Color2 = Color.Transparent;
            btnBuscar.StateCommon.Border.Rounding = 20F;
            btnBuscar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.TabIndex = 29;
            btnBuscar.Values.DropDownArrowColor = Color.Empty;
            btnBuscar.Values.Text = "Buscar";
            // 
            // foreverGroupBox2
            // 
            foreverGroupBox2.ArrowColorF = Color.Transparent;
            foreverGroupBox2.ArrowColorH = Color.Transparent;
            foreverGroupBox2.BackColor = Color.Transparent;
            foreverGroupBox2.BaseColor = Color.White;
            foreverGroupBox2.Controls.Add(txtFiltro);
            foreverGroupBox2.Controls.Add(iconButton1);
            foreverGroupBox2.Font = new Font("Segoe UI", 10F);
            foreverGroupBox2.Location = new Point(42, 112);
            foreverGroupBox2.Margin = new Padding(2);
            foreverGroupBox2.Name = "foreverGroupBox2";
            foreverGroupBox2.ShowArrow = true;
            foreverGroupBox2.ShowText = true;
            foreverGroupBox2.Size = new Size(510, 41);
            foreverGroupBox2.TabIndex = 29;
            foreverGroupBox2.TextColor = Color.Transparent;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.None;
            txtFiltro.Font = new Font("Corbel", 12F);
            txtFiltro.ForeColor = Color.FromArgb(4, 79, 86);
            txtFiltro.Location = new Point(39, 10);
            txtFiltro.Margin = new Padding(2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Nombre, apellido...";
            txtFiltro.Size = new Size(455, 20);
            txtFiltro.TabIndex = 38;
            // 
            // iconButton1
            // 
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.FromArgb(95, 154, 162);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(10, 10);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(25, 22);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(95, 154, 162);
            label4.Location = new Point(52, 97);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 13);
            label4.TabIndex = 36;
            label4.Text = "BUSCAR POR MEDICO O PACIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(29, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(265, 39);
            label6.TabIndex = 42;
            label6.Text = "Historial de Turnos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(42, 56);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(204, 18);
            label7.TabIndex = 47;
            label7.Text = "Visualización de turnos pasados";
            // 
            // FormHistorialDeTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(800, 541);
            Controls.Add(label7);
            Controls.Add(dgvTurnos);
            Controls.Add(iconButton2);
            Controls.Add(btnExportar);
            Controls.Add(foreverGroupBox1);
            Controls.Add(label6);
            Name = "FormHistorialDeTurno";
            Text = "FormHistorialDeTurno";
            Load += FormHistorialDeTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTurnos;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Krypton.Toolkit.KryptonButton btnExportar;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private TextBox txtFiltro;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label4;
        private Label label6;
        private Label label7;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
    }
}