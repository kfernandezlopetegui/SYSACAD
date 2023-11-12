namespace New_SYSACAD
{
    partial class EdicionRequisito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionRequisito));
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            textBoxPromedio = new TextBox();
            textBoxCreditosObtenidos = new TextBox();
            label3 = new Label();
            checkedListBoxPreCursos = new CheckedListBox();
            buttonGuardar = new Button();
            buttonVolver = new Button();
            pictureBox1 = new PictureBox();
            labelTituloNombre = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPromedio);
            groupBox1.Controls.Add(textBoxCreditosObtenidos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkedListBoxPreCursos);
            groupBox1.Controls.Add(buttonGuardar);
            groupBox1.Controls.Add(buttonVolver);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RosyBrown;
            groupBox1.Location = new Point(173, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 529);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edicion de Requisitos Academicos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 45);
            label5.Name = "label5";
            label5.Size = new Size(176, 22);
            label5.TabIndex = 22;
            label5.Text = "Creditos minimos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 168);
            label4.Name = "label4";
            label4.Size = new Size(178, 22);
            label4.TabIndex = 21;
            label4.Text = "Promedio minimo:";
            // 
            // textBoxPromedio
            // 
            textBoxPromedio.BackColor = Color.Snow;
            textBoxPromedio.ForeColor = SystemColors.Desktop;
            textBoxPromedio.Location = new Point(159, 202);
            textBoxPromedio.Name = "textBoxPromedio";
            textBoxPromedio.PlaceholderText = "Ingrese promedio minimo";
            textBoxPromedio.Size = new Size(374, 29);
            textBoxPromedio.TabIndex = 20;
            textBoxPromedio.TextAlign = HorizontalAlignment.Center;
            textBoxPromedio.Validated += textBoxPromedio_Validated;
            // 
            // textBoxCreditosObtenidos
            // 
            textBoxCreditosObtenidos.BackColor = Color.Snow;
            textBoxCreditosObtenidos.ForeColor = SystemColors.Desktop;
            textBoxCreditosObtenidos.Location = new Point(156, 80);
            textBoxCreditosObtenidos.Name = "textBoxCreditosObtenidos";
            textBoxCreditosObtenidos.PlaceholderText = "Ingrese Créditos minimos";
            textBoxCreditosObtenidos.Size = new Size(374, 29);
            textBoxCreditosObtenidos.TabIndex = 19;
            textBoxCreditosObtenidos.TextAlign = HorizontalAlignment.Center;
            textBoxCreditosObtenidos.Validated += textBoxCreditosObtenidos_Validated;
            // 
            // label3
            // 
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(153, 279);
            label3.Name = "label3";
            label3.Size = new Size(370, 26);
            label3.TabIndex = 18;
            label3.Text = "Cursos correlativos:";
            // 
            // checkedListBoxPreCursos
            // 
            checkedListBoxPreCursos.BackColor = Color.Snow;
            checkedListBoxPreCursos.FormattingEnabled = true;
            checkedListBoxPreCursos.Location = new Point(156, 317);
            checkedListBoxPreCursos.Name = "checkedListBoxPreCursos";
            checkedListBoxPreCursos.Size = new Size(377, 56);
            checkedListBoxPreCursos.TabIndex = 17;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.SeaShell;
            buttonGuardar.ForeColor = Color.IndianRed;
            buttonGuardar.Location = new Point(421, 443);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(112, 34);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.ForeColor = Color.IndianRed;
            buttonVolver.Location = new Point(153, 443);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(875, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelTituloNombre
            // 
            labelTituloNombre.AutoSize = true;
            labelTituloNombre.BackColor = Color.Transparent;
            labelTituloNombre.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTituloNombre.Location = new Point(173, 72);
            labelTituloNombre.Name = "labelTituloNombre";
            labelTituloNombre.Size = new Size(617, 29);
            labelTituloNombre.TabIndex = 7;
            labelTituloNombre.Text = "Requisitos Academicos de Nombre Curso y codigo";
            // 
            // EdicionRequisito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(labelTituloNombre);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "EdicionRequisito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EdicionRequisito";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPromedio;
        private TextBox textBoxCreditosObtenidos;
        private Label label3;
        private CheckedListBox checkedListBoxPreCursos;
        private Button buttonGuardar;
        private Button buttonVolver;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label labelTituloNombre;
    }
}