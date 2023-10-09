namespace New_SYSACAD
{
    partial class RegistroAlumno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAlumno));
            groupBox1 = new GroupBox();
            labelConfirmacion = new Label();
            button2 = new Button();
            button1 = new Button();
            textPalabraClave = new TextBox();
            textContraseñaP = new TextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            FechaDeNacimiento = new DateTimePicker();
            textDni = new TextBox();
            textTelefono = new TextBox();
            textDireccion = new TextBox();
            textMail = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            timerExito = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AntiqueWhite;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(labelConfirmacion);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textPalabraClave);
            groupBox1.Controls.Add(textContraseñaP);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaDeNacimiento);
            groupBox1.Controls.Add(textDni);
            groupBox1.Controls.Add(textTelefono);
            groupBox1.Controls.Add(textDireccion);
            groupBox1.Controls.Add(textMail);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.ForeColor = SystemColors.ButtonShadow;
            groupBox1.Location = new Point(236, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 744);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar estudiante";
            // 
            // labelConfirmacion
            // 
            labelConfirmacion.AutoSize = true;
            labelConfirmacion.ForeColor = Color.ForestGreen;
            labelConfirmacion.Location = new Point(6, 619);
            labelConfirmacion.Name = "labelConfirmacion";
            labelConfirmacion.Size = new Size(0, 25);
            labelConfirmacion.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuText;
            button2.Location = new Point(42, 684);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(282, 684);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textPalabraClave
            // 
            textPalabraClave.BackColor = Color.SeaShell;
            textPalabraClave.ForeColor = SystemColors.InactiveCaption;
            textPalabraClave.Location = new Point(52, 460);
            textPalabraClave.Name = "textPalabraClave";
            textPalabraClave.Size = new Size(342, 31);
            textPalabraClave.TabIndex = 10;
            textPalabraClave.Text = "Ingrese palabra clave";
            textPalabraClave.TextAlign = HorizontalAlignment.Center;
            textPalabraClave.Enter += textPalabraClave_Enter;
            textPalabraClave.Validated += textPalabraClave_Validated;
            // 
            // textContraseñaP
            // 
            textContraseñaP.BackColor = Color.SeaShell;
            textContraseñaP.ForeColor = SystemColors.InactiveCaption;
            textContraseñaP.Location = new Point(52, 406);
            textContraseñaP.Name = "textContraseñaP";
            textContraseñaP.Size = new Size(342, 31);
            textContraseñaP.TabIndex = 9;
            textContraseñaP.Text = "Ingrese contraseña provisional\r\n";
            textContraseñaP.TextAlign = HorizontalAlignment.Center;
            textContraseñaP.Enter += textContraseñaP_Enter;
            textContraseñaP.Validated += textContraseñaP_Validated;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.AntiqueWhite;
            checkBox1.Location = new Point(52, 571);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(372, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Solicitar cambio de contraseña provisional";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(52, 519);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 7;
            label1.Text = "Fecha de nacimiento:";
            // 
            // FechaDeNacimiento
            // 
            FechaDeNacimiento.CalendarMonthBackground = Color.SeaShell;
            FechaDeNacimiento.CustomFormat = "dd/MM/yyyy";
            FechaDeNacimiento.Format = DateTimePickerFormat.Custom;
            FechaDeNacimiento.Location = new Point(278, 513);
            FechaDeNacimiento.Name = "FechaDeNacimiento";
            FechaDeNacimiento.Size = new Size(28, 31);
            FechaDeNacimiento.TabIndex = 6;
            FechaDeNacimiento.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            FechaDeNacimiento.Validated += FechaDeNacimiento_Validated;
            // 
            // textDni
            // 
            textDni.BackColor = Color.SeaShell;
            textDni.ForeColor = SystemColors.InactiveCaption;
            textDni.Location = new Point(52, 85);
            textDni.Name = "textDni";
            textDni.Size = new Size(342, 31);
            textDni.TabIndex = 5;
            textDni.Text = "Ingrese DNI";
            textDni.TextAlign = HorizontalAlignment.Center;
            textDni.Enter += textDni_Enter;
            textDni.Validated += textDni_Validated;
            // 
            // textTelefono
            // 
            textTelefono.BackColor = Color.SeaShell;
            textTelefono.ForeColor = SystemColors.InactiveCaption;
            textTelefono.Location = new Point(52, 241);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(342, 31);
            textTelefono.TabIndex = 4;
            textTelefono.Text = "Ingrese telefono";
            textTelefono.TextAlign = HorizontalAlignment.Center;
            textTelefono.Enter += textTelefono_Enter;
            textTelefono.Validated += textTelefono_Validated;
            // 
            // textDireccion
            // 
            textDireccion.BackColor = Color.SeaShell;
            textDireccion.ForeColor = SystemColors.InactiveCaption;
            textDireccion.Location = new Point(52, 353);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(342, 31);
            textDireccion.TabIndex = 3;
            textDireccion.Text = "Ingrese direccion";
            textDireccion.TextAlign = HorizontalAlignment.Center;
            textDireccion.Enter += textDireccion_Enter;
            textDireccion.Validated += textDireccion_Validated;
            // 
            // textMail
            // 
            textMail.BackColor = Color.SeaShell;
            textMail.ForeColor = SystemColors.InactiveCaption;
            textMail.Location = new Point(52, 294);
            textMail.Name = "textMail";
            textMail.Size = new Size(342, 31);
            textMail.TabIndex = 2;
            textMail.Text = "Ingrese correo electronico";
            textMail.TextAlign = HorizontalAlignment.Center;
            textMail.Enter += textMail_Enter;
            textMail.Validated += textMail_Validated;
            // 
            // textApellido
            // 
            textApellido.BackColor = Color.SeaShell;
            textApellido.ForeColor = SystemColors.InactiveCaption;
            textApellido.Location = new Point(52, 183);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(342, 31);
            textApellido.TabIndex = 1;
            textApellido.Text = "Ingrese apellido";
            textApellido.TextAlign = HorizontalAlignment.Center;
            textApellido.Enter += textApellido_Enter;
            textApellido.Validated += textApellido_Validated;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.SeaShell;
            textNombre.ForeColor = SystemColors.InactiveCaption;
            textNombre.Location = new Point(52, 133);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(342, 31);
            textNombre.TabIndex = 12;
            textNombre.Text = "Ingrese nombre";
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.Enter += textNombre_Enter;
            textNombre.Validated += textNombre_Validated;
            // 
            // timerExito
            // 
            timerExito.Interval = 3000;
            timerExito.Tick += timerExito_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(890, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // RegistroAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 799);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegistroAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroAlumno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textTelefono;
        private TextBox textDireccion;
        private TextBox textMail;
        private TextBox textApellido;
        private TextBox textNombre;
        private TextBox textDni;
        private Label label1;
        private DateTimePicker FechaDeNacimiento;
        private CheckBox checkBox1;
        private TextBox textPalabraClave;
        private TextBox textContraseñaP;
        private Button button2;
        private Button button1;
        private Label labelConfirmacion;
        private System.Windows.Forms.Timer timerExito;
        private PictureBox pictureBox1;
    }
}