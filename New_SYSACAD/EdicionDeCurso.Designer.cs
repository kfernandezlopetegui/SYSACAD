namespace New_SYSACAD
{
    partial class EdicionDeCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionDeCurso));
            groupBox1 = new GroupBox();
            checkedListBoxHorarios = new CheckedListBox();
            checkedListBoxDiasCursada = new CheckedListBox();
            textCupo = new TextBox();
            textDescripcion = new TextBox();
            textCodigo = new TextBox();
            textNombre = new TextBox();
            buttonGuardar = new Button();
            buttonVolver = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkedListBoxHorarios);
            groupBox1.Controls.Add(checkedListBoxDiasCursada);
            groupBox1.Controls.Add(textCupo);
            groupBox1.Controls.Add(textDescripcion);
            groupBox1.Controls.Add(textCodigo);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(buttonGuardar);
            groupBox1.Controls.Add(buttonVolver);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RosyBrown;
            groupBox1.Location = new Point(262, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 641);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Curso";
            // 
            // checkedListBoxHorarios
            // 
            checkedListBoxHorarios.FormattingEnabled = true;
            checkedListBoxHorarios.Location = new Point(103, 479);
            checkedListBoxHorarios.Name = "checkedListBoxHorarios";
            checkedListBoxHorarios.Size = new Size(293, 56);
            checkedListBoxHorarios.TabIndex = 7;
            // 
            // checkedListBoxDiasCursada
            // 
            checkedListBoxDiasCursada.FormattingEnabled = true;
            checkedListBoxDiasCursada.Location = new Point(103, 365);
            checkedListBoxDiasCursada.Name = "checkedListBoxDiasCursada";
            checkedListBoxDiasCursada.Size = new Size(293, 56);
            checkedListBoxDiasCursada.TabIndex = 6;
            // 
            // textCupo
            // 
            textCupo.BackColor = Color.White;
            textCupo.ForeColor = SystemColors.Desktop;
            textCupo.Location = new Point(103, 221);
            textCupo.Name = "textCupo";
            textCupo.Size = new Size(293, 29);
            textCupo.TabIndex = 5;
            textCupo.TextAlign = HorizontalAlignment.Center;
            textCupo.Validated += textCupo_Validated;
            // 
            // textDescripcion
            // 
            textDescripcion.BackColor = Color.White;
            textDescripcion.ForeColor = SystemColors.Desktop;
            textDescripcion.Location = new Point(103, 292);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(293, 29);
            textDescripcion.TabIndex = 4;
            textDescripcion.TextAlign = HorizontalAlignment.Center;
            textDescripcion.Validated += textDescripcion_Validated;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.White;
            textCodigo.ForeColor = SystemColors.Desktop;
            textCodigo.Location = new Point(103, 145);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(293, 29);
            textCodigo.TabIndex = 3;
            textCodigo.TextAlign = HorizontalAlignment.Center;
            textCodigo.Validated += textCodigo_Validated;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.White;
            textNombre.ForeColor = SystemColors.Desktop;
            textNombre.Location = new Point(103, 73);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(293, 29);
            textNombre.TabIndex = 2;
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.Validated += textNombre_Validated_1;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.SeaShell;
            buttonGuardar.Location = new Point(356, 569);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(112, 34);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.Location = new Point(24, 569);
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
            pictureBox1.Location = new Point(844, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 48);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 8;
            label1.Text = "Nombre de curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 120);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 9;
            label2.Text = "Codigo de curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 196);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 10;
            label3.Text = "Cupo maximo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 267);
            label4.Name = "label4";
            label4.Size = new Size(155, 22);
            label4.TabIndex = 11;
            label4.Text = "Numero de Aula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 340);
            label5.Name = "label5";
            label5.Size = new Size(153, 22);
            label5.TabIndex = 12;
            label5.Text = "Dias de cursada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 454);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 13;
            label6.Text = "Horarios";
            // 
            // EdicionDeCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "EdicionDeCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EdicionDeCurso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textCupo;
        private TextBox textDescripcion;
        private TextBox textCodigo;
        private TextBox textNombre;
        private Button buttonGuardar;
        private Button buttonVolver;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBoxDiasCursada;
        private CheckedListBox checkedListBoxHorarios;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}