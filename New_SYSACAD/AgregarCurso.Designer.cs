namespace New_SYSACAD
{
    partial class AgregarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCurso));
            groupBox1 = new GroupBox();
            label4 = new Label();
            comboBoxCarrera = new ComboBox();
            textBoxPromedio = new TextBox();
            textBoxCreditosObtenidos = new TextBox();
            label3 = new Label();
            checkedListBoxPreCursos = new CheckedListBox();
            label2 = new Label();
            label1 = new Label();
            checkedListBoxHorario = new CheckedListBox();
            checkedListBoxDiasCursada = new CheckedListBox();
            textDescripcion = new TextBox();
            textCupo = new TextBox();
            textCodigo = new TextBox();
            textNombre = new TextBox();
            buttonAgregar = new Button();
            buttonVolver = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxCarrera);
            groupBox1.Controls.Add(textBoxPromedio);
            groupBox1.Controls.Add(textBoxCreditosObtenidos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkedListBoxPreCursos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkedListBoxHorario);
            groupBox1.Controls.Add(checkedListBoxDiasCursada);
            groupBox1.Controls.Add(textDescripcion);
            groupBox1.Controls.Add(textCupo);
            groupBox1.Controls.Add(textCodigo);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(buttonAgregar);
            groupBox1.Controls.Add(buttonVolver);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RosyBrown;
            groupBox1.Location = new Point(107, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(815, 564);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 237);
            label4.Name = "label4";
            label4.Size = new Size(207, 22);
            label4.TabIndex = 21;
            label4.Text = "Seleccione la carrera:";
            // 
            // comboBoxCarrera
            // 
            comboBoxCarrera.BackColor = Color.Snow;
            comboBoxCarrera.FormattingEnabled = true;
            comboBoxCarrera.Location = new Point(10, 262);
            comboBoxCarrera.Name = "comboBoxCarrera";
            comboBoxCarrera.Size = new Size(370, 30);
            comboBoxCarrera.TabIndex = 2;
            comboBoxCarrera.Tag = "";
            comboBoxCarrera.Enter += comboBoxCarrera_Enter;
            comboBoxCarrera.Validated += comboBoxCarrera_Validated;
            // 
            // textBoxPromedio
            // 
            textBoxPromedio.BackColor = Color.Snow;
            textBoxPromedio.ForeColor = SystemColors.Desktop;
            textBoxPromedio.Location = new Point(403, 177);
            textBoxPromedio.Name = "textBoxPromedio";
            textBoxPromedio.PlaceholderText = "Ingrese promedio minimo";
            textBoxPromedio.Size = new Size(374, 29);
            textBoxPromedio.TabIndex = 20;
            textBoxPromedio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCreditosObtenidos
            // 
            textBoxCreditosObtenidos.BackColor = Color.Snow;
            textBoxCreditosObtenidos.ForeColor = SystemColors.Desktop;
            textBoxCreditosObtenidos.Location = new Point(6, 177);
            textBoxCreditosObtenidos.Name = "textBoxCreditosObtenidos";
            textBoxCreditosObtenidos.PlaceholderText = "Ingrese Créditos minimos";
            textBoxCreditosObtenidos.Size = new Size(374, 29);
            textBoxCreditosObtenidos.TabIndex = 19;
            textBoxCreditosObtenidos.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(6, 330);
            label3.Name = "label3";
            label3.Size = new Size(370, 26);
            label3.TabIndex = 18;
            label3.Text = "Cursos correlativos";
            // 
            // checkedListBoxPreCursos
            // 
            checkedListBoxPreCursos.BackColor = Color.Snow;
            checkedListBoxPreCursos.FormattingEnabled = true;
            checkedListBoxPreCursos.Location = new Point(10, 359);
            checkedListBoxPreCursos.Name = "checkedListBoxPreCursos";
            checkedListBoxPreCursos.Size = new Size(370, 56);
            checkedListBoxPreCursos.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 237);
            label2.Name = "label2";
            label2.Size = new Size(224, 22);
            label2.TabIndex = 16;
            label2.Text = "Seleccione los horarios:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 330);
            label1.Name = "label1";
            label1.Size = new Size(290, 22);
            label1.TabIndex = 15;
            label1.Text = "Seleccione los dias de cursada:";
            // 
            // checkedListBoxHorario
            // 
            checkedListBoxHorario.BackColor = Color.Snow;
            checkedListBoxHorario.FormattingEnabled = true;
            checkedListBoxHorario.Location = new Point(424, 262);
            checkedListBoxHorario.Name = "checkedListBoxHorario";
            checkedListBoxHorario.Size = new Size(370, 56);
            checkedListBoxHorario.TabIndex = 14;
            checkedListBoxHorario.Enter += checkedListBoxHorario_Enter;
            // 
            // checkedListBoxDiasCursada
            // 
            checkedListBoxDiasCursada.BackColor = Color.Snow;
            checkedListBoxDiasCursada.FormattingEnabled = true;
            checkedListBoxDiasCursada.Location = new Point(424, 359);
            checkedListBoxDiasCursada.Name = "checkedListBoxDiasCursada";
            checkedListBoxDiasCursada.Size = new Size(370, 56);
            checkedListBoxDiasCursada.TabIndex = 13;
            checkedListBoxDiasCursada.Enter += checkedListBoxDiasCursada_Enter;
            // 
            // textDescripcion
            // 
            textDescripcion.BackColor = Color.Snow;
            textDescripcion.ForeColor = SystemColors.Desktop;
            textDescripcion.Location = new Point(6, 114);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.PlaceholderText = "Ingrese el Aula";
            textDescripcion.Size = new Size(374, 30);
            textDescripcion.TabIndex = 4;
            textDescripcion.TextAlign = HorizontalAlignment.Center;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            textDescripcion.Enter += textDescripcion_Enter;
            textDescripcion.Validated += textDescripcion_Validated;
            // 
            // textCupo
            // 
            textCupo.BackColor = Color.Snow;
            textCupo.ForeColor = SystemColors.Desktop;
            textCupo.Location = new Point(403, 115);
            textCupo.Name = "textCupo";
            textCupo.PlaceholderText = "Ingrese cupo maximo";
            textCupo.Size = new Size(374, 29);
            textCupo.TabIndex = 5;
            textCupo.TextAlign = HorizontalAlignment.Center;
            textCupo.Enter += textCupo_Enter;
            textCupo.Validated += textCupo_Validated;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.Snow;
            textCodigo.ForeColor = SystemColors.Desktop;
            textCodigo.Location = new Point(403, 44);
            textCodigo.Name = "textCodigo";
            textCodigo.PlaceholderText = "Ingrese el codigo del curso";
            textCodigo.Size = new Size(370, 29);
            textCodigo.TabIndex = 3;
            textCodigo.TextAlign = HorizontalAlignment.Center;
            textCodigo.Enter += textCodigo_Enter;
            textCodigo.Validated += textCodigo_Validated;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Snow;
            textNombre.ForeColor = SystemColors.Desktop;
            textNombre.Location = new Point(6, 44);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Ingrese el nombre del Curso";
            textNombre.Size = new Size(370, 29);
            textNombre.TabIndex = 2;
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.Enter += textNombre_Enter;
            textNombre.Validated += textNombre_Validated;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.SeaShell;
            buttonAgregar.ForeColor = Color.IndianRed;
            buttonAgregar.Location = new Point(615, 493);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 34);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.ForeColor = Color.IndianRed;
            buttonVolver.Location = new Point(47, 493);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(874, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AgregarCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "AgregarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarCurso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonAgregar;
        private Button buttonVolver;
        private TextBox textCupo;
        private TextBox textDescripcion;
        private TextBox textCodigo;
        private TextBox textNombre;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBoxDiasCursada;
        private CheckedListBox checkedListBoxHorario;
        private CheckedListBox checkedListBoxPreCursos;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBoxPromedio;
        private TextBox textBoxCreditosObtenidos;
        private ComboBox comboBoxCarrera;
        private Label label4;
    }
}