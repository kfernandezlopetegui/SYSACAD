namespace New_SYSACAD
{
    partial class ListaProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProfesores));
            dataGridViewCursos = new DataGridView();
            pictureBox1 = new PictureBox();
            buttonVolver = new Button();
            label1 = new Label();
            labelTitulo = new Label();
            buttonAgregar = new Button();
            label3 = new Label();
            buttonEliminar = new Button();
            label2 = new Label();
            buttonEditar = new Button();
            label4 = new Label();
            buttonAsignarCursos = new Button();
            label5 = new Label();
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
            dataGridViewCursos.Location = new Point(59, 221);
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
            dataGridViewCursos.Size = new Size(848, 350);
            dataGridViewCursos.TabIndex = 4;
            dataGridViewCursos.CellContentClick += dataGridViewCursos_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(843, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // buttonVolver
            // 
            buttonVolver.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVolver.Location = new Point(59, 588);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(125, 42);
            buttonVolver.TabIndex = 13;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(71, 182);
            label1.Name = "label1";
            label1.Size = new Size(744, 25);
            label1.TabIndex = 14;
            label1.Text = "Seleccione el Profesor que quiere asignar curso/editar/eliminar de la lista";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(274, 82);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(421, 29);
            labelTitulo.TabIndex = 15;
            labelTitulo.Text = "Sistema de gestion de Profesores ";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Honeydew;
            buttonAgregar.BackgroundImage = (Image)resources.GetObject("buttonAgregar.BackgroundImage");
            buttonAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAgregar.Location = new Point(956, 182);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(64, 63);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(949, 161);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 17;
            label3.Text = "Agregar";
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Honeydew;
            buttonEliminar.BackgroundImage = (Image)resources.GetObject("buttonEliminar.BackgroundImage");
            buttonEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEliminar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(951, 514);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(69, 57);
            buttonEliminar.TabIndex = 18;
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(949, 493);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 19;
            label2.Text = "Eliminar";
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Honeydew;
            buttonEditar.BackgroundImage = (Image)resources.GetObject("buttonEditar.BackgroundImage");
            buttonEditar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEditar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(949, 409);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(71, 51);
            buttonEditar.TabIndex = 20;
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(956, 388);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 21;
            label4.Text = "Editar";
            // 
            // buttonAsignarCursos
            // 
            buttonAsignarCursos.BackColor = Color.Honeydew;
            buttonAsignarCursos.BackgroundImage = (Image)resources.GetObject("buttonAsignarCursos.BackgroundImage");
            buttonAsignarCursos.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAsignarCursos.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonAsignarCursos.Location = new Point(949, 301);
            buttonAsignarCursos.Name = "buttonAsignarCursos";
            buttonAsignarCursos.Size = new Size(71, 53);
            buttonAsignarCursos.TabIndex = 22;
            buttonAsignarCursos.UseVisualStyleBackColor = false;
            buttonAsignarCursos.Click += buttonAsignarCursos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(925, 280);
            label5.Name = "label5";
            label5.Size = new Size(130, 18);
            label5.TabIndex = 23;
            label5.Text = "Asignar Cursos";
            // 
            // ListaProfesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(label5);
            Controls.Add(buttonAsignarCursos);
            Controls.Add(label4);
            Controls.Add(buttonEditar);
            Controls.Add(label2);
            Controls.Add(buttonEliminar);
            Controls.Add(label3);
            Controls.Add(buttonAgregar);
            Controls.Add(labelTitulo);
            Controls.Add(label1);
            Controls.Add(buttonVolver);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewCursos);
            Name = "ListaProfesores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaProfesores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private PictureBox pictureBox1;
        private Button buttonVolver;
        private Label label1;
        private Label labelTitulo;
        private Button buttonAgregar;
        private Label label3;
        private Button buttonEliminar;
        private Label label2;
        private Button buttonEditar;
        private Label label4;
        private Button buttonAsignarCursos;
        private Label label5;
    }
}