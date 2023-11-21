namespace New_SYSACAD
{
    partial class AsignarCursoAProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarCursoAProfesor));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonVolver = new Button();
            checkedListBoxCursosAsignados = new CheckedListBox();
            buttonAsignar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(823, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(173, 172);
            label1.Name = "label1";
            label1.Size = new Size(460, 25);
            label1.TabIndex = 17;
            label1.Text = "Seleccione el curso que le quiere asignar a ..";
            // 
            // buttonVolver
            // 
            buttonVolver.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVolver.Location = new Point(173, 530);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(125, 42);
            buttonVolver.TabIndex = 18;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // checkedListBoxCursosAsignados
            // 
            checkedListBoxCursosAsignados.BackColor = Color.AntiqueWhite;
            checkedListBoxCursosAsignados.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            checkedListBoxCursosAsignados.FormattingEnabled = true;
            checkedListBoxCursosAsignados.Location = new Point(173, 222);
            checkedListBoxCursosAsignados.Name = "checkedListBoxCursosAsignados";
            checkedListBoxCursosAsignados.Size = new Size(628, 264);
            checkedListBoxCursosAsignados.TabIndex = 19;
            // 
            // buttonAsignar
            // 
            buttonAsignar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonAsignar.Location = new Point(676, 539);
            buttonAsignar.Name = "buttonAsignar";
            buttonAsignar.Size = new Size(125, 42);
            buttonAsignar.TabIndex = 20;
            buttonAsignar.Text = "Asignar";
            buttonAsignar.UseVisualStyleBackColor = true;
            buttonAsignar.Click += buttonAsignar_Click;
            // 
            // AsignarCursoAProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(buttonAsignar);
            Controls.Add(checkedListBoxCursosAsignados);
            Controls.Add(buttonVolver);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AsignarCursoAProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AsignarCursoAProfesor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonVolver;
        private CheckedListBox checkedListBoxCursosAsignados;
        private Button buttonAsignar;
    }
}