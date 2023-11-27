namespace New_SYSACAD
{
    partial class NotificacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificacionesForm));
            listViewNotificaciones = new ListView();
            tabControlNotificaciones = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            listViewNotificacionesLeidos = new ListView();
            tabControlNotificaciones.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewNotificaciones
            // 
            listViewNotificaciones.BackColor = Color.SeaShell;
            listViewNotificaciones.Location = new Point(12, 15);
            listViewNotificaciones.Name = "listViewNotificaciones";
            listViewNotificaciones.Size = new Size(589, 281);
            listViewNotificaciones.TabIndex = 0;
            listViewNotificaciones.UseCompatibleStateImageBehavior = false;
            listViewNotificaciones.MouseClick += listViewNotificaciones_MouseClick;
            // 
            // tabControlNotificaciones
            // 
            tabControlNotificaciones.Controls.Add(tabPage1);
            tabControlNotificaciones.Controls.Add(tabPage2);
            tabControlNotificaciones.Location = new Point(-4, 2);
            tabControlNotificaciones.Name = "tabControlNotificaciones";
            tabControlNotificaciones.SelectedIndex = 0;
            tabControlNotificaciones.Size = new Size(620, 349);
            tabControlNotificaciones.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewNotificaciones);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(612, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "No Leídas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listViewNotificacionesLeidos);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(612, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Leídas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewNotificacionesLeidos
            // 
            listViewNotificacionesLeidos.BackColor = Color.SeaShell;
            listViewNotificacionesLeidos.Location = new Point(12, 15);
            listViewNotificacionesLeidos.Name = "listViewNotificacionesLeidos";
            listViewNotificacionesLeidos.Size = new Size(589, 281);
            listViewNotificacionesLeidos.TabIndex = 1;
            listViewNotificacionesLeidos.UseCompatibleStateImageBehavior = false;
            // 
            // NotificacionesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(613, 355);
            Controls.Add(tabControlNotificaciones);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NotificacionesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Notificaciones";
            tabControlNotificaciones.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewNotificaciones;
        private TabControl tabControlNotificaciones;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listViewNotificacionesLeidos;
    }
}