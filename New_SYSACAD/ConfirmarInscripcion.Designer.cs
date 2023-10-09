namespace New_SYSACAD
{
    partial class ConfirmarInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarInscripcion));
            buttonVolver = new Button();
            buttonInscripcion = new Button();
            pictureBox1 = new PictureBox();
            labelIndicaciones = new Label();
            listViewCursos = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVolver.Location = new Point(182, 624);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 33);
            buttonVolver.TabIndex = 8;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonInscripcion
            // 
            buttonInscripcion.BackColor = Color.SeaShell;
            buttonInscripcion.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonInscripcion.Location = new Point(652, 623);
            buttonInscripcion.Name = "buttonInscripcion";
            buttonInscripcion.Size = new Size(232, 34);
            buttonInscripcion.TabIndex = 9;
            buttonInscripcion.Text = "Confirmar Inscripcion";
            buttonInscripcion.UseVisualStyleBackColor = false;
            buttonInscripcion.Click += buttonInscripcion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(879, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // labelIndicaciones
            // 
            labelIndicaciones.AutoSize = true;
            labelIndicaciones.BackColor = Color.AntiqueWhite;
            labelIndicaciones.Font = new Font("Verdana", 11F, FontStyle.Italic, GraphicsUnit.Point);
            labelIndicaciones.Location = new Point(225, 197);
            labelIndicaciones.Name = "labelIndicaciones";
            labelIndicaciones.Size = new Size(242, 26);
            labelIndicaciones.TabIndex = 11;
            labelIndicaciones.Text = "Cursos seleccionados\r\n";
            // 
            // listViewCursos
            // 
            listViewCursos.BackColor = Color.AntiqueWhite;
            listViewCursos.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            listViewCursos.Location = new Point(225, 264);
            listViewCursos.Name = "listViewCursos";
            listViewCursos.Size = new Size(659, 264);
            listViewCursos.TabIndex = 13;
            listViewCursos.UseCompatibleStateImageBehavior = false;
            // 
            // ConfirmarInscripcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(listViewCursos);
            Controls.Add(labelIndicaciones);
            Controls.Add(pictureBox1);
            Controls.Add(buttonInscripcion);
            Controls.Add(buttonVolver);
            Name = "ConfirmarInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmarInscripcion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonVolver;
        private Button buttonInscripcion;
        private PictureBox pictureBox1;
        private Label labelIndicaciones;
        private ListView listViewCursos;
    }
}