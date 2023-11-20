namespace New_SYSACAD
{
    partial class MostrarListaEsperaCurso
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarListaEsperaCurso));
            dataGridViewCursos = new DataGridView();
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            button1 = new Button();
            buttonAgregar = new Button();
            label3 = new Label();
            buttonEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            dataGridViewCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCursos.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.EnableHeadersVisualStyles = false;
            dataGridViewCursos.GridColor = Color.AntiqueWhite;
            dataGridViewCursos.Location = new Point(76, 206);
            dataGridViewCursos.MultiSelect = false;
            dataGridViewCursos.Name = "dataGridViewCursos";
            dataGridViewCursos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCursos.RowHeadersVisible = false;
            dataGridViewCursos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.Tomato;
            dataGridViewCursos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCursos.RowTemplate.Height = 33;
            dataGridViewCursos.Size = new Size(836, 361);
            dataGridViewCursos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(856, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(121, 89);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(239, 29);
            labelTitulo.TabIndex = 9;
            labelTitulo.Text = "Lista de espera de ";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(76, 606);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Bisque;
            buttonAgregar.BackgroundImage = (Image)resources.GetObject("buttonAgregar.BackgroundImage");
            buttonAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAgregar.Location = new Point(949, 265);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(64, 63);
            buttonAgregar.TabIndex = 12;
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(949, 244);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 13;
            label3.Text = "Agregar";
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Bisque;
            buttonEliminar.BackgroundImage = (Image)resources.GetObject("buttonEliminar.BackgroundImage");
            buttonEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEliminar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(951, 471);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(69, 57);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(949, 450);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 15;
            label1.Text = "Eliminar";
            // 
            // MostrarListaEsperaCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(label3);
            Controls.Add(buttonAgregar);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewCursos);
            Name = "MostrarListaEsperaCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MostrarListaEsperaCurso";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private PictureBox pictureBox1;
        private Label labelTitulo;
        private Button button1;
        private Button buttonAgregar;
        private Label label3;
        private Button buttonEliminar;
        private Label label1;
    }
}