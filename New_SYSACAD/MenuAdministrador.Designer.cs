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
            buttonGestionarProfesores = new Button();
            buttonManejarListaEspera = new Button();
            button4 = new Button();
            buttonReportes = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
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
            label1.Location = new Point(401, 75);
            label1.Name = "label1";
            label1.Size = new Size(227, 18);
            label1.TabIndex = 2;
            label1.Text = "Sistema de administracion";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonGestionarProfesores);
            groupBox1.Controls.Add(buttonManejarListaEspera);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(buttonReportes);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(292, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 654);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // buttonGestionarProfesores
            // 
            buttonGestionarProfesores.BackColor = Color.Snow;
            buttonGestionarProfesores.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonGestionarProfesores.Location = new Point(109, 473);
            buttonGestionarProfesores.Name = "buttonGestionarProfesores";
            buttonGestionarProfesores.Size = new Size(259, 53);
            buttonGestionarProfesores.TabIndex = 7;
            buttonGestionarProfesores.Text = "Gestionar Perfiles de Profesores";
            buttonGestionarProfesores.UseVisualStyleBackColor = false;
            buttonGestionarProfesores.Click += buttonGestionarProfesores_Click;
            // 
            // buttonManejarListaEspera
            // 
            buttonManejarListaEspera.BackColor = Color.Snow;
            buttonManejarListaEspera.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonManejarListaEspera.Location = new Point(109, 391);
            buttonManejarListaEspera.Name = "buttonManejarListaEspera";
            buttonManejarListaEspera.Size = new Size(259, 52);
            buttonManejarListaEspera.TabIndex = 6;
            buttonManejarListaEspera.Text = "Manejar Listas de Espera";
            buttonManejarListaEspera.UseVisualStyleBackColor = false;
            buttonManejarListaEspera.Click += buttonManejarListaEspera_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(109, 306);
            button4.Name = "button4";
            button4.Size = new Size(259, 54);
            button4.TabIndex = 5;
            button4.Text = "Gestionar Requisitos Académicos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonReportes
            // 
            buttonReportes.BackColor = Color.Snow;
            buttonReportes.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonReportes.Location = new Point(109, 222);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Size = new Size(259, 53);
            buttonReportes.TabIndex = 4;
            buttonReportes.Text = "Generar Reportes";
            buttonReportes.UseVisualStyleBackColor = false;
            buttonReportes.Click += buttonReportes_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(148, 565);
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
            button2.Location = new Point(109, 150);
            button2.Name = "button2";
            button2.Size = new Size(259, 51);
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
            label2.Location = new Point(213, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 1;
            label2.Text = "MENU";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(109, 77);
            button1.Name = "button1";
            button1.Size = new Size(259, 52);
            button1.TabIndex = 0;
            button1.Text = "Registrar Estudiante";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
        private Button buttonManejarListaEspera;
        private Button button4;
        private Button buttonGestionarProfesores;
    }
}