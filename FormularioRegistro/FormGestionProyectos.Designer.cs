namespace FormularioRegistro
{
    partial class formularioListado
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
            this.label1 = new System.Windows.Forms.Label();
            this.imprimirBot = new System.Windows.Forms.Button();
            this.ordenarBot = new System.Windows.Forms.Button();
            this.cancelBot = new System.Windows.Forms.Button();
            this.eliminarBoton = new System.Windows.Forms.Button();
            this.groupBoxProyectos = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE PROYECTOS";
            // 
            // imprimirBot
            // 
            this.imprimirBot.Location = new System.Drawing.Point(128, 314);
            this.imprimirBot.Name = "imprimirBot";
            this.imprimirBot.Size = new System.Drawing.Size(90, 30);
            this.imprimirBot.TabIndex = 1;
            this.imprimirBot.Text = "IMPRIMIR";
            this.imprimirBot.UseVisualStyleBackColor = true;
            this.imprimirBot.Click += new System.EventHandler(this.imprimirBot_Click);
            // 
            // ordenarBot
            // 
            this.ordenarBot.Location = new System.Drawing.Point(327, 314);
            this.ordenarBot.Name = "ordenarBot";
            this.ordenarBot.Size = new System.Drawing.Size(90, 30);
            this.ordenarBot.TabIndex = 2;
            this.ordenarBot.Text = "ORDENAR";
            this.ordenarBot.UseVisualStyleBackColor = true;
            this.ordenarBot.Click += new System.EventHandler(this.ordenarBot_Click);
            // 
            // cancelBot
            // 
            this.cancelBot.Location = new System.Drawing.Point(536, 314);
            this.cancelBot.Name = "cancelBot";
            this.cancelBot.Size = new System.Drawing.Size(90, 30);
            this.cancelBot.TabIndex = 3;
            this.cancelBot.Text = "CANCELAR";
            this.cancelBot.UseVisualStyleBackColor = true;
            // 
            // eliminarBoton
            // 
            this.eliminarBoton.Location = new System.Drawing.Point(327, 376);
            this.eliminarBoton.Name = "eliminarBoton";
            this.eliminarBoton.Size = new System.Drawing.Size(90, 30);
            this.eliminarBoton.TabIndex = 5;
            this.eliminarBoton.Text = "ELIMINAR";
            this.eliminarBoton.UseVisualStyleBackColor = true;
            this.eliminarBoton.Click += new System.EventHandler(this.eliminarBoton_Click);
            // 
            // groupBoxProyectos
            // 
            this.groupBoxProyectos.BackColor = System.Drawing.Color.Red;
            this.groupBoxProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxProyectos.Location = new System.Drawing.Point(56, 62);
            this.groupBoxProyectos.Name = "groupBoxProyectos";
            this.groupBoxProyectos.Size = new System.Drawing.Size(694, 246);
            this.groupBoxProyectos.TabIndex = 6;
            this.groupBoxProyectos.TabStop = false;
            this.groupBoxProyectos.Text = "PROYECTOS";
            // 
            // formularioListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxProyectos);
            this.Controls.Add(this.eliminarBoton);
            this.Controls.Add(this.cancelBot);
            this.Controls.Add(this.ordenarBot);
            this.Controls.Add(this.imprimirBot);
            this.Controls.Add(this.label1);
            this.Name = "formularioListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Proyectos";
            this.Load += new System.EventHandler(this.formularioListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imprimirBot;
        private System.Windows.Forms.Button ordenarBot;
        private System.Windows.Forms.Button cancelBot;
        private System.Windows.Forms.Button eliminarBoton;
        private System.Windows.Forms.GroupBox groupBoxProyectos;
    }

}