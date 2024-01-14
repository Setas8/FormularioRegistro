namespace FormularioRegistro
{
    partial class Form_Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuLbl = new System.Windows.Forms.Label();
            this.pswLbl = new System.Windows.Forms.Label();
            this.usuBox = new System.Windows.Forms.TextBox();
            this.pswBox = new System.Windows.Forms.TextBox();
            this.acepBoton = new System.Windows.Forms.Button();
            this.canBoton = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lablWeb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usuLbl
            // 
            this.usuLbl.AutoSize = true;
            this.usuLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuLbl.Location = new System.Drawing.Point(33, 110);
            this.usuLbl.Name = "usuLbl";
            this.usuLbl.Size = new System.Drawing.Size(153, 19);
            this.usuLbl.TabIndex = 0;
            this.usuLbl.Text = "Introduzca usuario";
            // 
            // pswLbl
            // 
            this.pswLbl.AutoSize = true;
            this.pswLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswLbl.Location = new System.Drawing.Point(33, 185);
            this.pswLbl.Name = "pswLbl";
            this.pswLbl.Size = new System.Drawing.Size(194, 19);
            this.pswLbl.TabIndex = 1;
            this.pswLbl.Text = "Introduzca clave acceso";
            // 
            // usuBox
            // 
            this.usuBox.Location = new System.Drawing.Point(329, 109);
            this.usuBox.Name = "usuBox";
            this.usuBox.Size = new System.Drawing.Size(140, 20);
            this.usuBox.TabIndex = 2;
            this.usuBox.Text = "Ej.: Diego";
            // 
            // pswBox
            // 
            this.pswBox.Location = new System.Drawing.Point(329, 186);
            this.pswBox.Name = "pswBox";
            this.pswBox.PasswordChar = '*';
            this.pswBox.Size = new System.Drawing.Size(140, 20);
            this.pswBox.TabIndex = 3;
            // 
            // acepBoton
            // 
            this.acepBoton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acepBoton.Location = new System.Drawing.Point(231, 297);
            this.acepBoton.Name = "acepBoton";
            this.acepBoton.Size = new System.Drawing.Size(120, 50);
            this.acepBoton.TabIndex = 4;
            this.acepBoton.Text = "ACEPTAR";
            this.acepBoton.UseVisualStyleBackColor = true;
            this.acepBoton.Click += new System.EventHandler(this.acepBoton_Click);
            // 
            // canBoton
            // 
            this.canBoton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canBoton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canBoton.Location = new System.Drawing.Point(428, 297);
            this.canBoton.Name = "canBoton";
            this.canBoton.Size = new System.Drawing.Size(120, 50);
            this.canBoton.TabIndex = 5;
            this.canBoton.Text = "CANCELAR";
            this.canBoton.UseVisualStyleBackColor = true;
            this.canBoton.Click += new System.EventHandler(this.canBoton_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(673, 399);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lablWeb
            // 
            this.lablWeb.AutoSize = true;
            this.lablWeb.Location = new System.Drawing.Point(22, 409);
            this.lablWeb.Name = "lablWeb";
            this.lablWeb.Size = new System.Drawing.Size(149, 13);
            this.lablWeb.TabIndex = 7;
            this.lablWeb.TabStop = true;
            this.lablWeb.Text = "www.ies.elcanaveral.mostoles";
            this.lablWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lablWeb_LinkClicked);
            // 
            // Form_Registro
            // 
            this.AcceptButton = this.acepBoton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.canBoton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lablWeb);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.canBoton);
            this.Controls.Add(this.acepBoton);
            this.Controls.Add(this.pswBox);
            this.Controls.Add(this.usuBox);
            this.Controls.Add(this.pswLbl);
            this.Controls.Add(this.usuLbl);
            this.Name = "Form_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al portal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Registro_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuLbl;
        private System.Windows.Forms.Label pswLbl;
        private System.Windows.Forms.TextBox usuBox;
        private System.Windows.Forms.TextBox pswBox;
        private System.Windows.Forms.Button acepBoton;
        private System.Windows.Forms.Button canBoton;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.LinkLabel lablWeb;
    }
}

