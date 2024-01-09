namespace FormularioRegistro
{
    partial class FormAltaProyecto
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
            this.descripLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaInicialLbl = new System.Windows.Forms.Label();
            this.fechaFinalLbl = new System.Windows.Forms.Label();
            this.presupInicialLbl = new System.Windows.Forms.Label();
            this.codClientLbl = new System.Windows.Forms.Label();
            this.descripTextBox = new System.Windows.Forms.TextBox();
            this.codigoClienteTextBox = new System.Windows.Forms.TextBox();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.borrarDatos = new System.Windows.Forms.Button();
            this.fechaInicioDTPick = new System.Windows.Forms.DateTimePicker();
            this.fechaFinalDTPick = new System.Windows.Forms.DateTimePicker();
            this.presupNumUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.presupNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // descripLbl
            // 
            this.descripLbl.AutoSize = true;
            this.descripLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripLbl.Location = new System.Drawing.Point(52, 48);
            this.descripLbl.Name = "descripLbl";
            this.descripLbl.Size = new System.Drawing.Size(112, 19);
            this.descripLbl.TabIndex = 0;
            this.descripLbl.Text = "* Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 1;
            // 
            // fechaInicialLbl
            // 
            this.fechaInicialLbl.AutoSize = true;
            this.fechaInicialLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicialLbl.Location = new System.Drawing.Point(52, 101);
            this.fechaInicialLbl.Name = "fechaInicialLbl";
            this.fechaInicialLbl.Size = new System.Drawing.Size(116, 19);
            this.fechaInicialLbl.TabIndex = 2;
            this.fechaInicialLbl.Text = "* Fecha Inicial:";
            // 
            // fechaFinalLbl
            // 
            this.fechaFinalLbl.AutoSize = true;
            this.fechaFinalLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinalLbl.Location = new System.Drawing.Point(52, 152);
            this.fechaFinalLbl.Name = "fechaFinalLbl";
            this.fechaFinalLbl.Size = new System.Drawing.Size(107, 19);
            this.fechaFinalLbl.TabIndex = 3;
            this.fechaFinalLbl.Text = "* Fecha Final:";
            // 
            // presupInicialLbl
            // 
            this.presupInicialLbl.AutoSize = true;
            this.presupInicialLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presupInicialLbl.Location = new System.Drawing.Point(52, 203);
            this.presupInicialLbl.Name = "presupInicialLbl";
            this.presupInicialLbl.Size = new System.Drawing.Size(166, 19);
            this.presupInicialLbl.TabIndex = 5;
            this.presupInicialLbl.Text = "* Presupuesto Inicial:";
            // 
            // codClientLbl
            // 
            this.codClientLbl.AutoSize = true;
            this.codClientLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codClientLbl.Location = new System.Drawing.Point(52, 259);
            this.codClientLbl.Name = "codClientLbl";
            this.codClientLbl.Size = new System.Drawing.Size(132, 19);
            this.codClientLbl.TabIndex = 7;
            this.codClientLbl.Text = "* Código cliente:";
            // 
            // descripTextBox
            // 
            this.descripTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descripTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.descripTextBox.Location = new System.Drawing.Point(260, 46);
            this.descripTextBox.Name = "descripTextBox";
            this.descripTextBox.Size = new System.Drawing.Size(444, 20);
            this.descripTextBox.TabIndex = 8;
            // 
            // codigoClienteTextBox
            // 
            this.codigoClienteTextBox.Location = new System.Drawing.Point(260, 260);
            this.codigoClienteTextBox.Name = "codigoClienteTextBox";
            this.codigoClienteTextBox.Size = new System.Drawing.Size(149, 20);
            this.codigoClienteTextBox.TabIndex = 13;
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Location = new System.Drawing.Point(260, 337);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(84, 33);
            this.confirmarBoton.TabIndex = 14;
            this.confirmarBoton.Text = "CONFIRMAR";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // borrarDatos
            // 
            this.borrarDatos.Location = new System.Drawing.Point(416, 337);
            this.borrarDatos.Name = "borrarDatos";
            this.borrarDatos.Size = new System.Drawing.Size(84, 33);
            this.borrarDatos.TabIndex = 15;
            this.borrarDatos.Text = "BORRAR";
            this.borrarDatos.UseVisualStyleBackColor = true;
            this.borrarDatos.Click += new System.EventHandler(this.borrarDatos_Click);
            // 
            // fechaInicioDTPick
            // 
            this.fechaInicioDTPick.Location = new System.Drawing.Point(260, 99);
            this.fechaInicioDTPick.Name = "fechaInicioDTPick";
            this.fechaInicioDTPick.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioDTPick.TabIndex = 16;
            // 
            // fechaFinalDTPick
            // 
            this.fechaFinalDTPick.Location = new System.Drawing.Point(260, 150);
            this.fechaFinalDTPick.Name = "fechaFinalDTPick";
            this.fechaFinalDTPick.Size = new System.Drawing.Size(200, 20);
            this.fechaFinalDTPick.TabIndex = 17;
            // 
            // presupNumUD
            // 
            this.presupNumUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.presupNumUD.Location = new System.Drawing.Point(260, 202);
            this.presupNumUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.presupNumUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.presupNumUD.Name = "presupNumUD";
            this.presupNumUD.Size = new System.Drawing.Size(120, 20);
            this.presupNumUD.TabIndex = 18;
            this.presupNumUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // FormAltaProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.presupNumUD);
            this.Controls.Add(this.fechaFinalDTPick);
            this.Controls.Add(this.fechaInicioDTPick);
            this.Controls.Add(this.borrarDatos);
            this.Controls.Add(this.confirmarBoton);
            this.Controls.Add(this.codigoClienteTextBox);
            this.Controls.Add(this.descripTextBox);
            this.Controls.Add(this.codClientLbl);
            this.Controls.Add(this.presupInicialLbl);
            this.Controls.Add(this.fechaFinalLbl);
            this.Controls.Add(this.fechaInicialLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripLbl);
            this.Name = "FormAltaProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto nuevo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formularioAltaProyecto_FormClosing);
            this.Load += new System.EventHandler(this.FormAltaProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presupNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descripLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechaInicialLbl;
        private System.Windows.Forms.Label fechaFinalLbl;
        private System.Windows.Forms.Label presupInicialLbl;
        private System.Windows.Forms.Label codClientLbl;
        private System.Windows.Forms.TextBox descripTextBox;
        private System.Windows.Forms.TextBox codigoClienteTextBox;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.Button borrarDatos;
        private System.Windows.Forms.DateTimePicker fechaInicioDTPick;
        private System.Windows.Forms.DateTimePicker fechaFinalDTPick;
        private System.Windows.Forms.NumericUpDown presupNumUD;
    }
}