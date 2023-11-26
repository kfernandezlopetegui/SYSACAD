namespace New_SYSACAD
{
    partial class PedirInformeListaEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedirInformeListaEspera));
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            comboBoxCurso = new ComboBox();
            label1 = new Label();
            buttonVolver = new Button();
            buttonInformePDf = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(238, 139);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(487, 29);
            labelTitulo.TabIndex = 24;
            labelTitulo.Text = "Informe de alumnos inscritos por curso";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(793, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBoxCurso);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(218, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 234);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // comboBoxCurso
            // 
            comboBoxCurso.BackColor = Color.Snow;
            comboBoxCurso.FormattingEnabled = true;
            comboBoxCurso.Location = new Point(60, 121);
            comboBoxCurso.Name = "comboBoxCurso";
            comboBoxCurso.Size = new Size(384, 30);
            comboBoxCurso.TabIndex = 27;
            comboBoxCurso.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(48, 45);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 24;
            label1.Text = "Seleccione el curso:";
            // 
            // buttonVolver
            // 
            buttonVolver.ForeColor = Color.DarkSlateGray;
            buttonVolver.Location = new Point(218, 560);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(147, 34);
            buttonVolver.TabIndex = 30;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonInformePDf
            // 
            buttonInformePDf.ForeColor = Color.DarkSlateGray;
            buttonInformePDf.Location = new Point(535, 560);
            buttonInformePDf.Name = "buttonInformePDf";
            buttonInformePDf.Size = new Size(190, 34);
            buttonInformePDf.TabIndex = 31;
            buttonInformePDf.Text = "Generar Informe PDF";
            buttonInformePDf.UseVisualStyleBackColor = true;
            buttonInformePDf.Click += buttonInformePDf_Click;
            // 
            // PedirInformeListaEspera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(buttonInformePDf);
            Controls.Add(buttonVolver);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Name = "PedirInformeListaEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sysacad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ComboBox comboBoxCurso;
        private Label label1;
        private Button buttonVolver;
        private Button buttonInformePDf;
    }
}