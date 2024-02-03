namespace FormularioRegistro.MDI
{
    partial class FormOrigen
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
            this.buttonAbrirDestino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbrirDestino
            // 
            this.buttonAbrirDestino.Location = new System.Drawing.Point(363, 214);
            this.buttonAbrirDestino.Name = "buttonAbrirDestino";
            this.buttonAbrirDestino.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrirDestino.TabIndex = 1;
            this.buttonAbrirDestino.Text = "Abrir Destino";
            this.buttonAbrirDestino.UseVisualStyleBackColor = true;
            this.buttonAbrirDestino.Click += new System.EventHandler(this.buttonAbrirDestino_Click);
            // 
            // FormOrigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbrirDestino);
            this.Name = "FormOrigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario origen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrirDestino;
    }
}