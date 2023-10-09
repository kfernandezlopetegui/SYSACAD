namespace New_SYSACAD
{
    partial class MenuGestionarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGestionarCursos));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonEliminarCurso = new Button();
            buttonSalir = new Button();
            buttonEditarCurso = new Button();
            label2 = new Label();
            buttonAgregarCurso = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AntiqueWhite;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonEliminarCurso);
            groupBox1.Controls.Add(buttonSalir);
            groupBox1.Controls.Add(buttonEditarCurso);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonAgregarCurso);
            groupBox1.Location = new Point(335, 343);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 414);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // buttonEliminarCurso
            // 
            buttonEliminarCurso.BackColor = Color.LightBlue;
            buttonEliminarCurso.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminarCurso.Location = new Point(66, 284);
            buttonEliminarCurso.Name = "buttonEliminarCurso";
            buttonEliminarCurso.Size = new Size(204, 34);
            buttonEliminarCurso.TabIndex = 4;
            buttonEliminarCurso.Text = "Eliminar Curso";
            buttonEliminarCurso.UseVisualStyleBackColor = false;
            buttonEliminarCurso.Click += buttonEliminarCurso_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Teal;
            buttonSalir.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.Location = new Point(66, 359);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(204, 34);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonEditarCurso
            // 
            buttonEditarCurso.BackColor = Color.LightBlue;
            buttonEditarCurso.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarCurso.Location = new Point(66, 213);
            buttonEditarCurso.Name = "buttonEditarCurso";
            buttonEditarCurso.Size = new Size(204, 34);
            buttonEditarCurso.TabIndex = 2;
            buttonEditarCurso.Text = "Editar Curso";
            buttonEditarCurso.UseVisualStyleBackColor = false;
            buttonEditarCurso.Click += buttonEditarCurso_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(136, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 1;
            label2.Text = "MENU";
            // 
            // buttonAgregarCurso
            // 
            buttonAgregarCurso.BackColor = Color.LightBlue;
            buttonAgregarCurso.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarCurso.Location = new Point(66, 136);
            buttonAgregarCurso.Name = "buttonAgregarCurso";
            buttonAgregarCurso.Size = new Size(204, 34);
            buttonAgregarCurso.TabIndex = 5;
            buttonAgregarCurso.Text = "Agregar Curso";
            buttonAgregarCurso.UseVisualStyleBackColor = false;
            buttonAgregarCurso.Click += buttonAgregarCurso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(372, 258);
            label1.Name = "label1";
            label1.Size = new Size(274, 22);
            label1.TabIndex = 5;
            label1.Text = "Sistema de administracion de cursos";
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(66, 63);
            button1.Name = "button1";
            button1.Size = new Size(204, 34);
            button1.TabIndex = 0;
            button1.Text = "Listado de  Cursos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MenuGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "MenuGestionarCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuGestionarCursos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button buttonEliminarCurso;
        private Button buttonSalir;
        private Button buttonEditarCurso;
        private Label label2;
        private Button buttonAgregarCurso;
        private Label label1;
        private Button button1;
    }
}