namespace FormularioRegistro
{
    partial class FormComponentesProyectos
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
            this.btnAddEmple = new System.Windows.Forms.Button();
            this.btnEliminarEmple = new System.Windows.Forms.Button();
            this.cmBxProyectos = new System.Windows.Forms.ComboBox();
            this.liBxEmpleados = new System.Windows.Forms.ListBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblTxNom = new System.Windows.Forms.Label();
            this.lblTxDNI = new System.Windows.Forms.Label();
            this.lblTxAp = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.lblDedicacion = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblIdEmp = new System.Windows.Forms.Label();
            this.lblCodPro = new System.Windows.Forms.Label();
            this.lblCompo = new System.Windows.Forms.Label();
            this.tBCodPro = new System.Windows.Forms.TextBox();
            this.tBIdEmp = new System.Windows.Forms.TextBox();
            this.puestoComBox = new System.Windows.Forms.ComboBox();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.btnAddCompo = new System.Windows.Forms.Button();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.btnResetCompo = new System.Windows.Forms.Button();
            this.tBDedica = new System.Windows.Forms.TextBox();
            this.tBExtras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddEmple
            // 
            this.btnAddEmple.Location = new System.Drawing.Point(40, 87);
            this.btnAddEmple.Name = "btnAddEmple";
            this.btnAddEmple.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmple.TabIndex = 0;
            this.btnAddEmple.Text = "AÑADIR";
            this.btnAddEmple.UseVisualStyleBackColor = true;
            this.btnAddEmple.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminarEmple
            // 
            this.btnEliminarEmple.Location = new System.Drawing.Point(40, 130);
            this.btnEliminarEmple.Name = "btnEliminarEmple";
            this.btnEliminarEmple.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEmple.TabIndex = 1;
            this.btnEliminarEmple.Text = "ELIMINAR";
            this.btnEliminarEmple.UseVisualStyleBackColor = true;
            this.btnEliminarEmple.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmBxProyectos
            // 
            this.cmBxProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxProyectos.FormattingEnabled = true;
            this.cmBxProyectos.Location = new System.Drawing.Point(151, 314);
            this.cmBxProyectos.Name = "cmBxProyectos";
            this.cmBxProyectos.Size = new System.Drawing.Size(365, 21);
            this.cmBxProyectos.TabIndex = 2;
            // 
            // liBxEmpleados
            // 
            this.liBxEmpleados.FormattingEnabled = true;
            this.liBxEmpleados.Location = new System.Drawing.Point(151, 34);
            this.liBxEmpleados.Name = "liBxEmpleados";
            this.liBxEmpleados.Size = new System.Drawing.Size(284, 264);
            this.liBxEmpleados.TabIndex = 1;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(29, 322);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(86, 13);
            this.lblProyecto.TabIndex = 4;
            this.lblProyecto.Text = "PROYECTOS:";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(29, 34);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(86, 13);
            this.lblEmpleados.TabIndex = 5;
            this.lblEmpleados.Text = "EMPLEADOS:";
            // 
            // lblTxNom
            // 
            this.lblTxNom.AutoSize = true;
            this.lblTxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxNom.Location = new System.Drawing.Point(159, 15);
            this.lblTxNom.Name = "lblTxNom";
            this.lblTxNom.Size = new System.Drawing.Size(60, 13);
            this.lblTxNom.TabIndex = 6;
            this.lblTxNom.Text = "NOMBRE";
            // 
            // lblTxDNI
            // 
            this.lblTxDNI.AutoSize = true;
            this.lblTxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxDNI.Location = new System.Drawing.Point(362, 15);
            this.lblTxDNI.Name = "lblTxDNI";
            this.lblTxDNI.Size = new System.Drawing.Size(29, 13);
            this.lblTxDNI.TabIndex = 7;
            this.lblTxDNI.Text = "DNI";
            // 
            // lblTxAp
            // 
            this.lblTxAp.AutoSize = true;
            this.lblTxAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxAp.Location = new System.Drawing.Point(255, 15);
            this.lblTxAp.Name = "lblTxAp";
            this.lblTxAp.Size = new System.Drawing.Size(67, 13);
            this.lblTxAp.TabIndex = 8;
            this.lblTxAp.Text = "APELLIDO";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(589, 238);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(46, 13);
            this.lblExtras.TabIndex = 9;
            this.lblExtras.Text = "Extras:";
            // 
            // lblDedicacion
            // 
            this.lblDedicacion.AutoSize = true;
            this.lblDedicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDedicacion.Location = new System.Drawing.Point(589, 197);
            this.lblDedicacion.Name = "lblDedicacion";
            this.lblDedicacion.Size = new System.Drawing.Size(88, 13);
            this.lblDedicacion.TabIndex = 10;
            this.lblDedicacion.Text = "Dedicación %:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(589, 156);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(50, 13);
            this.lblPuesto.TabIndex = 11;
            this.lblPuesto.Text = "Puesto:";
            // 
            // lblIdEmp
            // 
            this.lblIdEmp.AutoSize = true;
            this.lblIdEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmp.Location = new System.Drawing.Point(589, 107);
            this.lblIdEmp.Name = "lblIdEmp";
            this.lblIdEmp.Size = new System.Drawing.Size(85, 13);
            this.lblIdEmp.TabIndex = 12;
            this.lblIdEmp.Text = "Id. Empelado:";
            // 
            // lblCodPro
            // 
            this.lblCodPro.AutoSize = true;
            this.lblCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPro.Location = new System.Drawing.Point(589, 62);
            this.lblCodPro.Name = "lblCodPro";
            this.lblCodPro.Size = new System.Drawing.Size(91, 13);
            this.lblCodPro.TabIndex = 13;
            this.lblCodPro.Text = "Cod. Proyecto:";
            // 
            // lblCompo
            // 
            this.lblCompo.AutoSize = true;
            this.lblCompo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompo.Location = new System.Drawing.Point(732, 15);
            this.lblCompo.Name = "lblCompo";
            this.lblCompo.Size = new System.Drawing.Size(93, 13);
            this.lblCompo.TabIndex = 14;
            this.lblCompo.Text = "COMPONENTE";
            // 
            // tBCodPro
            // 
            this.tBCodPro.Enabled = false;
            this.tBCodPro.Location = new System.Drawing.Point(724, 54);
            this.tBCodPro.Name = "tBCodPro";
            this.tBCodPro.Size = new System.Drawing.Size(120, 20);
            this.tBCodPro.TabIndex = 3;
            // 
            // tBIdEmp
            // 
            this.tBIdEmp.Enabled = false;
            this.tBIdEmp.Location = new System.Drawing.Point(724, 100);
            this.tBIdEmp.Name = "tBIdEmp";
            this.tBIdEmp.Size = new System.Drawing.Size(120, 20);
            this.tBIdEmp.TabIndex = 4;
            // 
            // puestoComBox
            // 
            this.puestoComBox.FormattingEnabled = true;
            this.puestoComBox.Items.AddRange(new object[] {
            "Analista",
            "Becario",
            "Contable",
            "Diseñador",
            "Jefe proyecto",
            "Marketing",
            "Programador",
            "Técnico",
            "R.R.H.H.",
            "Ventas"});
            this.puestoComBox.Location = new System.Drawing.Point(724, 148);
            this.puestoComBox.Name = "puestoComBox";
            this.puestoComBox.Size = new System.Drawing.Size(120, 21);
            this.puestoComBox.TabIndex = 5;
            // 
            // btnAddPro
            // 
            this.btnAddPro.Location = new System.Drawing.Point(40, 360);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(75, 23);
            this.btnAddPro.TabIndex = 15;
            this.btnAddPro.Text = "AÑADIR";
            this.btnAddPro.UseVisualStyleBackColor = true;
            // 
            // btnAddCompo
            // 
            this.btnAddCompo.Location = new System.Drawing.Point(704, 312);
            this.btnAddCompo.Name = "btnAddCompo";
            this.btnAddCompo.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompo.TabIndex = 16;
            this.btnAddCompo.Text = "AÑADIR";
            this.btnAddCompo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Location = new System.Drawing.Point(40, 400);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPro.TabIndex = 17;
            this.btnEliminarPro.Text = "ELIMINAR";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            // 
            // btnResetCompo
            // 
            this.btnResetCompo.Location = new System.Drawing.Point(807, 312);
            this.btnResetCompo.Name = "btnResetCompo";
            this.btnResetCompo.Size = new System.Drawing.Size(75, 23);
            this.btnResetCompo.TabIndex = 18;
            this.btnResetCompo.Text = "BORRAR";
            this.btnResetCompo.UseVisualStyleBackColor = true;
            // 
            // tBDedica
            // 
            this.tBDedica.Location = new System.Drawing.Point(724, 190);
            this.tBDedica.Name = "tBDedica";
            this.tBDedica.Size = new System.Drawing.Size(120, 20);
            this.tBDedica.TabIndex = 19;
            // 
            // tBExtras
            // 
            this.tBExtras.Location = new System.Drawing.Point(724, 231);
            this.tBExtras.Name = "tBExtras";
            this.tBExtras.Size = new System.Drawing.Size(120, 20);
            this.tBExtras.TabIndex = 20;
            // 
            // FormComponentesProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 521);
            this.Controls.Add(this.tBExtras);
            this.Controls.Add(this.tBDedica);
            this.Controls.Add(this.btnResetCompo);
            this.Controls.Add(this.btnEliminarPro);
            this.Controls.Add(this.btnAddCompo);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.puestoComBox);
            this.Controls.Add(this.tBIdEmp);
            this.Controls.Add(this.tBCodPro);
            this.Controls.Add(this.lblCompo);
            this.Controls.Add(this.lblCodPro);
            this.Controls.Add(this.lblIdEmp);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblDedicacion);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.lblTxAp);
            this.Controls.Add(this.lblTxDNI);
            this.Controls.Add(this.lblTxNom);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.liBxEmpleados);
            this.Controls.Add(this.cmBxProyectos);
            this.Controls.Add(this.btnEliminarEmple);
            this.Controls.Add(this.btnAddEmple);
            this.Name = "FormComponentesProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes de proyectos";
            this.Load += new System.EventHandler(this.FormComponentesProyectos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmple;
        private System.Windows.Forms.Button btnEliminarEmple;
        private System.Windows.Forms.ComboBox cmBxProyectos;
        private System.Windows.Forms.ListBox liBxEmpleados;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblTxNom;
        private System.Windows.Forms.Label lblTxDNI;
        private System.Windows.Forms.Label lblTxAp;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Label lblDedicacion;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblIdEmp;
        private System.Windows.Forms.Label lblCodPro;
        private System.Windows.Forms.Label lblCompo;
        private System.Windows.Forms.TextBox tBCodPro;
        private System.Windows.Forms.TextBox tBIdEmp;
        private System.Windows.Forms.ComboBox puestoComBox;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.Button btnAddCompo;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.Button btnResetCompo;
        private System.Windows.Forms.TextBox tBDedica;
        private System.Windows.Forms.TextBox tBExtras;
    }
}