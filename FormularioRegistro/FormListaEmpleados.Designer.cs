namespace FormularioRegistro
{
    partial class FormListaEmpleados
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
            this.listBoxEmpleados = new System.Windows.Forms.ListBox();
            this.nombreRBtn = new System.Windows.Forms.RadioButton();
            this.dniRBtn = new System.Windows.Forms.RadioButton();
            this.fechaNacRBtn = new System.Windows.Forms.RadioButton();
            this.jefesRBtn = new System.Windows.Forms.RadioButton();
            this.progRBtn = new System.Windows.Forms.RadioButton();
            this.jovenesRBtn = new System.Windows.Forms.RadioButton();
            this.ordenLbl = new System.Windows.Forms.Label();
            this.filtrarLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEmpleados
            // 
            this.listBoxEmpleados.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxEmpleados.FormattingEnabled = true;
            this.listBoxEmpleados.Location = new System.Drawing.Point(12, 32);
            this.listBoxEmpleados.Name = "listBoxEmpleados";
            this.listBoxEmpleados.Size = new System.Drawing.Size(776, 316);
            this.listBoxEmpleados.TabIndex = 0;
            // 
            // nombreRBtn
            // 
            this.nombreRBtn.AutoSize = true;
            this.nombreRBtn.Location = new System.Drawing.Point(234, 363);
            this.nombreRBtn.Name = "nombreRBtn";
            this.nombreRBtn.Size = new System.Drawing.Size(62, 17);
            this.nombreRBtn.TabIndex = 3;
            this.nombreRBtn.TabStop = true;
            this.nombreRBtn.Text = "Nombre";
            this.nombreRBtn.UseVisualStyleBackColor = true;
            this.nombreRBtn.CheckedChanged += new System.EventHandler(this.ordenarNomt_Check);
            // 
            // dniRBtn
            // 
            this.dniRBtn.AutoSize = true;
            this.dniRBtn.Location = new System.Drawing.Point(234, 410);
            this.dniRBtn.Name = "dniRBtn";
            this.dniRBtn.Size = new System.Drawing.Size(44, 17);
            this.dniRBtn.TabIndex = 4;
            this.dniRBtn.TabStop = true;
            this.dniRBtn.Text = "DNI";
            this.dniRBtn.UseVisualStyleBackColor = true;
            this.dniRBtn.CheckedChanged += new System.EventHandler(this.ordenarDni_Check);
            // 
            // fechaNacRBtn
            // 
            this.fechaNacRBtn.AutoSize = true;
            this.fechaNacRBtn.Location = new System.Drawing.Point(234, 386);
            this.fechaNacRBtn.Name = "fechaNacRBtn";
            this.fechaNacRBtn.Size = new System.Drawing.Size(124, 17);
            this.fechaNacRBtn.TabIndex = 5;
            this.fechaNacRBtn.TabStop = true;
            this.fechaNacRBtn.Text = "Fecha de nacimiento";
            this.fechaNacRBtn.UseVisualStyleBackColor = true;
            this.fechaNacRBtn.CheckedChanged += new System.EventHandler(this.ordenarFechaNacimiento_Check);
            // 
            // jefesRBtn
            // 
            this.jefesRBtn.AutoSize = true;
            this.jefesRBtn.Location = new System.Drawing.Point(631, 363);
            this.jefesRBtn.Name = "jefesRBtn";
            this.jefesRBtn.Size = new System.Drawing.Size(50, 17);
            this.jefesRBtn.TabIndex = 6;
            this.jefesRBtn.TabStop = true;
            this.jefesRBtn.Text = "Jefes";
            this.jefesRBtn.UseVisualStyleBackColor = true;
            this.jefesRBtn.CheckedChanged += new System.EventHandler(this.filtrarJefe_Check);
            // 
            // progRBtn
            // 
            this.progRBtn.AutoSize = true;
            this.progRBtn.Location = new System.Drawing.Point(631, 392);
            this.progRBtn.Name = "progRBtn";
            this.progRBtn.Size = new System.Drawing.Size(96, 17);
            this.progRBtn.TabIndex = 7;
            this.progRBtn.TabStop = true;
            this.progRBtn.Text = "Programadores";
            this.progRBtn.UseVisualStyleBackColor = true;
            this.progRBtn.CheckedChanged += new System.EventHandler(this.filtrarProgramadores_Check);
            // 
            // jovenesRBtn
            // 
            this.jovenesRBtn.AutoSize = true;
            this.jovenesRBtn.Location = new System.Drawing.Point(631, 421);
            this.jovenesRBtn.Name = "jovenesRBtn";
            this.jovenesRBtn.Size = new System.Drawing.Size(78, 17);
            this.jovenesRBtn.TabIndex = 8;
            this.jovenesRBtn.TabStop = true;
            this.jovenesRBtn.Text = "20-30 años";
            this.jovenesRBtn.UseVisualStyleBackColor = true;
            this.jovenesRBtn.CheckedChanged += new System.EventHandler(this.filtrarJovenes_Check);
            // 
            // ordenLbl
            // 
            this.ordenLbl.AutoSize = true;
            this.ordenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenLbl.Location = new System.Drawing.Point(72, 384);
            this.ordenLbl.Name = "ordenLbl";
            this.ordenLbl.Size = new System.Drawing.Size(123, 25);
            this.ordenLbl.TabIndex = 9;
            this.ordenLbl.Text = "ORDENAR";
            // 
            // filtrarLbl
            // 
            this.filtrarLbl.AutoSize = true;
            this.filtrarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarLbl.Location = new System.Drawing.Point(497, 386);
            this.filtrarLbl.Name = "filtrarLbl";
            this.filtrarLbl.Size = new System.Drawing.Size(106, 25);
            this.filtrarLbl.TabIndex = 10;
            this.filtrarLbl.Text = "FILTRAR";
            // 
            // FormListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtrarLbl);
            this.Controls.Add(this.ordenLbl);
            this.Controls.Add(this.jovenesRBtn);
            this.Controls.Add(this.progRBtn);
            this.Controls.Add(this.jefesRBtn);
            this.Controls.Add(this.fechaNacRBtn);
            this.Controls.Add(this.dniRBtn);
            this.Controls.Add(this.nombreRBtn);
            this.Controls.Add(this.listBoxEmpleados);
            this.Name = "FormListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE EMPLEADOS";
            this.Load += new System.EventHandler(this.FormListaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmpleados;
        private System.Windows.Forms.RadioButton nombreRBtn;
        private System.Windows.Forms.RadioButton dniRBtn;
        private System.Windows.Forms.RadioButton fechaNacRBtn;
        private System.Windows.Forms.RadioButton jefesRBtn;
        private System.Windows.Forms.RadioButton progRBtn;
        private System.Windows.Forms.RadioButton jovenesRBtn;
        private System.Windows.Forms.Label ordenLbl;
        private System.Windows.Forms.Label filtrarLbl;
    }
}