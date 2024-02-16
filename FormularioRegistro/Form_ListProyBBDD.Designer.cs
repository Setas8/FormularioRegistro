namespace FormularioRegistro
{
    partial class Form_ListProyBBDDcodigo
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
            this.datGrProyectos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datGrProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // datGrProyectos
            // 
            this.datGrProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGrProyectos.Location = new System.Drawing.Point(30, 34);
            this.datGrProyectos.Name = "datGrProyectos";
            this.datGrProyectos.Size = new System.Drawing.Size(740, 369);
            this.datGrProyectos.TabIndex = 0;
            // 
            // Form_ListProyBBDDcodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datGrProyectos);
            this.Name = "Form_ListProyBBDDcodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de proyectos con BBDD con código";
            this.Load += new System.EventHandler(this.Form_ListProyBBDDcodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGrProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datGrProyectos;
    }
}