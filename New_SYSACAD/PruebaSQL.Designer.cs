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
            SuspendLayout();
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(305, 204);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(112, 34);
            buttonCrear.TabIndex = 0;
            buttonCrear.Text = "Crear Tabla";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // PruebaSQL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrear);
            Name = "PruebaSQL";
            Text = "PruebaSQL";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCrear;
    }
}