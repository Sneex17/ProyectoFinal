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
            BtnDesactivar = new Krypton.Toolkit.KryptonButton();
            ButtonEditar = new Krypton.Toolkit.KryptonButton();
            ButtonCrear = new Krypton.Toolkit.KryptonButton();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtDescripcion = new TextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtNombreEspecialidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvEspecialidades = new DataGridView();
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
            label7.Location = new Point(62, 103);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(415, 23);
            label7.TabIndex = 24;
            label7.Text = "Registro y consulta de especialidades en el sistema";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 54, 60);
            label6.Location = new Point(53, 49);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(460, 49);
            label6.TabIndex = 25;
            label6.Text = "Registro de Especialidades";
            // 
            // BtnDesactivar
            // 
            BtnDesactivar.Location = new Point(62, 723);
            BtnDesactivar.Margin = new Padding(2, 3, 2, 3);
            BtnDesactivar.Name = "BtnDesactivar";
            BtnDesactivar.Size = new Size(114, 68);
            BtnDesactivar.StateCommon.Back.Color1 = Color.IndianRed;
            BtnDesactivar.StateCommon.Back.Color2 = Color.Brown;
            BtnDesactivar.StateCommon.Back.ColorAngle = -2F;
            BtnDesactivar.StateCommon.Border.Color1 = Color.Transparent;
            BtnDesactivar.StateCommon.Border.Color2 = Color.Transparent;
            BtnDesactivar.StateCommon.Border.Rounding = 40F;
            BtnDesactivar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDesactivar.StateCommon.Content.ShortText.Color1 = Color.White;
            BtnDesactivar.StateCommon.Content.ShortText.Color2 = Color.White;
            BtnDesactivar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDesactivar.TabIndex = 22;
            BtnDesactivar.Values.DropDownArrowColor = Color.Empty;
            BtnDesactivar.Values.Text = "Desactivar";
            BtnDesactivar.Click += kryptonButton3_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.Location = new Point(197, 723);
            ButtonEditar.Margin = new Padding(2, 3, 2, 3);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(114, 68);
            ButtonEditar.StateCommon.Back.Color1 = Color.FromArgb(254, 219, 151);
            ButtonEditar.StateCommon.Back.Color2 = Color.FromArgb(254, 219, 151);
            ButtonEditar.StateCommon.Back.ColorAngle = -2F;
            ButtonEditar.StateCommon.Border.Color1 = Color.Transparent;
            ButtonEditar.StateCommon.Border.Color2 = Color.Transparent;
            ButtonEditar.StateCommon.Border.Rounding = 40F;
            ButtonEditar.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEditar.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonEditar.StateCommon.Content.ShortText.Color2 = Color.White;
            ButtonEditar.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEditar.TabIndex = 21;
            ButtonEditar.Values.DropDownArrowColor = Color.Empty;
            ButtonEditar.Values.Text = "Editar";
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // ButtonCrear
            // 
            ButtonCrear.Location = new Point(330, 723);
            ButtonCrear.Margin = new Padding(2, 3, 2, 3);
            ButtonCrear.Name = "ButtonCrear";
            ButtonCrear.Size = new Size(114, 68);
            ButtonCrear.StateCommon.Back.Color1 = Color.FromArgb(0, 51, 82);
            ButtonCrear.StateCommon.Back.Color2 = Color.FromArgb(23, 74, 111);
            ButtonCrear.StateCommon.Back.ColorAngle = -2F;
            ButtonCrear.StateCommon.Border.Color1 = Color.Transparent;
            ButtonCrear.StateCommon.Border.Color2 = Color.Transparent;
            ButtonCrear.StateCommon.Border.Rounding = 40F;
            ButtonCrear.StateCommon.Content.LongText.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCrear.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonCrear.StateCommon.Content.ShortText.Color2 = Color.White;
            ButtonCrear.StateCommon.Content.ShortText.Font = new Font("Corbel", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCrear.TabIndex = 20;
            ButtonCrear.Values.DropDownArrowColor = Color.Empty;
            ButtonCrear.Values.Text = "Crear";
            ButtonCrear.Click += ButtonCrear_Click;
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
            foreverGroupBox1.Location = new Point(53, 157);
            foreverGroupBox1.Margin = new Padding(2, 3, 2, 3);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(407, 561);
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
            parrotGroupBox3.Location = new Point(45, 185);
            parrotGroupBox3.Margin = new Padding(2, 3, 2, 3);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.Padding = new Padding(2, 3, 2, 3);
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(314, 352);
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
            txtDescripcion.Location = new Point(13, 23);
            txtDescripcion.Margin = new Padding(2, 3, 2, 3);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Describa la especialidad médica";
            txtDescripcion.Size = new Size(290, 317);
            txtDescripcion.TabIndex = 40;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.BorderWidth = 3;
            parrotGroupBox1.Controls.Add(txtNombreEspecialidad);
            parrotGroupBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.ForeColor = Color.FromArgb(4, 79, 86);
            parrotGroupBox1.Location = new Point(45, 107);
            parrotGroupBox1.Margin = new Padding(2, 3, 2, 3);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(2, 3, 2, 3);
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(314, 55);
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
            txtNombreEspecialidad.Location = new Point(13, 23);
            txtNombreEspecialidad.Margin = new Padding(2, 3, 2, 3);
            txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            txtNombreEspecialidad.PlaceholderText = "Ej: cardiología";
            txtNombreEspecialidad.Size = new Size(290, 25);
            txtNombreEspecialidad.TabIndex = 39;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(4, 79, 86);
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 79, 86);
            label2.Location = new Point(45, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(8, 33);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 79, 86);
            label1.Location = new Point(57, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 33);
            label1.TabIndex = 2;
            label1.Text = "Detalles de Especialidad";
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(519, 157);
            dgvEspecialidades.Margin = new Padding(2, 3, 2, 3);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 62;
            dgvEspecialidades.Size = new Size(395, 561);
            dgvEspecialidades.TabIndex = 41;
            dgvEspecialidades.SelectionChanged += dgvEspecialidades_SelectionChanged;
            // 
            // FormRegistroEspecialidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 248, 226);
            ClientSize = new Size(965, 832);
            Controls.Add(dgvEspecialidades);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnDesactivar);
            Controls.Add(ButtonEditar);
            Controls.Add(ButtonCrear);
            Controls.Add(foreverGroupBox1);
            Margin = new Padding(2, 3, 2, 3);
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
        private Krypton.Toolkit.KryptonButton BtnDesactivar;
        private Krypton.Toolkit.KryptonButton ButtonEditar;
        private Krypton.Toolkit.KryptonButton ButtonCrear;
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
    }
}