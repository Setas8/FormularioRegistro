namespace FormularioRegistro.MDI
{
    partial class FormDestino
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
            this.textBoxMensaje1 = new System.Windows.Forms.TextBox();
            this.textBoxMensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMensaje1
            // 
            this.textBoxMensaje1.Location = new System.Drawing.Point(207, 168);
            this.textBoxMensaje1.Name = "textBoxMensaje1";
            this.textBoxMensaje1.Size = new System.Drawing.Size(360, 20);
            this.textBoxMensaje1.TabIndex = 0;
            // 
            // textBoxMensaje2
            // 
            this.textBoxMensaje2.Location = new System.Drawing.Point(207, 221);
            this.textBoxMensaje2.Name = "textBoxMensaje2";
            this.textBoxMensaje2.Size = new System.Drawing.Size(360, 20);
            this.textBoxMensaje2.TabIndex = 1;
            // 
            // FormDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMensaje2);
            this.Controls.Add(this.textBoxMensaje1);
            this.Name = "FormDestino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario destino";
            this.Load += new System.EventHandler(this.FormularioDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMensaje1;
        private System.Windows.Forms.TextBox textBoxMensaje2;
    }
}