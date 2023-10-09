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
            textCupo = new TextBox();
            textDescripcion = new TextBox();
            textCodigo = new TextBox();
            textNombre = new TextBox();
            buttonGuardar = new Button();
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
            groupBox1.Controls.Add(buttonGuardar);
            groupBox1.Controls.Add(buttonVolver);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RosyBrown;
            groupBox1.Location = new Point(262, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Curso";
            // 
            // textCupo
            // 
            textCupo.BackColor = Color.SeaShell;
            textCupo.ForeColor = SystemColors.Desktop;
            textCupo.Location = new Point(110, 284);
            textCupo.Name = "textCupo";
            textCupo.Size = new Size(293, 29);
            textCupo.TabIndex = 5;
            textCupo.TextAlign = HorizontalAlignment.Center;
            textCupo.Validated += textCupo_Validated;
            // 
            // textDescripcion
            // 
            textDescripcion.BackColor = Color.SeaShell;
            textDescripcion.ForeColor = SystemColors.Desktop;
            textDescripcion.Location = new Point(110, 212);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(293, 29);
            textDescripcion.TabIndex = 4;
            textDescripcion.TextAlign = HorizontalAlignment.Center;
            textDescripcion.Validated += textDescripcion_Validated;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.SeaShell;
            textCodigo.ForeColor = SystemColors.Desktop;
            textCodigo.Location = new Point(110, 129);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(286, 29);
            textCodigo.TabIndex = 3;
            textCodigo.TextAlign = HorizontalAlignment.Center;
            textCodigo.Validated += textCodigo_Validated;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.SeaShell;
            textNombre.ForeColor = SystemColors.Desktop;
            textNombre.Location = new Point(110, 57);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(293, 29);
            textNombre.TabIndex = 2;
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.Validated += textNombre_Validated_1;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.SeaShell;
            buttonGuardar.Location = new Point(336, 372);
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
            buttonVolver.Location = new Point(39, 372);
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
            pictureBox1.Location = new Point(853, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // EdicionDeCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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
    }
}