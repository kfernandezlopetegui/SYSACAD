namespace New_SYSACAD
{
    partial class ConsultarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHorario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelIndicaciones = new Label();
            pictureBox1 = new PictureBox();
            buttonVolver = new Button();
            dataGridViewHorarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorarios).BeginInit();
            SuspendLayout();
            // 
            // labelIndicaciones
            // 
            labelIndicaciones.AutoSize = true;
            labelIndicaciones.BackColor = Color.AntiqueWhite;
            labelIndicaciones.Font = new Font("Verdana", 11F, FontStyle.Italic, GraphicsUnit.Point);
            labelIndicaciones.ForeColor = SystemColors.Desktop;
            labelIndicaciones.Location = new Point(250, 106);
            labelIndicaciones.Name = "labelIndicaciones";
            labelIndicaciones.Size = new Size(242, 26);
            labelIndicaciones.TabIndex = 15;
            labelIndicaciones.Text = "Cursos seleccionados\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(903, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVolver.Location = new Point(250, 632);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 33);
            buttonVolver.TabIndex = 17;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // dataGridViewHorarios
            // 
            dataGridViewHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHorarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewHorarios.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorarios.EnableHeadersVisualStyles = false;
            dataGridViewHorarios.GridColor = Color.AntiqueWhite;
            dataGridViewHorarios.Location = new Point(250, 172);
            dataGridViewHorarios.MultiSelect = false;
            dataGridViewHorarios.Name = "dataGridViewHorarios";
            dataGridViewHorarios.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHorarios.RowHeadersVisible = false;
            dataGridViewHorarios.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.Tomato;
            dataGridViewHorarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHorarios.RowTemplate.Height = 33;
            dataGridViewHorarios.Size = new Size(621, 416);
            dataGridViewHorarios.TabIndex = 18;
            dataGridViewHorarios.CellFormatting += dataGridViewHorarios_CellFormatting;
            // 
            // ConsultarHorario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(dataGridViewHorarios);
            Controls.Add(buttonVolver);
            Controls.Add(pictureBox1);
            Controls.Add(labelIndicaciones);
            Name = "ConsultarHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarHorario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelIndicaciones;
        private PictureBox pictureBox1;
        private Button buttonVolver;
        private DataGridView dataGridViewHorarios;
    }
}