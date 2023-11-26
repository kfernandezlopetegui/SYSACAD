namespace New_SYSACAD
{
    partial class PedirInformeEstudiantesPorCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedirInformeEstudiantesPorCurso));
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            label1 = new Label();
            buttonInformePDf = new Button();
            buttonVolver = new Button();
            comboBoxCurso = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(810, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(287, 200);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(487, 29);
            labelTitulo.TabIndex = 23;
            labelTitulo.Text = "Informe de alumnos inscritos por curso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(40, 67);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 24;
            label1.Text = "Seleccione el curso:";
            // 
            // buttonInformePDf
            // 
            buttonInformePDf.ForeColor = Color.DarkSlateGray;
            buttonInformePDf.Location = new Point(584, 563);
            buttonInformePDf.Name = "buttonInformePDf";
            buttonInformePDf.Size = new Size(190, 34);
            buttonInformePDf.TabIndex = 25;
            buttonInformePDf.Text = "Generar Informe PDF";
            buttonInformePDf.UseVisualStyleBackColor = true;
            buttonInformePDf.Click += buttonInformePDf_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.ForeColor = Color.DarkSlateGray;
            buttonVolver.Location = new Point(265, 563);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(147, 34);
            buttonVolver.TabIndex = 26;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // comboBoxCurso
            // 
            comboBoxCurso.BackColor = Color.Snow;
            comboBoxCurso.FormattingEnabled = true;
            comboBoxCurso.Location = new Point(73, 128);
            comboBoxCurso.Name = "comboBoxCurso";
            comboBoxCurso.Size = new Size(384, 30);
            comboBoxCurso.TabIndex = 27;
            comboBoxCurso.Tag = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBoxCurso);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(247, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 229);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // PedirInformeEstudiantesPorCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(groupBox1);
            Controls.Add(buttonVolver);
            Controls.Add(buttonInformePDf);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox1);
            Name = "PedirInformeEstudiantesPorCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sysacad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitulo;
        private Label label1;
        private Button buttonInformePDf;
        private Button buttonVolver;
        private ComboBox comboBoxCurso;
        private GroupBox groupBox1;
    }
}