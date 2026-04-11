namespace CPresentacion
{
    partial class FormBusquedaPaciente
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
            dgvPacientes = new DataGridView();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            txtFiltro = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(37, 68);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(243, 18);
            label7.TabIndex = 53;
            label7.Text = "Visualización de pacientes registrados";
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(37, 173);
            dgvPacientes.Margin = new Padding(2);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 62;
            dgvPacientes.Size = new Size(639, 241);
            dgvPacientes.TabIndex = 52;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(btnBuscar);
            foreverGroupBox1.Controls.Add(foreverGroupBox2);
            foreverGroupBox1.Controls.Add(label4);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(24, 103);
            foreverGroupBox1.Margin = new Padding(2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(652, 66);
            foreverGroupBox1.TabIndex = 49;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(527, 17);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 30);
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
            foreverGroupBox2.Location = new Point(13, 15);
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
            txtFiltro.Location = new Point(36, 10);
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
            label4.Location = new Point(49, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(24, 29);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(321, 39);
            label6.TabIndex = 48;
            label6.Text = "Busqueda de Pacientes";
            // 
            // FormBusquedaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(711, 452);
            Controls.Add(label7);
            Controls.Add(dgvPacientes);
            Controls.Add(foreverGroupBox1);
            Controls.Add(label6);
            Name = "FormBusquedaPaciente";
            Text = "FormBusquedaPaciente";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView dgvPacientes;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private TextBox txtFiltro;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label4;
        private Label label6;
    }
}