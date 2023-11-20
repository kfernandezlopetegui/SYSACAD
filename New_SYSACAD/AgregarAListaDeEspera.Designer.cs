namespace New_SYSACAD
{
    partial class AgregarAListaDeEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAListaDeEspera));
            dataGridViewCursos = new DataGridView();
            labelTitulo = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            pictureBox1 = new PictureBox();
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
            dataGridViewCursos.Location = new Point(112, 218);
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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkSlateGray;
            labelTitulo.Location = new Point(412, 89);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(216, 29);
            labelTitulo.TabIndex = 11;
            labelTitulo.Text = "Lista de alumnos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(27, 155);
            label1.Name = "label1";
            label1.Size = new Size(611, 25);
            label1.TabIndex = 14;
            label1.Text = "Seleccione el alumno que desea agregar a la lista de espera";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(112, 613);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(112, 34);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(836, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // AgregarAListaDeEspera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(label1);
            Controls.Add(labelTitulo);
            Controls.Add(dataGridViewCursos);
            Name = "AgregarAListaDeEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarAListaDeEspera";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private Label labelTitulo;
        private Label label1;
        private Button buttonCancelar;
        private PictureBox pictureBox1;
    }
}