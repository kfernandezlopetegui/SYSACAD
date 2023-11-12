namespace New_SYSACAD
{
    partial class GestionarRequisitosAcademicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarRequisitosAcademicos));
            dataGridViewCursos = new DataGridView();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            buttonEditar = new Button();
            label2 = new Label();
            buttonEliminar = new Button();
            label4 = new Label();
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
            dataGridViewCursos.Location = new Point(93, 194);
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
            dataGridViewCursos.Size = new Size(861, 420);
            dataGridViewCursos.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(291, 51);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(449, 29);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "Listado de cursos con sus requisitos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(849, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(117, 647);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.AntiqueWhite;
            buttonEditar.BackgroundImage = (Image)resources.GetObject("buttonEditar.BackgroundImage");
            buttonEditar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEditar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(978, 306);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(71, 51);
            buttonEditar.TabIndex = 14;
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(978, 285);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 15;
            label2.Text = "Editar";
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.AntiqueWhite;
            buttonEliminar.BackgroundImage = (Image)resources.GetObject("buttonEliminar.BackgroundImage");
            buttonEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEliminar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(978, 484);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(69, 57);
            buttonEliminar.TabIndex = 16;
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(975, 463);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 17;
            label4.Text = "Eliminar";
            // 
            // GestionarRequisitosAcademicos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(label4);
            Controls.Add(buttonEliminar);
            Controls.Add(label2);
            Controls.Add(buttonEditar);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Controls.Add(dataGridViewCursos);
            Name = "GestionarRequisitosAcademicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionarRequisitosAcademicos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        private Button button1;
        private Button buttonEditar;
        private Label label2;
        private Button buttonEliminar;
        private Label label4;
    }
}