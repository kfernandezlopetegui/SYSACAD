namespace New_SYSACAD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            process1 = new System.Diagnostics.Process();
            buttonHarcodearAlumno = new Button();
            buttonHarcodearAdmin = new Button();
            buttonPruebas = new Button();
            buttonAgregarAprobado = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(358, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(424, 172);
            label1.Name = "label1";
            label1.Size = new Size(204, 18);
            label1.TabIndex = 1;
            label1.Text = "Sistema de autogestion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(76, 38);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 2;
            label2.Text = "Iniciar Sesion";
            // 
            // textBox1
            // 
            textBox1.AutoCompleteSource = AutoCompleteSource.AllUrl;
            textBox1.BackColor = Color.SeaShell;
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(83, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 29);
            textBox1.TabIndex = 3;
            textBox1.Tag = "";
            textBox1.Text = "Usuario";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += textBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SeaShell;
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(83, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 29);
            textBox2.TabIndex = 4;
            textBox2.Text = "Contraseña";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Enter += textBox2_Enter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(370, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 331);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(99, 241);
            button1.Name = "button1";
            button1.Size = new Size(108, 33);
            button1.TabIndex = 0;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // buttonHarcodearAlumno
            // 
            buttonHarcodearAlumno.BackColor = Color.AntiqueWhite;
            buttonHarcodearAlumno.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            buttonHarcodearAlumno.Location = new Point(896, 407);
            buttonHarcodearAlumno.Name = "buttonHarcodearAlumno";
            buttonHarcodearAlumno.Size = new Size(125, 59);
            buttonHarcodearAlumno.TabIndex = 6;
            buttonHarcodearAlumno.Text = "Credenciales Alumno";
            buttonHarcodearAlumno.UseVisualStyleBackColor = false;
            buttonHarcodearAlumno.Click += buttonHarcodearAlumno_Click;
            // 
            // buttonHarcodearAdmin
            // 
            buttonHarcodearAdmin.BackColor = Color.AntiqueWhite;
            buttonHarcodearAdmin.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            buttonHarcodearAdmin.Location = new Point(896, 288);
            buttonHarcodearAdmin.Name = "buttonHarcodearAdmin";
            buttonHarcodearAdmin.Size = new Size(125, 59);
            buttonHarcodearAdmin.TabIndex = 7;
            buttonHarcodearAdmin.Text = "Credenciales Admin";
            buttonHarcodearAdmin.UseVisualStyleBackColor = false;
            buttonHarcodearAdmin.Click += buttonHarcodearAdmin_Click;
            // 
            // buttonPruebas
            // 
            buttonPruebas.BackColor = Color.AntiqueWhite;
            buttonPruebas.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            buttonPruebas.Location = new Point(896, 522);
            buttonPruebas.Name = "buttonPruebas";
            buttonPruebas.Size = new Size(125, 59);
            buttonPruebas.TabIndex = 8;
            buttonPruebas.Text = "Pruebas SQL";
            buttonPruebas.UseVisualStyleBackColor = false;
            buttonPruebas.Click += buttonPruebas_Click;
            // 
            // buttonAgregarAprobado
            // 
            buttonAgregarAprobado.BackColor = Color.AntiqueWhite;
            buttonAgregarAprobado.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            buttonAgregarAprobado.Location = new Point(896, 184);
            buttonAgregarAprobado.Name = "buttonAgregarAprobado";
            buttonAgregarAprobado.Size = new Size(125, 59);
            buttonAgregarAprobado.TabIndex = 9;
            buttonAgregarAprobado.Text = "Agregar Aprobado";
            buttonAgregarAprobado.UseVisualStyleBackColor = false;
            buttonAgregarAprobado.Click += buttonAgregarAprobado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 799);
            Controls.Add(buttonAgregarAprobado);
            Controls.Add(buttonPruebas);
            Controls.Add(buttonHarcodearAdmin);
            Controls.Add(buttonHarcodearAlumno);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button button1;
        private System.Diagnostics.Process process1;
        private Button buttonHarcodearAdmin;
        private Button buttonHarcodearAlumno;
        private Button buttonPruebas;
        private Button buttonAgregarAprobado;
    }
}