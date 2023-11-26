namespace New_SYSACAD
{
    partial class PedirInformeEstadisticaPorCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedirInformeEstadisticaPorCarrera));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            comboBoxPeriodo = new ComboBox();
            label1 = new Label();
            labelTitulo = new Label();
            buttonVolver = new Button();
            buttonInformePDf = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(810, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBoxPeriodo);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(245, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 215);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // comboBoxPeriodo
            // 
            comboBoxPeriodo.BackColor = Color.Snow;
            comboBoxPeriodo.FormattingEnabled = true;
            comboBoxPeriodo.Location = new Point(52, 94);
            comboBoxPeriodo.Name = "comboBoxPeriodo";
            comboBoxPeriodo.Size = new Size(384, 30);
            comboBoxPeriodo.TabIndex = 27;
            comboBoxPeriodo.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 24;
            label1.Text = "Seleccione el periodo:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(227, 179);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(610, 29);
            labelTitulo.TabIndex = 30;
            labelTitulo.Text = "Informe de estadisticas de inscripcion por carrera";
            // 
            // buttonVolver
            // 
            buttonVolver.ForeColor = Color.DarkSlateGray;
            buttonVolver.Location = new Point(245, 539);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(147, 34);
            buttonVolver.TabIndex = 31;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonInformePDf
            // 
            buttonInformePDf.ForeColor = Color.DarkSlateGray;
            buttonInformePDf.Location = new Point(550, 539);
            buttonInformePDf.Name = "buttonInformePDf";
            buttonInformePDf.Size = new Size(190, 34);
            buttonInformePDf.TabIndex = 32;
            buttonInformePDf.Text = "Generar Informe PDF";
            buttonInformePDf.UseVisualStyleBackColor = true;
            buttonInformePDf.Click += buttonInformePDf_Click;
            // 
            // PedirInformeEstadisticaPorCarrera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(buttonInformePDf);
            Controls.Add(buttonVolver);
            Controls.Add(labelTitulo);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "PedirInformeEstadisticaPorCarrera";
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
        private GroupBox groupBox1;
        private ComboBox comboBoxPeriodo;
        private Label label1;
        private Label labelTitulo;
        private Button buttonVolver;
        private Button buttonInformePDf;
    }
}