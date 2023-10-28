namespace New_SYSACAD
{
    partial class InformesDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformesDisponibles));
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            buttonReportes = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(buttonReportes);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(358, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 556);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Snow;
            button5.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(84, 335);
            button5.Name = "button5";
            button5.Size = new Size(253, 56);
            button5.TabIndex = 6;
            button5.Text = "Estadisticas de inscripcion por carrera";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(84, 417);
            button4.Name = "button4";
            button4.Size = new Size(253, 53);
            button4.TabIndex = 5;
            button4.Text = "Listas de espera de cursos";
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonReportes
            // 
            buttonReportes.BackColor = Color.Snow;
            buttonReportes.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonReportes.Location = new Point(84, 243);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Size = new Size(253, 59);
            buttonReportes.TabIndex = 4;
            buttonReportes.Text = "Ingresos por conceptos de pago";
            buttonReportes.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(113, 499);
            button3.Name = "button3";
            button3.Size = new Size(204, 34);
            button3.TabIndex = 3;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(84, 158);
            button2.Name = "button2";
            button2.Size = new Size(253, 58);
            button2.TabIndex = 2;
            button2.Text = "Estudiantes por curso";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(52, 27);
            label2.Name = "label2";
            label2.Size = new Size(265, 22);
            label2.TabIndex = 1;
            label2.Text = "INFORMES DISPONIBLES";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(84, 82);
            button1.Name = "button1";
            button1.Size = new Size(253, 55);
            button1.TabIndex = 0;
            button1.Text = "Inscripciones por periodo";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(841, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // InformesDisponibles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "InformesDisponibles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformesDisponibles";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonReportes;
        private Button button3;
        private Button button2;
        private Label label2;
        private Button button1;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox1;
    }
}