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
            BnEliminar = new Krypton.Toolkit.KryptonButton();
            BnEditar = new Krypton.Toolkit.KryptonButton();
            BnCrear = new Krypton.Toolkit.KryptonButton();
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
            // BnEliminar
            // 
            BnEliminar.Location = new Point(54, 542);
            BnEliminar.Margin = new Padding(2);
            BnEliminar.Name = "BnEliminar";
            BnEliminar.Size = new Size(100, 51);
            BnEliminar.StateCommon.Back.Color1 = Color.IndianRed;
            BnEliminar.StateCommon.Back.Color2 = Color.Brown;
            BnEliminar.StateCommon.Back.ColorAngle = -2F;
            BnEliminar.StateCommon.Border.Color1 = Color.Transparent;
            BnEliminar.StateCommon.Border.Color2 = Color.Transparent;
            BnEliminar.StateCommon.Border.Rounding = 40F;
            BnEliminar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BnEliminar.StateCommon.Content.ShortText.Color1 = Color.White;
            BnEliminar.StateCommon.Content.ShortText.Color2 = Color.White;
            BnEliminar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BnEliminar.TabIndex = 22;
            BnEliminar.Values.DropDownArrowColor = Color.Empty;
            BnEliminar.Values.Text = "Desactivar";
            // 
            // BnEditar
            // 
            BnEditar.Location = new Point(172, 542);
            BnEditar.Margin = new Padding(2);
            BnEditar.Name = "BnEditar";
            BnEditar.Size = new Size(100, 51);
            BnEditar.StateCommon.Back.Color1 = Color.FromArgb(254, 219, 151);
            BnEditar.StateCommon.Back.Color2 = Color.FromArgb(254, 219, 151);
            BnEditar.StateCommon.Back.ColorAngle = -2F;
            BnEditar.StateCommon.Border.Color1 = Color.Transparent;
            BnEditar.StateCommon.Border.Color2 = Color.Transparent;
            BnEditar.StateCommon.Border.Rounding = 40F;
            BnEditar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BnEditar.StateCommon.Content.ShortText.Color1 = Color.White;
            BnEditar.StateCommon.Content.ShortText.Color2 = Color.White;
            BnEditar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BnEditar.TabIndex = 21;
            BnEditar.Values.DropDownArrowColor = Color.Empty;
            BnEditar.Values.Text = "Editar";
            // 
            // BnCrear
            // 
            BnCrear.Location = new Point(289, 542);
            BnCrear.Margin = new Padding(2);
            BnCrear.Name = "BnCrear";
            BnCrear.Size = new Size(100, 51);
            BnCrear.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            BnCrear.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            BnCrear.StateCommon.Back.ColorAngle = -2F;
            BnCrear.StateCommon.Border.Color1 = Color.Transparent;
            BnCrear.StateCommon.Border.Color2 = Color.Transparent;
            BnCrear.StateCommon.Border.Rounding = 40F;
            BnCrear.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BnCrear.StateCommon.Content.ShortText.Color1 = Color.White;
            BnCrear.StateCommon.Content.ShortText.Color2 = Color.White;
            BnCrear.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BnCrear.TabIndex = 20;
            BnCrear.Values.DropDownArrowColor = Color.Empty;
            BnCrear.Values.Text = "Crear";
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
            foreverGroupBox1.Margin = new Padding(2);
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
            parrotGroupBox3.Margin = new Padding(2);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.Padding = new Padding(2);
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
            txtDescripcion.Margin = new Padding(2);
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
            parrotGroupBox1.Margin = new Padding(2);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(2);
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
            txtNombreEspecialidad.Margin = new Padding(2);
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
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new DataGridViewColumn[] { EspecialidadId, Especialidad, Descripcion });
            dgvEspecialidades.Location = new Point(454, 118);
            dgvEspecialidades.Margin = new Padding(2);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 62;
            dgvEspecialidades.Size = new Size(346, 421);
            dgvEspecialidades.TabIndex = 41;
            // 
            // EspecialidadId
            // 
            EspecialidadId.HeaderText = "EspecialidadId";
            EspecialidadId.Name = "EspecialidadId";
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad";
            Especialidad.Name = "Especialidad";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
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
            Controls.Add(BnEliminar);
            Controls.Add(BnEditar);
            Controls.Add(BnCrear);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(2);
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
        private Krypton.Toolkit.KryptonButton BnEliminar;
        private Krypton.Toolkit.KryptonButton BnEditar;
        private Krypton.Toolkit.KryptonButton BnCrear;
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