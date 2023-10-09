namespace New_SYSACAD
{
    partial class MetodosDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodosDePago));
            tabControl1 = new TabControl();
            tabPageTarjeta = new TabPage();
            label3 = new Label();
            label2 = new Label();
            textBoxFechaExpiracion = new TextBox();
            label1 = new Label();
            labelNumeroTarjeta = new Label();
            textBoxNombreTitularTarjeta = new TextBox();
            textBoxCvc = new TextBox();
            textBoxNumeroTarjeta = new TextBox();
            tabPageCuentaBancaria = new TabPage();
            textBoxNombreBanco = new TextBox();
            label6 = new Label();
            textBoxNumeroCuenta = new TextBox();
            label5 = new Label();
            textBoxNombreTitular = new TextBox();
            label4 = new Label();
            labelTitulo = new Label();
            buttonCancelar = new Button();
            buttonPagar = new Button();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPageTarjeta.SuspendLayout();
            tabPageCuentaBancaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTarjeta);
            tabControl1.Controls.Add(tabPageCuentaBancaria);
            tabControl1.Location = new Point(227, 158);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(589, 434);
            tabControl1.TabIndex = 0;
            // 
            // tabPageTarjeta
            // 
            tabPageTarjeta.BackColor = Color.WhiteSmoke;
            tabPageTarjeta.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageTarjeta.Controls.Add(label3);
            tabPageTarjeta.Controls.Add(label2);
            tabPageTarjeta.Controls.Add(textBoxFechaExpiracion);
            tabPageTarjeta.Controls.Add(label1);
            tabPageTarjeta.Controls.Add(labelNumeroTarjeta);
            tabPageTarjeta.Controls.Add(textBoxNombreTitularTarjeta);
            tabPageTarjeta.Controls.Add(textBoxCvc);
            tabPageTarjeta.Controls.Add(textBoxNumeroTarjeta);
            tabPageTarjeta.Location = new Point(4, 31);
            tabPageTarjeta.Name = "tabPageTarjeta";
            tabPageTarjeta.Padding = new Padding(3);
            tabPageTarjeta.Size = new Size(581, 399);
            tabPageTarjeta.TabIndex = 0;
            tabPageTarjeta.Text = "Tarjeta de credito/debito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(385, 262);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 7;
            label3.Text = "CVV/CVC2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(31, 262);
            label2.Name = "label2";
            label2.Size = new Size(172, 18);
            label2.TabIndex = 6;
            label2.Text = "Fecha de expiración";
            // 
            // textBoxFechaExpiracion
            // 
            textBoxFechaExpiracion.ForeColor = SystemColors.InactiveCaption;
            textBoxFechaExpiracion.Location = new Point(31, 299);
            textBoxFechaExpiracion.Name = "textBoxFechaExpiracion";
            textBoxFechaExpiracion.PlaceholderText = "MM/YY";
            textBoxFechaExpiracion.Size = new Size(150, 29);
            textBoxFechaExpiracion.TabIndex = 5;
            textBoxFechaExpiracion.Validated += textBoxFechaExpiracion_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(31, 144);
            label1.Name = "label1";
            label1.Size = new Size(158, 18);
            label1.TabIndex = 4;
            label1.Text = "Nombre del titular";
            // 
            // labelNumeroTarjeta
            // 
            labelNumeroTarjeta.AutoSize = true;
            labelNumeroTarjeta.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            labelNumeroTarjeta.ForeColor = SystemColors.InfoText;
            labelNumeroTarjeta.Location = new Point(31, 49);
            labelNumeroTarjeta.Name = "labelNumeroTarjeta";
            labelNumeroTarjeta.Size = new Size(159, 18);
            labelNumeroTarjeta.TabIndex = 3;
            labelNumeroTarjeta.Text = "Número de tarjeta";
            // 
            // textBoxNombreTitularTarjeta
            // 
            textBoxNombreTitularTarjeta.Location = new Point(31, 165);
            textBoxNombreTitularTarjeta.Name = "textBoxNombreTitularTarjeta";
            textBoxNombreTitularTarjeta.Size = new Size(504, 29);
            textBoxNombreTitularTarjeta.TabIndex = 2;
            textBoxNombreTitularTarjeta.Validated += textBoxNombreTitularTarjeta_Validated;
            // 
            // textBoxCvc
            // 
            textBoxCvc.ForeColor = SystemColors.InactiveCaption;
            textBoxCvc.Location = new Point(385, 299);
            textBoxCvc.Name = "textBoxCvc";
            textBoxCvc.PlaceholderText = "CVC";
            textBoxCvc.Size = new Size(150, 29);
            textBoxCvc.TabIndex = 1;
            textBoxCvc.Validated += textBoxCvc_Validated;
            // 
            // textBoxNumeroTarjeta
            // 
            textBoxNumeroTarjeta.Location = new Point(31, 86);
            textBoxNumeroTarjeta.Name = "textBoxNumeroTarjeta";
            textBoxNumeroTarjeta.Size = new Size(504, 29);
            textBoxNumeroTarjeta.TabIndex = 2;
            textBoxNumeroTarjeta.Validated += textBoxNumeroTarjeta_Validated;
            // 
            // tabPageCuentaBancaria
            // 
            tabPageCuentaBancaria.BackColor = Color.WhiteSmoke;
            tabPageCuentaBancaria.Controls.Add(textBoxNombreBanco);
            tabPageCuentaBancaria.Controls.Add(label6);
            tabPageCuentaBancaria.Controls.Add(textBoxNumeroCuenta);
            tabPageCuentaBancaria.Controls.Add(label5);
            tabPageCuentaBancaria.Controls.Add(textBoxNombreTitular);
            tabPageCuentaBancaria.Controls.Add(label4);
            tabPageCuentaBancaria.Location = new Point(4, 31);
            tabPageCuentaBancaria.Name = "tabPageCuentaBancaria";
            tabPageCuentaBancaria.Padding = new Padding(3);
            tabPageCuentaBancaria.Size = new Size(581, 399);
            tabPageCuentaBancaria.TabIndex = 1;
            tabPageCuentaBancaria.Text = "Cuenta Bancaria";
            // 
            // textBoxNombreBanco
            // 
            textBoxNombreBanco.Location = new Point(34, 292);
            textBoxNombreBanco.Name = "textBoxNombreBanco";
            textBoxNombreBanco.Size = new Size(455, 29);
            textBoxNombreBanco.TabIndex = 9;
            textBoxNombreBanco.Validated += textBoxNombreBanco_Validated;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.InfoText;
            label6.Location = new Point(34, 254);
            label6.Name = "label6";
            label6.Size = new Size(127, 18);
            label6.TabIndex = 8;
            label6.Text = "Nombre Banco";
            // 
            // textBoxNumeroCuenta
            // 
            textBoxNumeroCuenta.Location = new Point(34, 55);
            textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            textBoxNumeroCuenta.Size = new Size(455, 29);
            textBoxNumeroCuenta.TabIndex = 7;
            textBoxNumeroCuenta.Validated += textBoxNumeroCuenta_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(34, 23);
            label5.Name = "label5";
            label5.Size = new Size(159, 18);
            label5.TabIndex = 6;
            label5.Text = "Número de cuenta";
            // 
            // textBoxNombreTitular
            // 
            textBoxNombreTitular.Location = new Point(34, 167);
            textBoxNombreTitular.Name = "textBoxNombreTitular";
            textBoxNombreTitular.Size = new Size(455, 29);
            textBoxNombreTitular.TabIndex = 5;
            textBoxNombreTitular.Validated += textBoxNombreTitular_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(34, 137);
            label4.Name = "label4";
            label4.Size = new Size(131, 18);
            label4.TabIndex = 4;
            label4.Text = "Nombre Titular";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Verdana", 11F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(227, 79);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(208, 26);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Opciones de pago";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(377, 634);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(112, 34);
            buttonCancelar.TabIndex = 0;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.DarkBlue;
            buttonPagar.ForeColor = SystemColors.HighlightText;
            buttonPagar.Location = new Point(532, 634);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(146, 34);
            buttonPagar.TabIndex = 2;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(903, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MetodosDePago
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1067, 803);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPagar);
            Controls.Add(buttonCancelar);
            Controls.Add(labelTitulo);
            Controls.Add(tabControl1);
            Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "MetodosDePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetodosDePago";
            tabControl1.ResumeLayout(false);
            tabPageTarjeta.ResumeLayout(false);
            tabPageTarjeta.PerformLayout();
            tabPageCuentaBancaria.ResumeLayout(false);
            tabPageCuentaBancaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageTarjeta;
        private TabPage tabPageCuentaBancaria;
        private Label labelTitulo;
        private Button buttonCancelar;
        private TextBox textBoxNombreTitularTarjeta;
        private TextBox textBoxCvc;
        private TextBox textBoxNumeroTarjeta;
        private Label labelNumeroTarjeta;
        private Label label1;
        private Button buttonPagar;
        private TextBox textBoxFechaExpiracion;
        private Label label3;
        private Label label2;
        private TextBox textBoxNombreBanco;
        private Label label6;
        private TextBox textBoxNumeroCuenta;
        private Label label5;
        private TextBox textBoxNombreTitular;
        private Label label4;
        private PictureBox pictureBox1;
    }
}