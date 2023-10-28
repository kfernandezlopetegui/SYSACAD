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
            textCupo = new TextBox();
            textDescripcion = new TextBox();
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
            groupBox1.BackColor = Color.AntiqueWhite;
            groupBox1.Controls.Add(textCupo);
            groupBox1.Controls.Add(textDescripcion);
            groupBox1.Controls.Add(textCodigo);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(buttonAgregar);
            groupBox1.Controls.Add(buttonVolver);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RosyBrown;
            groupBox1.Location = new Point(272, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 581);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Curso";
            // 
            // textCupo
            // 
            textCupo.BackColor = Color.SeaShell;
            textCupo.ForeColor = SystemColors.InactiveCaption;
            textCupo.Location = new Point(110, 381);
            textCupo.Name = "textCupo";
            textCupo.Size = new Size(293, 29);
            textCupo.TabIndex = 5;
            textCupo.Text = "Ingrese cupo maximo";
            textCupo.TextAlign = HorizontalAlignment.Center;
            textCupo.TextChanged += textCupo_TextChanged;
            textCupo.Enter += textCupo_Enter;
            textCupo.Validated += textCupo_Validated;
            // 
            // textDescripcion
            // 
            textDescripcion.BackColor = Color.SeaShell;
            textDescripcion.ForeColor = SystemColors.InactiveCaption;
            textDescripcion.Location = new Point(110, 265);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.PlaceholderText = "Dia cursada HH:mm-HH:mm Aula: ";
            textDescripcion.Size = new Size(286, 48);
            textDescripcion.TabIndex = 4;
            textDescripcion.Text = "Ingrese la descripcion del curso";
            textDescripcion.TextAlign = HorizontalAlignment.Center;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            textDescripcion.Enter += textDescripcion_Enter;
            textDescripcion.Validated += textDescripcion_Validated;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.SeaShell;
            textCodigo.ForeColor = SystemColors.InactiveCaption;
            textCodigo.Location = new Point(110, 172);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(286, 29);
            textCodigo.TabIndex = 3;
            textCodigo.Text = "Ingrese el codigo del curso";
            textCodigo.TextAlign = HorizontalAlignment.Center;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.Enter += textCodigo_Enter;
            textCodigo.Validated += textCodigo_Validated;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.SeaShell;
            textNombre.ForeColor = SystemColors.InactiveCaption;
            textNombre.Location = new Point(110, 85);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(293, 29);
            textNombre.TabIndex = 2;
            textNombre.Text = "Ingrese el nombre del Curso";
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.TextChanged += textNombre_TextChanged;
            textNombre.Enter += textNombre_Enter;
            textNombre.Validated += textNombre_Validated;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.SeaShell;
            buttonAgregar.Location = new Point(339, 478);
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
            buttonVolver.Location = new Point(38, 478);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(885, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AgregarCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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
    }
}