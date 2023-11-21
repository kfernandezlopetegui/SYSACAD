namespace New_SYSACAD
{
    partial class AgregarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProfesor));
            pictureBox1 = new PictureBox();
            buttonVolver = new Button();
            buttonAgregar = new Button();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textEmail = new TextBox();
            textDni = new TextBox();
            checkedListBoxCursosAsignados = new CheckedListBox();
            textBoxContraseña = new TextBox();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            FechaDeNacimiento = new DateTimePicker();
            label2 = new Label();
            textBoxAreasEspecializacion = new TextBox();
            textBoxPalabraClave = new TextBox();
            textBoxNumeroTel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(885, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.SeaShell;
            buttonVolver.ForeColor = Color.IndianRed;
            buttonVolver.Location = new Point(58, 568);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 34);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.SeaShell;
            buttonAgregar.ForeColor = Color.IndianRed;
            buttonAgregar.Location = new Point(646, 568);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 34);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Snow;
            textNombre.ForeColor = SystemColors.Desktop;
            textNombre.Location = new Point(22, 44);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Ingrese el nombre";
            textNombre.Size = new Size(370, 29);
            textNombre.TabIndex = 2;
            textNombre.TextAlign = HorizontalAlignment.Center;
            textNombre.Validated += textNombre_Validated;
            // 
            // textApellido
            // 
            textApellido.BackColor = Color.Snow;
            textApellido.ForeColor = SystemColors.Desktop;
            textApellido.Location = new Point(414, 44);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Ingrese el Apellido";
            textApellido.Size = new Size(370, 29);
            textApellido.TabIndex = 3;
            textApellido.TextAlign = HorizontalAlignment.Center;
            textApellido.Validated += textApellido_Validated;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.Snow;
            textEmail.ForeColor = SystemColors.Desktop;
            textEmail.Location = new Point(414, 115);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Ingrese el correo electronico";
            textEmail.Size = new Size(374, 29);
            textEmail.TabIndex = 5;
            textEmail.TextAlign = HorizontalAlignment.Center;
            textEmail.Validated += textEmail_Validated;
            // 
            // textDni
            // 
            textDni.BackColor = Color.Snow;
            textDni.ForeColor = SystemColors.Desktop;
            textDni.Location = new Point(18, 114);
            textDni.Multiline = true;
            textDni.Name = "textDni";
            textDni.PlaceholderText = "Ingrese el DNI";
            textDni.Size = new Size(374, 30);
            textDni.TabIndex = 4;
            textDni.TextAlign = HorizontalAlignment.Center;
            textDni.Validated += textDni_Validated;
            // 
            // checkedListBoxCursosAsignados
            // 
            checkedListBoxCursosAsignados.BackColor = Color.Snow;
            checkedListBoxCursosAsignados.FormattingEnabled = true;
            checkedListBoxCursosAsignados.Location = new Point(210, 426);
            checkedListBoxCursosAsignados.Name = "checkedListBoxCursosAsignados";
            checkedListBoxCursosAsignados.Size = new Size(452, 56);
            checkedListBoxCursosAsignados.TabIndex = 17;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.Snow;
            textBoxContraseña.ForeColor = SystemColors.Desktop;
            textBoxContraseña.Location = new Point(18, 186);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PlaceholderText = "Contraseña provisional";
            textBoxContraseña.Size = new Size(374, 29);
            textBoxContraseña.TabIndex = 19;
            textBoxContraseña.TextAlign = HorizontalAlignment.Center;
            textBoxContraseña.Validated += textBoxContraseña_Validated;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.Snow;
            textBoxDireccion.ForeColor = SystemColors.Desktop;
            textBoxDireccion.Location = new Point(414, 186);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.PlaceholderText = "Domicilio";
            textBoxDireccion.Size = new Size(374, 29);
            textBoxDireccion.TabIndex = 20;
            textBoxDireccion.TextAlign = HorizontalAlignment.Center;
            textBoxDireccion.Validated += textBoxDireccion_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 373);
            label4.Name = "label4";
            label4.Size = new Size(0, 22);
            label4.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaDeNacimiento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxAreasEspecializacion);
            groupBox1.Controls.Add(textBoxPalabraClave);
            groupBox1.Controls.Add(textBoxNumeroTel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxDireccion);
            groupBox1.Controls.Add(textBoxContraseña);
            groupBox1.Controls.Add(checkedListBoxCursosAsignados);
            groupBox1.Controls.Add(textDni);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(buttonAgregar);
            groupBox1.Controls.Add(buttonVolver);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RosyBrown;
            groupBox1.Location = new Point(82, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 631);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Profesor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(210, 401);
            label1.Name = "label1";
            label1.Size = new Size(294, 22);
            label1.TabIndex = 27;
            label1.Text = "Seleccione los cursos asignados";
            // 
            // FechaDeNacimiento
            // 
            FechaDeNacimiento.CalendarMonthBackground = Color.SeaShell;
            FechaDeNacimiento.CustomFormat = "dd/MM/yyyy";
            FechaDeNacimiento.Format = DateTimePickerFormat.Custom;
            FechaDeNacimiento.Location = new Point(635, 333);
            FechaDeNacimiento.Name = "FechaDeNacimiento";
            FechaDeNacimiento.Size = new Size(28, 29);
            FechaDeNacimiento.TabIndex = 26;
            FechaDeNacimiento.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            FechaDeNacimiento.Validated += FechaDeNacimiento_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(414, 333);
            label2.Name = "label2";
            label2.Size = new Size(203, 22);
            label2.TabIndex = 25;
            label2.Text = "Fecha de nacimiento:";
            // 
            // textBoxAreasEspecializacion
            // 
            textBoxAreasEspecializacion.BackColor = Color.Snow;
            textBoxAreasEspecializacion.ForeColor = SystemColors.Desktop;
            textBoxAreasEspecializacion.Location = new Point(18, 326);
            textBoxAreasEspecializacion.Name = "textBoxAreasEspecializacion";
            textBoxAreasEspecializacion.PlaceholderText = "Areas de Especializacion";
            textBoxAreasEspecializacion.Size = new Size(374, 29);
            textBoxAreasEspecializacion.TabIndex = 24;
            textBoxAreasEspecializacion.TextAlign = HorizontalAlignment.Center;
            textBoxAreasEspecializacion.Validated += textBoxAreasEspecializacion_Validated;
            // 
            // textBoxPalabraClave
            // 
            textBoxPalabraClave.BackColor = Color.Snow;
            textBoxPalabraClave.ForeColor = SystemColors.Desktop;
            textBoxPalabraClave.Location = new Point(414, 262);
            textBoxPalabraClave.Name = "textBoxPalabraClave";
            textBoxPalabraClave.PlaceholderText = "Palabra clave";
            textBoxPalabraClave.Size = new Size(374, 29);
            textBoxPalabraClave.TabIndex = 23;
            textBoxPalabraClave.TextAlign = HorizontalAlignment.Center;
            textBoxPalabraClave.Validated += textBoxPalabraClave_Validated;
            // 
            // textBoxNumeroTel
            // 
            textBoxNumeroTel.BackColor = Color.Snow;
            textBoxNumeroTel.ForeColor = SystemColors.Desktop;
            textBoxNumeroTel.Location = new Point(18, 262);
            textBoxNumeroTel.Name = "textBoxNumeroTel";
            textBoxNumeroTel.PlaceholderText = "Numero de telefono";
            textBoxNumeroTel.Size = new Size(374, 29);
            textBoxNumeroTel.TabIndex = 22;
            textBoxNumeroTel.TextAlign = HorizontalAlignment.Center;
            textBoxNumeroTel.Validated += textBoxNumeroTel_Validated;
            // 
            // AgregarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 803);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "AgregarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProfesor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button buttonVolver;
        private Button buttonAgregar;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textEmail;
        private TextBox textDni;
        private CheckedListBox checkedListBoxCursosAsignados;
        private TextBox textBoxContraseña;
        private TextBox textBoxDireccion;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBoxNumeroTel;
        private TextBox textBoxPalabraClave;
        private TextBox textBoxAreasEspecializacion;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaDeNacimiento;
    }
}