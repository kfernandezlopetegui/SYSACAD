namespace New_SYSACAD
{
    partial class PruebaSQL
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
            buttonCrear = new Button();
            buttonBorrar = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBoxDni = new TextBox();
            textBoxNombreActualizar = new TextBox();
            textBoxApellidoActualizar = new TextBox();
            buttonActualizarTabla = new Button();
            button1 = new Button();
            textBoxValidar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(305, 288);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(112, 34);
            buttonCrear.TabIndex = 0;
            buttonCrear.Text = "Agregar";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(62, 89);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(112, 34);
            buttonBorrar.TabIndex = 1;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(610, 288);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Actualizar Tabla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 3;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(52, 33);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(150, 31);
            textBoxDni.TabIndex = 4;
            // 
            // textBoxNombreActualizar
            // 
            textBoxNombreActualizar.Location = new Point(610, 79);
            textBoxNombreActualizar.Name = "textBoxNombreActualizar";
            textBoxNombreActualizar.Size = new Size(150, 31);
            textBoxNombreActualizar.TabIndex = 5;
            // 
            // textBoxApellidoActualizar
            // 
            textBoxApellidoActualizar.Location = new Point(610, 164);
            textBoxApellidoActualizar.Name = "textBoxApellidoActualizar";
            textBoxApellidoActualizar.Size = new Size(150, 31);
            textBoxApellidoActualizar.TabIndex = 7;
            // 
            // buttonActualizarTabla
            // 
            buttonActualizarTabla.Location = new Point(417, 389);
            buttonActualizarTabla.Name = "buttonActualizarTabla";
            buttonActualizarTabla.Size = new Size(237, 34);
            buttonActualizarTabla.TabIndex = 8;
            buttonActualizarTabla.Text = "Actualizar Tabla";
            buttonActualizarTabla.UseVisualStyleBackColor = true;
            buttonActualizarTabla.Click += buttonActualizarTabla_Click;
            // 
            // button1
            // 
            button1.Location = new Point(52, 288);
            button1.Name = "button1";
            button1.Size = new Size(112, 59);
            button1.TabIndex = 9;
            button1.Text = "Verificar si existe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxValidar
            // 
            textBoxValidar.Location = new Point(34, 240);
            textBoxValidar.Name = "textBoxValidar";
            textBoxValidar.PlaceholderText = "id a verificar";
            textBoxValidar.Size = new Size(150, 31);
            textBoxValidar.TabIndex = 10;
            // 
            // PruebaSQL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxValidar);
            Controls.Add(button1);
            Controls.Add(buttonActualizarTabla);
            Controls.Add(textBoxApellidoActualizar);
            Controls.Add(textBoxNombreActualizar);
            Controls.Add(textBoxDni);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonCrear);
            Name = "PruebaSQL";
            Text = "PruebaSQL";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCrear;
        private Button buttonBorrar;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBoxDni;
        private TextBox textBoxNombreActualizar;
        private TextBox textBoxApellidoActualizar;
        private Button buttonActualizarTabla;
        private Button button1;
        private TextBox textBoxValidar;
    }
}