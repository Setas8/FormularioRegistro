namespace FormularioRegistro.MDI
{
    partial class OpenForm
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
            this.buttonMostrarFormularios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMostrarFormularios
            // 
            this.buttonMostrarFormularios.Location = new System.Drawing.Point(335, 197);
            this.buttonMostrarFormularios.Name = "buttonMostrarFormularios";
            this.buttonMostrarFormularios.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarFormularios.TabIndex = 0;
            this.buttonMostrarFormularios.Text = "Open Form";
            this.buttonMostrarFormularios.UseVisualStyleBackColor = true;
            this.buttonMostrarFormularios.Click += new System.EventHandler(this.buttonMostrarFormularios_Click);
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMostrarFormularios);
            this.Name = "OpenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularios abiertos";
            this.Load += new System.EventHandler(this.OpenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMostrarFormularios;
    }
}