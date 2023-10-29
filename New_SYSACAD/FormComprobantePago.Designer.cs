namespace New_SYSACAD
{
    partial class FormComprobantePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprobantePago));
            labelNumeroComprobante = new Label();
            label2 = new Label();
            labelFecha = new Label();
            groupBox1 = new GroupBox();
            labelMetodoPago = new Label();
            label6 = new Label();
            labelDetalles = new Label();
            label4 = new Label();
            labelMonto = new Label();
            label3 = new Label();
            label1 = new Label();
            textConceptos = new TextBox();
            buttonVolver = new Button();
            pictureBox1 = new PictureBox();
            buttonDescargarPDF = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNumeroComprobante
            // 
            labelNumeroComprobante.AutoSize = true;
            labelNumeroComprobante.Location = new Point(237, 56);
            labelNumeroComprobante.Name = "labelNumeroComprobante";
            labelNumeroComprobante.Size = new Size(76, 25);
            labelNumeroComprobante.TabIndex = 0;
            labelNumeroComprobante.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 107);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha de pago :";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(177, 107);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(54, 25);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "fecha";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(labelMetodoPago);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(labelDetalles);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelMonto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textConceptos);
            groupBox1.Controls.Add(labelNumeroComprobante);
            groupBox1.Controls.Add(labelFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(207, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 669);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comprobante de Pago";
            // 
            // labelMetodoPago
            // 
            labelMetodoPago.AutoSize = true;
            labelMetodoPago.Location = new Point(199, 267);
            labelMetodoPago.Name = "labelMetodoPago";
            labelMetodoPago.Size = new Size(72, 25);
            labelMetodoPago.TabIndex = 11;
            labelMetodoPago.Text = "metodo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 267);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 10;
            label6.Text = "Metodo de pago:";
            // 
            // labelDetalles
            // 
            labelDetalles.AutoSize = true;
            labelDetalles.Location = new Point(18, 178);
            labelDetalles.Name = "labelDetalles";
            labelDetalles.Size = new Size(219, 25);
            labelDetalles.TabIndex = 9;
            labelDetalles.Text = "Detalles de la transaccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 419);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 7;
            label4.Text = "Conceptos de pago";
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(208, 347);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(63, 25);
            labelMonto.TabIndex = 6;
            labelMonto.Text = "monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 347);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Monto pagado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 56);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 4;
            label1.Text = "Numero de comprobante:";
            // 
            // textConceptos
            // 
            textConceptos.BackColor = Color.WhiteSmoke;
            textConceptos.Location = new Point(98, 462);
            textConceptos.Multiline = true;
            textConceptos.Name = "textConceptos";
            textConceptos.ReadOnly = true;
            textConceptos.Size = new Size(407, 148);
            textConceptos.TabIndex = 3;
            textConceptos.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(52, 39);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(864, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonDescargarPDF
            // 
            buttonDescargarPDF.Location = new Point(642, 36);
            buttonDescargarPDF.Name = "buttonDescargarPDF";
            buttonDescargarPDF.Size = new Size(140, 41);
            buttonDescargarPDF.TabIndex = 5;
            buttonDescargarPDF.Text = "Descargar PDF";
            buttonDescargarPDF.UseVisualStyleBackColor = true;
            buttonDescargarPDF.Click += buttonDescargarPDF_Click;
            // 
            // FormComprobantePago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(buttonDescargarPDF);
            Controls.Add(pictureBox1);
            Controls.Add(buttonVolver);
            Controls.Add(groupBox1);
            Name = "FormComprobantePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormComprobantePago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNumeroComprobante;
        private Label label2;
        private Label labelFecha;
        private GroupBox groupBox1;
        private TextBox textConceptos;
        private Label label1;
        private Label label4;
        private Label labelMonto;
        private Label label3;
        private Label labelDetalles;
        private Label label6;
        private Label labelMetodoPago;
        private Button buttonVolver;
        private PictureBox pictureBox1;
        private Button buttonDescargarPDF;
    }
}