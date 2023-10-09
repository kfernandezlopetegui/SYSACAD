namespace New_SYSACAD
{
    partial class ListaDeCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeCursos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewCursos = new DataGridView();
            buttonVolver = new Button();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonAgregar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.AntiqueWhite;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(362, 83);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(223, 29);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Listado de cursos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(856, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            dataGridViewCursos.Location = new Point(117, 188);
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
            dataGridViewCursos.Size = new Size(762, 420);
            dataGridViewCursos.TabIndex = 5;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVolver.Location = new Point(117, 653);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 6;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.AntiqueWhite;
            buttonEditar.BackgroundImage = (Image)resources.GetObject("buttonEditar.BackgroundImage");
            buttonEditar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEditar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(912, 384);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(71, 51);
            buttonEditar.TabIndex = 7;
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.AntiqueWhite;
            buttonEliminar.BackgroundImage = (Image)resources.GetObject("buttonEliminar.BackgroundImage");
            buttonEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEliminar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(912, 511);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(69, 57);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(907, 490);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 9;
            label1.Text = "Eliminar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(920, 351);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 10;
            label2.Text = "Editar";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.AntiqueWhite;
            buttonAgregar.BackgroundImage = (Image)resources.GetObject("buttonAgregar.BackgroundImage");
            buttonAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAgregar.Location = new Point(912, 242);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(64, 63);
            buttonAgregar.TabIndex = 11;
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(907, 212);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 12;
            label3.Text = "Agregar";
            // 
            // ListaDeCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(label3);
            Controls.Add(buttonAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonVolver);
            Controls.Add(dataGridViewCursos);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Name = "ListaDeCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeCursos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewCursos;
        private Button buttonVolver;
        private Button buttonEditar;
        private Button buttonEliminar;
        private Label label1;
        private Label label2;
        private Button buttonAgregar;
        private Label label3;
    }
}