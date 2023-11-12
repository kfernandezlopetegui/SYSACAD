namespace New_SYSACAD
{
    partial class EditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCurso));
            dataGridViewCursos = new DataGridView();
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            button1 = new Button();
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
            dataGridViewCursos.Location = new Point(156, 209);
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
            dataGridViewCursos.Size = new Size(769, 420);
            dataGridViewCursos.TabIndex = 0;
            dataGridViewCursos.CellContentClick += dataGridViewCursos_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(861, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.AntiqueWhite;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(385, 35);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(223, 29);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Listado de cursos";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(83, 704);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(156, 173);
            label1.Name = "label1";
            label1.Size = new Size(338, 22);
            label1.TabIndex = 4;
            label1.Text = "Seleccione el curso que desea editar";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditarCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewCursos);
            Name = "EditarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarCurso";
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
        private Label label1;
    }
}