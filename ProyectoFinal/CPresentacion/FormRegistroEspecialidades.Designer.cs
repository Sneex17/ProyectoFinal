namespace CPresentacion
{
    partial class FormRegistroEspecialidades
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
            btnEliminar = new Krypton.Toolkit.KryptonButton();
            btnEditar = new Krypton.Toolkit.KryptonButton();
            btnCrear = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtDescripcion = new TextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNombreEspecialidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvEspecialidades = new DataGridView();
            EspecialidadId = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            foreverGroupBox1.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(95, 154, 162);
            label7.Location = new Point(54, 77);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(323, 18);
            label7.TabIndex = 24;
            label7.Text = "Registro y consulta de especialidades en el sistema";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(46, 37);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(367, 39);
            label6.TabIndex = 25;
            label6.Text = "Registro de Especialidades";
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(54, 542);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 51);
            btnEliminar.StateCommon.Back.Color1 = Color.IndianRed;
            btnEliminar.StateCommon.Back.Color2 = Color.Brown;
            btnEliminar.StateCommon.Back.ColorAngle = -2F;
            btnEliminar.StateCommon.Border.Color1 = Color.Transparent;
            btnEliminar.StateCommon.Border.Color2 = Color.Transparent;
            btnEliminar.StateCommon.Border.Rounding = 40F;
            btnEliminar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEliminar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEliminar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.TabIndex = 22;
            btnEliminar.Values.DropDownArrowColor = Color.Empty;
            btnEliminar.Values.Text = "Desactivar";
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(172, 542);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 51);
            btnEditar.StateCommon.Back.Color1 = Color.FromArgb(254, 219, 151);
            btnEditar.StateCommon.Back.Color2 = Color.FromArgb(254, 219, 151);
            btnEditar.StateCommon.Back.ColorAngle = -2F;
            btnEditar.StateCommon.Border.Color1 = Color.Transparent;
            btnEditar.StateCommon.Border.Color2 = Color.Transparent;
            btnEditar.StateCommon.Border.Rounding = 40F;
            btnEditar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.TabIndex = 21;
            btnEditar.Values.DropDownArrowColor = Color.Empty;
            btnEditar.Values.Text = "Editar";
            // 
            // btnCrear
            // 
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.Location = new Point(289, 542);
            btnCrear.Margin = new Padding(2, 2, 2, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(100, 51);
            btnCrear.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            btnCrear.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            btnCrear.StateCommon.Back.ColorAngle = -2F;
            btnCrear.StateCommon.Border.Color1 = Color.Transparent;
            btnCrear.StateCommon.Border.Color2 = Color.Transparent;
            btnCrear.StateCommon.Border.Rounding = 40F;
            btnCrear.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCrear.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCrear.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.TabIndex = 20;
            btnCrear.Values.DropDownArrowColor = Color.Empty;
            btnCrear.Values.Text = "Crear";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Transparent;
            foreverGroupBox1.ArrowColorH = Color.Transparent;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.White;
            foreverGroupBox1.Controls.Add(parrotGroupBox3);
            foreverGroupBox1.Controls.Add(parrotGroupBox1);
            foreverGroupBox1.Controls.Add(label2);
            foreverGroupBox1.Controls.Add(label1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(46, 118);
            foreverGroupBox1.Margin = new Padding(2, 2, 2, 2);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(356, 421);
            foreverGroupBox1.TabIndex = 19;
            foreverGroupBox1.TextColor = Color.Transparent;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.BorderWidth = 3;
            parrotGroupBox3.Controls.Add(txtDescripcion);
            parrotGroupBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox3.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox3.Location = new Point(39, 139);
            parrotGroupBox3.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(275, 264);
            parrotGroupBox3.TabIndex = 10;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "DESCRIPCIÓN";
            parrotGroupBox3.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Corbel", 12F);
            txtDescripcion.ForeColor = Color.FromArgb(4, 79, 86);
            txtDescripcion.Location = new Point(11, 17);
            txtDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Describa la especialidad médica";
            txtDescripcion.Size = new Size(254, 238);
            txtDescripcion.TabIndex = 40;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.BorderWidth = 3;
            parrotGroupBox1.Controls.Add(txtNombreEspecialidad);
            parrotGroupBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Location = new Point(39, 80);
            parrotGroupBox1.Margin = new Padding(2, 2, 2, 2);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(2, 2, 2, 2);
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(275, 41);
            parrotGroupBox1.TabIndex = 1;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "NOMBRE";
            parrotGroupBox1.TextColor = Color.FromArgb(4, 79, 86);
            // 
            // txtNombreEspecialidad
            // 
            txtNombreEspecialidad.BorderStyle = BorderStyle.None;
            txtNombreEspecialidad.Font = new Font("Corbel", 12F);
            txtNombreEspecialidad.ForeColor = Color.FromArgb(4, 79, 86);
            txtNombreEspecialidad.Location = new Point(11, 17);
            txtNombreEspecialidad.Margin = new Padding(2, 2, 2, 2);
            txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            txtNombreEspecialidad.PlaceholderText = "Ej: cardiología";
            txtNombreEspecialidad.Size = new Size(254, 20);
            txtNombreEspecialidad.TabIndex = 39;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(4, 79, 86);
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(39, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(7, 25);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(50, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 27);
            label1.TabIndex = 2;
            label1.Text = "Detalles de Especialidad";
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new DataGridViewColumn[] { EspecialidadId, Especialidad, Descripcion });
            dgvEspecialidades.Location = new Point(417, 118);
            dgvEspecialidades.Margin = new Padding(2, 2, 2, 2);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 62;
            dgvEspecialidades.Size = new Size(382, 421);
            dgvEspecialidades.TabIndex = 41;
            // 
            // EspecialidadId
            // 
            EspecialidadId.HeaderText = "EspecialidadId";
            EspecialidadId.MinimumWidth = 6;
            EspecialidadId.Name = "EspecialidadId";
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad";
            Especialidad.MinimumWidth = 6;
            Especialidad.Name = "Especialidad";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // FormRegistroEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(844, 624);
            Controls.Add(dgvEspecialidades);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormRegistroEspecialidades";
            Text = "FormRegistroEspecialidades";
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Krypton.Toolkit.KryptonButton btnEliminar;
        private Krypton.Toolkit.KryptonButton btnEditar;
        private Krypton.Toolkit.KryptonButton btnCrear;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private TextBox txtApellido;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.PoisonComboBox cmbUsuarios;
        private Label label4;
        private ReaLTaiizor.Controls.PoisonComboBox cmbEspecialidades;
        private Label label3;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private TextBox txtNombre;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtNombreEspecialidad;
        private DataGridView dgvEspecialidades;
        private DataGridViewTextBoxColumn EspecialidadId;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn Descripcion;
    }
}