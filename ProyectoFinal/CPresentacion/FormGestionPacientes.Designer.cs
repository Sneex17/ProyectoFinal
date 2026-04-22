namespace CPresentacion
{
    partial class FormGestionPacientes
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
            label6 = new Label();
            label7 = new Label();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnNuevo = new Krypton.Toolkit.KryptonButton();
            btnEditar = new Krypton.Toolkit.KryptonButton();
            btnEliminar = new Krypton.Toolkit.KryptonButton();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            btnPrimero = new Krypton.Toolkit.KryptonButton();
            btnAnterior = new Krypton.Toolkit.KryptonButton();
            btnSiguiente = new Krypton.Toolkit.KryptonButton();
            btnUltimo = new Krypton.Toolkit.KryptonButton();
            lblPagina = new Label();
            txtBuscar = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            foreverGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(36, 8);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(292, 39);
            label6.TabIndex = 27;
            label6.Text = "Gestión de Pacientes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(50, 48);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(197, 18);
            label7.TabIndex = 26;
            label7.Text = "CRUD de pacientes registrados";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(204, 234, 212);
            foreverGroupBox1.Controls.Add(btnNuevo);
            foreverGroupBox1.Controls.Add(btnEditar);
            foreverGroupBox1.Controls.Add(btnEliminar);
            foreverGroupBox1.Controls.Add(btnBuscar);
            foreverGroupBox1.Controls.Add(btnPrimero);
            foreverGroupBox1.Controls.Add(btnAnterior);
            foreverGroupBox1.Controls.Add(btnSiguiente);
            foreverGroupBox1.Controls.Add(btnUltimo);
            foreverGroupBox1.Controls.Add(lblPagina);
            foreverGroupBox1.Controls.Add(txtBuscar);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Controls.Add(dataGridView1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(50, 66);
            foreverGroupBox1.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(840, 510);
            foreverGroupBox1.TabIndex = 16;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Location = new Point(32, 35);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(105, 33);
            btnNuevo.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnNuevo.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            btnNuevo.StateCommon.Back.ColorAngle = -2F;
            btnNuevo.StateCommon.Border.Color1 = Color.Transparent;
            btnNuevo.StateCommon.Border.Color2 = Color.Transparent;
            btnNuevo.StateCommon.Border.Rounding = 20F;
            btnNuevo.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNuevo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNuevo.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.TabIndex = 40;
            btnNuevo.Values.DropDownArrowColor = Color.Empty;
            btnNuevo.Values.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(144, 35);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 33);
            btnEditar.StateCommon.Back.Color1 = Color.FromArgb(254, 219, 151);
            btnEditar.StateCommon.Back.Color2 = Color.FromArgb(254, 219, 151);
            btnEditar.StateCommon.Back.ColorAngle = -2F;
            btnEditar.StateCommon.Border.Color1 = Color.Transparent;
            btnEditar.StateCommon.Border.Color2 = Color.Transparent;
            btnEditar.StateCommon.Border.Rounding = 20F;
            btnEditar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.TabIndex = 41;
            btnEditar.Values.DropDownArrowColor = Color.Empty;
            btnEditar.Values.Text = "Editar";
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(256, 35);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 33);
            btnEliminar.StateCommon.Back.Color1 = Color.IndianRed;
            btnEliminar.StateCommon.Back.Color2 = Color.Brown;
            btnEliminar.StateCommon.Back.ColorAngle = -2F;
            btnEliminar.StateCommon.Border.Color1 = Color.Transparent;
            btnEliminar.StateCommon.Border.Color2 = Color.Transparent;
            btnEliminar.StateCommon.Border.Rounding = 20F;
            btnEliminar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEliminar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEliminar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.TabIndex = 42;
            btnEliminar.Values.DropDownArrowColor = Color.Empty;
            btnEliminar.Values.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(686, 35);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 33);
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
            btnBuscar.TabIndex = 43;
            btnBuscar.Values.DropDownArrowColor = Color.Empty;
            btnBuscar.Values.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnPrimero
            // 
            btnPrimero.Cursor = Cursors.Hand;
            btnPrimero.Location = new Point(32, 468);
            btnPrimero.Margin = new Padding(2, 2, 2, 2);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(56, 24);
            btnPrimero.StateCommon.Back.Color1 = Color.FromArgb(218, 248, 226);
            btnPrimero.StateCommon.Back.Color2 = Color.FromArgb(218, 248, 226);
            btnPrimero.StateCommon.Back.ColorAngle = -2F;
            btnPrimero.StateCommon.Border.Color1 = Color.FromArgb(0, 54, 60);
            btnPrimero.StateCommon.Border.Color2 = Color.Transparent;
            btnPrimero.StateCommon.Border.Rounding = 10F;
            btnPrimero.StateCommon.Content.LongText.Font = new Font("Corbel", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimero.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 54, 60);
            btnPrimero.StateCommon.Content.ShortText.Color2 = Color.FromArgb(0, 54, 60);
            btnPrimero.StateCommon.Content.ShortText.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimero.TabIndex = 44;
            btnPrimero.Values.DropDownArrowColor = Color.Empty;
            btnPrimero.Values.Text = "<<";
            btnPrimero.Click += btnPrimero_Click_1;
            // 
            // btnAnterior
            // 
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Location = new Point(94, 468);
            btnAnterior.Margin = new Padding(2, 2, 2, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(56, 24);
            btnAnterior.StateCommon.Back.Color1 = Color.FromArgb(218, 248, 226);
            btnAnterior.StateCommon.Back.Color2 = Color.FromArgb(218, 248, 226);
            btnAnterior.StateCommon.Back.ColorAngle = -2F;
            btnAnterior.StateCommon.Border.Color1 = Color.FromArgb(0, 54, 60);
            btnAnterior.StateCommon.Border.Color2 = Color.Transparent;
            btnAnterior.StateCommon.Border.Rounding = 10F;
            btnAnterior.StateCommon.Content.LongText.Font = new Font("Corbel", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 54, 60);
            btnAnterior.StateCommon.Content.ShortText.Color2 = Color.FromArgb(0, 54, 60);
            btnAnterior.StateCommon.Content.ShortText.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.TabIndex = 45;
            btnAnterior.Values.DropDownArrowColor = Color.Empty;
            btnAnterior.Values.Text = "<";
            btnAnterior.Click += btnAnterior_Click_1;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Location = new Point(672, 468);
            btnSiguiente.Margin = new Padding(2, 2, 2, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(56, 24);
            btnSiguiente.StateCommon.Back.Color1 = Color.FromArgb(218, 248, 226);
            btnSiguiente.StateCommon.Back.Color2 = Color.FromArgb(218, 248, 226);
            btnSiguiente.StateCommon.Back.ColorAngle = -2F;
            btnSiguiente.StateCommon.Border.Color1 = Color.FromArgb(0, 54, 60);
            btnSiguiente.StateCommon.Border.Color2 = Color.Transparent;
            btnSiguiente.StateCommon.Border.Rounding = 10F;
            btnSiguiente.StateCommon.Content.LongText.Font = new Font("Corbel", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 54, 60);
            btnSiguiente.StateCommon.Content.ShortText.Color2 = Color.FromArgb(0, 54, 60);
            btnSiguiente.StateCommon.Content.ShortText.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.TabIndex = 46;
            btnSiguiente.Values.DropDownArrowColor = Color.Empty;
            btnSiguiente.Values.Text = ">";
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // btnUltimo
            // 
            btnUltimo.Cursor = Cursors.Hand;
            btnUltimo.Location = new Point(735, 468);
            btnUltimo.Margin = new Padding(2, 2, 2, 2);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(56, 24);
            btnUltimo.StateCommon.Back.Color1 = Color.FromArgb(218, 248, 226);
            btnUltimo.StateCommon.Back.Color2 = Color.FromArgb(218, 248, 226);
            btnUltimo.StateCommon.Back.ColorAngle = -2F;
            btnUltimo.StateCommon.Border.Color1 = Color.FromArgb(0, 54, 60);
            btnUltimo.StateCommon.Border.Color2 = Color.Transparent;
            btnUltimo.StateCommon.Border.Rounding = 10F;
            btnUltimo.StateCommon.Content.LongText.Font = new Font("Corbel", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUltimo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 54, 60);
            btnUltimo.StateCommon.Content.ShortText.Color2 = Color.FromArgb(0, 54, 60);
            btnUltimo.StateCommon.Content.ShortText.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUltimo.TabIndex = 47;
            btnUltimo.Values.DropDownArrowColor = Color.Empty;
            btnUltimo.Values.Text = ">>";
            btnUltimo.Click += btnUltimo_Click;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPagina.ForeColor = Color.FromArgb(0, 54, 60);
            lblPagina.Location = new Point(378, 474);
            lblPagina.Margin = new Padding(2, 0, 2, 0);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(100, 19);
            lblPagina.TabIndex = 48;
            lblPagina.Text = "Página 1 de 1";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Corbel", 11F);
            txtBuscar.Location = new Point(536, 43);
            txtBuscar.Margin = new Padding(2, 2, 2, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre o cedula...";
            txtBuscar.Size = new Size(145, 25);
            txtBuscar.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(536, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 50;
            label1.Text = "BUSCAR";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 78);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(777, 378);
            dataGridView1.TabIndex = 51;
            // 
            // FormGestionPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(982, 630);
            Controls.Add(foreverGroupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormGestionPacientes";
            Text = "Gestión de Pacientes";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private Krypton.Toolkit.KryptonButton btnNuevo;
        private Krypton.Toolkit.KryptonButton btnEditar;
        private Krypton.Toolkit.KryptonButton btnEliminar;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonButton btnPrimero;
        private Krypton.Toolkit.KryptonButton btnAnterior;
        private Krypton.Toolkit.KryptonButton btnSiguiente;
        private Krypton.Toolkit.KryptonButton btnUltimo;
        private Label lblPagina;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dataGridView1;
    }
}