namespace New_SYSACAD
{
    partial class FormPagosPendientes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagosPendientes));
            dataGridView1 = new DataGridView();
            labelIndicaciones = new Label();
            pictureBox1 = new PictureBox();
            buttonVolver = new Button();
            buttonInscripcion = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = Color.AntiqueWhite;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.GridColor = Color.AntiqueWhite;
            dataGridView1.Location = new Point(204, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(634, 359);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // labelIndicaciones
            // 
            labelIndicaciones.AutoSize = true;
            labelIndicaciones.BackColor = Color.AntiqueWhite;
            labelIndicaciones.Font = new Font("Verdana", 11F, FontStyle.Italic, GraphicsUnit.Point);
            labelIndicaciones.Location = new Point(414, 75);
            labelIndicaciones.Name = "labelIndicaciones";
            labelIndicaciones.Size = new Size(205, 26);
            labelIndicaciones.TabIndex = 10;
            labelIndicaciones.Text = "Pagos pendientes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(879, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVolver.Location = new Point(204, 597);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 12;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonInscripcion
            // 
            buttonInscripcion.BackColor = Color.SeaShell;
            buttonInscripcion.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonInscripcion.Location = new Point(726, 597);
            buttonInscripcion.Name = "buttonInscripcion";
            buttonInscripcion.Size = new Size(112, 34);
            buttonInscripcion.TabIndex = 13;
            buttonInscripcion.Text = "Pagar";
            buttonInscripcion.UseVisualStyleBackColor = false;
            buttonInscripcion.Click += buttonInscripcion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(204, 155);
            label1.Name = "label1";
            label1.Size = new Size(388, 18);
            label1.TabIndex = 14;
            label1.Text = "Ingrese el importe a pagar en cada concepto:";
            // 
            // FormPagosPendientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(label1);
            Controls.Add(buttonInscripcion);
            Controls.Add(buttonVolver);
            Controls.Add(pictureBox1);
            Controls.Add(labelIndicaciones);
            Controls.Add(dataGridView1);
            Name = "FormPagosPendientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPagosPendientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelIndicaciones;
        private PictureBox pictureBox1;
        private Button buttonVolver;
        private Button buttonInscripcion;
        private Label label1;
    }
}