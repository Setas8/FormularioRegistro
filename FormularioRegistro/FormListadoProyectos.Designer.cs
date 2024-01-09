namespace FormularioRegistro
{
    partial class FormListadoProyectos
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
            this.proyectoslbl = new System.Windows.Forms.Label();
            this.proyectosGroupBox = new System.Windows.Forms.GroupBox();
            this.ordenarDescBot = new System.Windows.Forms.Button();
            this.ordenarFechaInicioBot = new System.Windows.Forms.Button();
            this.ordenarFechaFinalBot = new System.Windows.Forms.Button();
            this.ordenarPresupuestoInicialBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proyectoslbl
            // 
            this.proyectoslbl.AutoSize = true;
            this.proyectoslbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoslbl.Location = new System.Drawing.Point(293, 45);
            this.proyectoslbl.Name = "proyectoslbl";
            this.proyectoslbl.Size = new System.Drawing.Size(197, 18);
            this.proyectoslbl.TabIndex = 1;
            this.proyectoslbl.Text = "LISTADO DE PROYECTOS";
            // 
            // proyectosGroupBox
            // 
            this.proyectosGroupBox.BackColor = System.Drawing.Color.Red;
            this.proyectosGroupBox.Location = new System.Drawing.Point(52, 80);
            this.proyectosGroupBox.Name = "proyectosGroupBox";
            this.proyectosGroupBox.Size = new System.Drawing.Size(696, 246);
            this.proyectosGroupBox.TabIndex = 5;
            this.proyectosGroupBox.TabStop = false;
            // 
            // ordenarDescBot
            // 
            this.ordenarDescBot.Location = new System.Drawing.Point(52, 332);
            this.ordenarDescBot.Name = "ordenarDescBot";
            this.ordenarDescBot.Size = new System.Drawing.Size(157, 40);
            this.ordenarDescBot.TabIndex = 6;
            this.ordenarDescBot.Text = "ORDENAR POR DESCRIPCIÓN";
            this.ordenarDescBot.UseVisualStyleBackColor = true;
            this.ordenarDescBot.Click += new System.EventHandler(this.ordenarDescBot_Click);
            // 
            // ordenarFechaInicioBot
            // 
            this.ordenarFechaInicioBot.Location = new System.Drawing.Point(230, 332);
            this.ordenarFechaInicioBot.Name = "ordenarFechaInicioBot";
            this.ordenarFechaInicioBot.Size = new System.Drawing.Size(157, 40);
            this.ordenarFechaInicioBot.TabIndex = 7;
            this.ordenarFechaInicioBot.Text = "ORDENAR POR FECHA INICIO";
            this.ordenarFechaInicioBot.UseVisualStyleBackColor = true;
            this.ordenarFechaInicioBot.Click += new System.EventHandler(this.ordenarFechaInicioBot_Click);
            // 
            // ordenarFechaFinalBot
            // 
            this.ordenarFechaFinalBot.Location = new System.Drawing.Point(404, 332);
            this.ordenarFechaFinalBot.Name = "ordenarFechaFinalBot";
            this.ordenarFechaFinalBot.Size = new System.Drawing.Size(157, 40);
            this.ordenarFechaFinalBot.TabIndex = 8;
            this.ordenarFechaFinalBot.Text = "ORDENAR POR FECHA FINAL";
            this.ordenarFechaFinalBot.UseVisualStyleBackColor = true;
            this.ordenarFechaFinalBot.Click += new System.EventHandler(this.ordenarFechaFinalBot_Click);
            // 
            // ordenarPresupuestoInicialBot
            // 
            this.ordenarPresupuestoInicialBot.Location = new System.Drawing.Point(591, 332);
            this.ordenarPresupuestoInicialBot.Name = "ordenarPresupuestoInicialBot";
            this.ordenarPresupuestoInicialBot.Size = new System.Drawing.Size(157, 40);
            this.ordenarPresupuestoInicialBot.TabIndex = 9;
            this.ordenarPresupuestoInicialBot.Text = "ORDENAR POR PRESUPUESTO INICIAL";
            this.ordenarPresupuestoInicialBot.UseVisualStyleBackColor = true;
            this.ordenarPresupuestoInicialBot.Click += new System.EventHandler(this.ordenarPresupuestoInicialBot_Click);
            // 
            // FormularioProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordenarPresupuestoInicialBot);
            this.Controls.Add(this.ordenarFechaFinalBot);
            this.Controls.Add(this.ordenarFechaInicioBot);
            this.Controls.Add(this.ordenarDescBot);
            this.Controls.Add(this.proyectosGroupBox);
            this.Controls.Add(this.proyectoslbl);
            this.Name = "FormularioProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.FormularioProyectos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label proyectoslbl;
        private System.Windows.Forms.GroupBox proyectosGroupBox;
        private System.Windows.Forms.Button ordenarDescBot;
        private System.Windows.Forms.Button ordenarFechaInicioBot;
        private System.Windows.Forms.Button ordenarFechaFinalBot;
        private System.Windows.Forms.Button ordenarPresupuestoInicialBot;
    }
}