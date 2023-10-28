namespace New_SYSACAD
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonReportes = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(828, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(227, 18);
            label1.TabIndex = 2;
            label1.Text = "Sistema de administracion";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(buttonReportes);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(335, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 606);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // buttonReportes
            // 
            buttonReportes.BackColor = Color.Snow;
            buttonReportes.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonReportes.Location = new Point(98, 226);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Size = new Size(204, 53);
            buttonReportes.TabIndex = 4;
            buttonReportes.Text = "Generar Reportes";
            buttonReportes.UseVisualStyleBackColor = false;
            buttonReportes.Click += buttonReportes_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(98, 551);
            button3.Name = "button3";
            button3.Size = new Size(204, 34);
            button3.TabIndex = 3;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(98, 151);
            button2.Name = "button2";
            button2.Size = new Size(204, 51);
            button2.TabIndex = 2;
            button2.Text = "Gestionar cursos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(171, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 1;
            label2.Text = "MENU";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(98, 72);
            button1.Name = "button1";
            button1.Size = new Size(204, 52);
            button1.TabIndex = 0;
            button1.Text = "Registrar Estudiante";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(98, 306);
            button4.Name = "button4";
            button4.Size = new Size(204, 54);
            button4.TabIndex = 5;
            button4.Text = "Gestionar Requisitos Académicos";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Snow;
            button5.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(98, 389);
            button5.Name = "button5";
            button5.Size = new Size(204, 52);
            button5.TabIndex = 6;
            button5.Text = "Manejar Listas de Espera";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Snow;
            button6.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(98, 472);
            button6.Name = "button6";
            button6.Size = new Size(204, 53);
            button6.TabIndex = 7;
            button6.Text = "Gestionar Perfiles de Profesores";
            button6.UseVisualStyleBackColor = false;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 799);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MenuAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuAdministrador";
            FormClosing += MenuAdministrador_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button buttonReportes;
        private Button button5;
        private Button button4;
        private Button button6;
    }
}