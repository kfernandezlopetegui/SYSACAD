namespace New_SYSACAD
{
    partial class MenuEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstudiante));
            labelBienvenida = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonRealizarPagos = new Button();
            button3 = new Button();
            buttonHorarios = new Button();
            label2 = new Label();
            buttonInscripcion = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.BackColor = Color.AntiqueWhite;
            labelBienvenida.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelBienvenida.Location = new Point(117, 54);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(95, 29);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Saludo";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(903, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonRealizarPagos);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(buttonHorarios);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonInscripcion);
            groupBox1.Location = new Point(334, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 458);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // buttonRealizarPagos
            // 
            buttonRealizarPagos.BackColor = Color.AliceBlue;
            buttonRealizarPagos.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonRealizarPagos.Location = new Point(65, 262);
            buttonRealizarPagos.Name = "buttonRealizarPagos";
            buttonRealizarPagos.Size = new Size(233, 34);
            buttonRealizarPagos.TabIndex = 4;
            buttonRealizarPagos.Text = "Realizar Pagos";
            buttonRealizarPagos.UseVisualStyleBackColor = false;
            buttonRealizarPagos.Click += buttonRealizarPagos_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Bisque;
            button3.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(82, 363);
            button3.Name = "button3";
            button3.Size = new Size(204, 34);
            button3.TabIndex = 3;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonHorarios
            // 
            buttonHorarios.BackColor = Color.AliceBlue;
            buttonHorarios.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonHorarios.Location = new Point(65, 180);
            buttonHorarios.Name = "buttonHorarios";
            buttonHorarios.Size = new Size(233, 34);
            buttonHorarios.TabIndex = 2;
            buttonHorarios.Text = "Consultar Horarios";
            buttonHorarios.UseVisualStyleBackColor = false;
            buttonHorarios.Click += buttonHorarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(155, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 1;
            label2.Text = "MENU";
            // 
            // buttonInscripcion
            // 
            buttonInscripcion.BackColor = Color.AliceBlue;
            buttonInscripcion.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonInscripcion.Location = new Point(65, 96);
            buttonInscripcion.Name = "buttonInscripcion";
            buttonInscripcion.Size = new Size(233, 34);
            buttonInscripcion.TabIndex = 0;
            buttonInscripcion.Text = "Inscripcion de Cursos";
            buttonInscripcion.UseVisualStyleBackColor = false;
            buttonInscripcion.Click += buttonInscripcion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(368, 145);
            label1.Name = "label1";
            label1.Size = new Size(305, 18);
            label1.TabIndex = 5;
            label1.Text = "Sistema de autogestion de alumnos";
            // 
            // MenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelBienvenida);
            Name = "MenuEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEstudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenida;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button3;
        private Button buttonHorarios;
        private Label label2;
        private Button buttonInscripcion;
        private Button buttonRealizarPagos;
        private Label label1;
    }
}