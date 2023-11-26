namespace New_SYSACAD
{
    partial class PedirInformeInscripcionesPorPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedirInformeInscripcionesPorPeriodo));
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            buttonInscripciones = new Button();
            label1 = new Label();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            buttonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(64, 181);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(398, 29);
            dateTimePickerFin.TabIndex = 18;
            dateTimePickerFin.ValueChanged += dateTimePickerFin_ValueChanged;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(64, 78);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(398, 29);
            dateTimePickerInicio.TabIndex = 17;
            dateTimePickerInicio.ValueChanged += dateTimePickerInicio_ValueChanged;
            // 
            // buttonInscripciones
            // 
            buttonInscripciones.ForeColor = Color.DarkSlateGray;
            buttonInscripciones.Location = new Point(589, 647);
            buttonInscripciones.Name = "buttonInscripciones";
            buttonInscripciones.Size = new Size(195, 34);
            buttonInscripciones.TabIndex = 16;
            buttonInscripciones.Text = "Obtener Informe PDF";
            buttonInscripciones.UseVisualStyleBackColor = true;
            buttonInscripciones.Click += buttonInscripciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(281, 243);
            label1.Name = "label1";
            label1.Size = new Size(395, 25);
            label1.TabIndex = 19;
            label1.Text = "Seleccione el periodo de inscripciones:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(286, 120);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(457, 29);
            labelTitulo.TabIndex = 20;
            labelTitulo.Text = "Informe de inscripciones por periodo";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(816, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerFin);
            groupBox1.Controls.Add(dateTimePickerInicio);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(281, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 263);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(69, 150);
            label3.Name = "label3";
            label3.Size = new Size(326, 18);
            label3.TabIndex = 20;
            label3.Text = "Seleccione la fecha de fin del periodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(64, 50);
            label2.Name = "label2";
            label2.Size = new Size(349, 18);
            label2.TabIndex = 19;
            label2.Text = "Seleccione la fecha de inicio del periodo:";
            // 
            // buttonVolver
            // 
            buttonVolver.ForeColor = Color.DarkSlateGray;
            buttonVolver.Location = new Point(272, 647);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(147, 34);
            buttonVolver.TabIndex = 23;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // PedirInformeInscripcionesPorPeriodo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(buttonVolver);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Controls.Add(buttonInscripciones);
            Controls.Add(label1);
            Name = "PedirInformeInscripcionesPorPeriodo";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerFin;
        private DateTimePicker dateTimePickerInicio;
        private Button buttonInscripciones;
        private Label label1;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button buttonVolver;
    }
}