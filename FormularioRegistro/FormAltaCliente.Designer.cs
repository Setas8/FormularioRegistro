namespace FormularioRegistro
{
    partial class FormAltaCliente
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
            this.components = new System.ComponentModel.Container();
            this.tbControlCliente = new System.Windows.Forms.TabControl();
            this.tPageDatGene = new System.Windows.Forms.TabPage();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbNomRepresen = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbDirecc = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDirecc = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNRepre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tPageDatPriv = new System.Windows.Forms.TabPage();
            this.nUdDescuen = new System.Windows.Forms.NumericUpDown();
            this.tBComent = new System.Windows.Forms.TextBox();
            this.lblComen = new System.Windows.Forms.Label();
            this.lblDescu = new System.Windows.Forms.Label();
            this.gbTipoCli = new System.Windows.Forms.GroupBox();
            this.rbMult = new System.Windows.Forms.RadioButton();
            this.rbPeq = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbGra = new System.Windows.Forms.RadioButton();
            this.tPageSector = new System.Windows.Forms.TabPage();
            this.tPageLogo = new System.Windows.Forms.TabPage();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.tbLogo = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tPageCitas = new System.Windows.Forms.TabPage();
            this.dTPCitas = new System.Windows.Forms.DateTimePicker();
            this.monCalenCitas = new System.Windows.Forms.MonthCalendar();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.OpFDia = new System.Windows.Forms.OpenFileDialog();
            this.masTBNIF = new System.Windows.Forms.MaskedTextBox();
            this.masTBTlf = new System.Windows.Forms.MaskedTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbControlCliente.SuspendLayout();
            this.tPageDatGene.SuspendLayout();
            this.tPageDatPriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdDescuen)).BeginInit();
            this.gbTipoCli.SuspendLayout();
            this.tPageLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tPageCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlCliente
            // 
            this.tbControlCliente.Controls.Add(this.tPageDatGene);
            this.tbControlCliente.Controls.Add(this.tPageDatPriv);
            this.tbControlCliente.Controls.Add(this.tPageSector);
            this.tbControlCliente.Controls.Add(this.tPageLogo);
            this.tbControlCliente.Controls.Add(this.tPageCitas);
            this.tbControlCliente.Location = new System.Drawing.Point(31, 58);
            this.tbControlCliente.Name = "tbControlCliente";
            this.tbControlCliente.SelectedIndex = 0;
            this.tbControlCliente.Size = new System.Drawing.Size(732, 325);
            this.tbControlCliente.TabIndex = 0;
            this.tbControlCliente.Tag = "";
            // 
            // tPageDatGene
            // 
            this.tPageDatGene.Controls.Add(this.masTBTlf);
            this.tPageDatGene.Controls.Add(this.masTBNIF);
            this.tPageDatGene.Controls.Add(this.cbPais);
            this.tPageDatGene.Controls.Add(this.tbCorreo);
            this.tPageDatGene.Controls.Add(this.tbNomRepresen);
            this.tPageDatGene.Controls.Add(this.tbCiudad);
            this.tPageDatGene.Controls.Add(this.tbDirecc);
            this.tPageDatGene.Controls.Add(this.tbNombre);
            this.tPageDatGene.Controls.Add(this.lblPais);
            this.tPageDatGene.Controls.Add(this.lblTelef);
            this.tPageDatGene.Controls.Add(this.lblCIF);
            this.tPageDatGene.Controls.Add(this.lblCorreo);
            this.tPageDatGene.Controls.Add(this.lblDirecc);
            this.tPageDatGene.Controls.Add(this.lblCiudad);
            this.tPageDatGene.Controls.Add(this.lblNRepre);
            this.tPageDatGene.Controls.Add(this.lblNombre);
            this.tPageDatGene.Location = new System.Drawing.Point(4, 22);
            this.tPageDatGene.Name = "tPageDatGene";
            this.tPageDatGene.Padding = new System.Windows.Forms.Padding(3);
            this.tPageDatGene.Size = new System.Drawing.Size(724, 299);
            this.tPageDatGene.TabIndex = 0;
            this.tPageDatGene.Text = "Datos Generales";
            this.tPageDatGene.UseVisualStyleBackColor = true;
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Bélgica",
            "Escocia",
            "España",
            "Inglaterra",
            "Mexico",
            "Países Bajos"});
            this.cbPais.Location = new System.Drawing.Point(566, 155);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 21);
            this.cbPais.Sorted = true;
            this.cbPais.TabIndex = 8;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(194, 229);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(195, 20);
            this.tbCorreo.TabIndex = 5;
            // 
            // tbNomRepresen
            // 
            this.tbNomRepresen.Location = new System.Drawing.Point(194, 176);
            this.tbNomRepresen.Name = "tbNomRepresen";
            this.tbNomRepresen.Size = new System.Drawing.Size(195, 20);
            this.tbNomRepresen.TabIndex = 4;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(194, 136);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(195, 20);
            this.tbCiudad.TabIndex = 3;
            // 
            // tbDirecc
            // 
            this.tbDirecc.Location = new System.Drawing.Point(194, 78);
            this.tbDirecc.Multiline = true;
            this.tbDirecc.Name = "tbDirecc";
            this.tbDirecc.Size = new System.Drawing.Size(195, 37);
            this.tbDirecc.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(194, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(195, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(496, 163);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 23;
            this.lblPais.Text = "País";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Location = new System.Drawing.Point(496, 106);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(49, 13);
            this.lblTelef.TabIndex = 22;
            this.lblTelef.Text = "Teléfono";
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(496, 60);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(24, 13);
            this.lblCIF.TabIndex = 21;
            this.lblCIF.Text = "NIF";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(29, 229);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDirecc
            // 
            this.lblDirecc.AutoSize = true;
            this.lblDirecc.Location = new System.Drawing.Point(27, 85);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(52, 13);
            this.lblDirecc.TabIndex = 19;
            this.lblDirecc.Text = "Dirección";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(27, 143);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 18;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblNRepre
            // 
            this.lblNRepre.AutoSize = true;
            this.lblNRepre.Location = new System.Drawing.Point(27, 183);
            this.lblNRepre.Name = "lblNRepre";
            this.lblNRepre.Size = new System.Drawing.Size(117, 13);
            this.lblNRepre.TabIndex = 17;
            this.lblNRepre.Text = "Nombre Representante";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // tPageDatPriv
            // 
            this.tPageDatPriv.Controls.Add(this.nUdDescuen);
            this.tPageDatPriv.Controls.Add(this.tBComent);
            this.tPageDatPriv.Controls.Add(this.lblComen);
            this.tPageDatPriv.Controls.Add(this.lblDescu);
            this.tPageDatPriv.Controls.Add(this.gbTipoCli);
            this.tPageDatPriv.Location = new System.Drawing.Point(4, 22);
            this.tPageDatPriv.Name = "tPageDatPriv";
            this.tPageDatPriv.Padding = new System.Windows.Forms.Padding(3);
            this.tPageDatPriv.Size = new System.Drawing.Size(724, 299);
            this.tPageDatPriv.TabIndex = 1;
            this.tPageDatPriv.Text = "Datos Privados";
            this.tPageDatPriv.UseVisualStyleBackColor = true;
            // 
            // nUdDescuen
            // 
            this.nUdDescuen.Location = new System.Drawing.Point(135, 164);
            this.nUdDescuen.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUdDescuen.Name = "nUdDescuen";
            this.nUdDescuen.Size = new System.Drawing.Size(120, 20);
            this.nUdDescuen.TabIndex = 5;
            // 
            // tBComent
            // 
            this.tBComent.Location = new System.Drawing.Point(135, 207);
            this.tBComent.Multiline = true;
            this.tBComent.Name = "tBComent";
            this.tBComent.Size = new System.Drawing.Size(511, 78);
            this.tBComent.TabIndex = 6;
            // 
            // lblComen
            // 
            this.lblComen.AutoSize = true;
            this.lblComen.Location = new System.Drawing.Point(43, 207);
            this.lblComen.Name = "lblComen";
            this.lblComen.Size = new System.Drawing.Size(65, 13);
            this.lblComen.TabIndex = 6;
            this.lblComen.Text = "Comentarios";
            // 
            // lblDescu
            // 
            this.lblDescu.AutoSize = true;
            this.lblDescu.Location = new System.Drawing.Point(43, 172);
            this.lblDescu.Name = "lblDescu";
            this.lblDescu.Size = new System.Drawing.Size(59, 13);
            this.lblDescu.TabIndex = 5;
            this.lblDescu.Text = "Descuento";
            // 
            // gbTipoCli
            // 
            this.gbTipoCli.Controls.Add(this.rbMult);
            this.gbTipoCli.Controls.Add(this.rbPeq);
            this.gbTipoCli.Controls.Add(this.rbMed);
            this.gbTipoCli.Controls.Add(this.rbGra);
            this.gbTipoCli.Location = new System.Drawing.Point(46, 30);
            this.gbTipoCli.Name = "gbTipoCli";
            this.gbTipoCli.Size = new System.Drawing.Size(329, 124);
            this.gbTipoCli.TabIndex = 4;
            this.gbTipoCli.TabStop = false;
            this.gbTipoCli.Text = "Tipo de cliente";
            // 
            // rbMult
            // 
            this.rbMult.AutoSize = true;
            this.rbMult.Location = new System.Drawing.Point(148, 81);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(87, 17);
            this.rbMult.TabIndex = 4;
            this.rbMult.TabStop = true;
            this.rbMult.Text = "Multinacional";
            this.rbMult.UseVisualStyleBackColor = true;
            // 
            // rbPeq
            // 
            this.rbPeq.AutoSize = true;
            this.rbPeq.Location = new System.Drawing.Point(16, 38);
            this.rbPeq.Name = "rbPeq";
            this.rbPeq.Size = new System.Drawing.Size(68, 17);
            this.rbPeq.TabIndex = 1;
            this.rbPeq.TabStop = true;
            this.rbPeq.Text = "Pequeña";
            this.rbPeq.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Location = new System.Drawing.Point(16, 81);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(66, 17);
            this.rbMed.TabIndex = 3;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Mediana";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbGra
            // 
            this.rbGra.AutoSize = true;
            this.rbGra.Location = new System.Drawing.Point(148, 38);
            this.rbGra.Name = "rbGra";
            this.rbGra.Size = new System.Drawing.Size(60, 17);
            this.rbGra.TabIndex = 2;
            this.rbGra.TabStop = true;
            this.rbGra.Text = "Grande";
            this.rbGra.UseVisualStyleBackColor = true;
            // 
            // tPageSector
            // 
            this.tPageSector.Location = new System.Drawing.Point(4, 22);
            this.tPageSector.Name = "tPageSector";
            this.tPageSector.Padding = new System.Windows.Forms.Padding(3);
            this.tPageSector.Size = new System.Drawing.Size(724, 299);
            this.tPageSector.TabIndex = 2;
            this.tPageSector.Text = "Sector";
            this.tPageSector.UseVisualStyleBackColor = true;
            // 
            // tPageLogo
            // 
            this.tPageLogo.Controls.Add(this.picBox);
            this.tPageLogo.Controls.Add(this.prgBar);
            this.tPageLogo.Controls.Add(this.btnFileDialog);
            this.tPageLogo.Controls.Add(this.tbLogo);
            this.tPageLogo.Controls.Add(this.lblLogo);
            this.tPageLogo.Location = new System.Drawing.Point(4, 22);
            this.tPageLogo.Name = "tPageLogo";
            this.tPageLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tPageLogo.Size = new System.Drawing.Size(724, 299);
            this.tPageLogo.TabIndex = 3;
            this.tPageLogo.Text = "Logo";
            this.tPageLogo.UseVisualStyleBackColor = true;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(172, 97);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(220, 137);
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(172, 252);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(489, 23);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 4;
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDialog.Location = new System.Drawing.Point(418, 51);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(48, 20);
            this.btnFileDialog.TabIndex = 2;
            this.btnFileDialog.Text = "...";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // tbLogo
            // 
            this.tbLogo.Location = new System.Drawing.Point(172, 51);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.Size = new System.Drawing.Size(220, 20);
            this.tbLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(99, 58);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Logo";
            // 
            // tPageCitas
            // 
            this.tPageCitas.Controls.Add(this.dTPCitas);
            this.tPageCitas.Controls.Add(this.monCalenCitas);
            this.tPageCitas.Location = new System.Drawing.Point(4, 22);
            this.tPageCitas.Name = "tPageCitas";
            this.tPageCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tPageCitas.Size = new System.Drawing.Size(724, 299);
            this.tPageCitas.TabIndex = 4;
            this.tPageCitas.Text = "Citas";
            this.tPageCitas.UseVisualStyleBackColor = true;
            // 
            // dTPCitas
            // 
            this.dTPCitas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dTPCitas.Location = new System.Drawing.Point(245, 44);
            this.dTPCitas.Name = "dTPCitas";
            this.dTPCitas.ShowUpDown = true;
            this.dTPCitas.Size = new System.Drawing.Size(200, 20);
            this.dTPCitas.TabIndex = 1;
            // 
            // monCalenCitas
            // 
            this.monCalenCitas.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monCalenCitas.Location = new System.Drawing.Point(245, 104);
            this.monCalenCitas.Name = "monCalenCitas";
            this.monCalenCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monCalenCitas.TabIndex = 2;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(219, 404);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(464, 404);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "ALTA DE CLIENTE";
            // 
            // OpFDia
            // 
            this.OpFDia.DefaultExt = "jpg";
            this.OpFDia.FileName = "dialogoLogo";
            // 
            // masTBNIF
            // 
            this.masTBNIF.Location = new System.Drawing.Point(566, 53);
            this.masTBNIF.Mask = "L-00000000";
            this.masTBNIF.Name = "masTBNIF";
            this.masTBNIF.Size = new System.Drawing.Size(121, 20);
            this.masTBNIF.TabIndex = 24;
            // 
            // masTBTlf
            // 
            this.masTBTlf.Location = new System.Drawing.Point(566, 99);
            this.masTBTlf.Mask = "(999)000-0000";
            this.masTBTlf.Name = "masTBTlf";
            this.masTBTlf.Size = new System.Drawing.Size(121, 20);
            this.masTBTlf.TabIndex = 25;
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbControlCliente);
            this.Name = "FormAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAltaCliente_FormClosing);
            this.tbControlCliente.ResumeLayout(false);
            this.tPageDatGene.ResumeLayout(false);
            this.tPageDatGene.PerformLayout();
            this.tPageDatPriv.ResumeLayout(false);
            this.tPageDatPriv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdDescuen)).EndInit();
            this.gbTipoCli.ResumeLayout(false);
            this.gbTipoCli.PerformLayout();
            this.tPageLogo.ResumeLayout(false);
            this.tPageLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tPageCitas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlCliente;
        private System.Windows.Forms.TabPage tPageDatGene;
        private System.Windows.Forms.TabPage tPageDatPriv;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tPageSector;
        private System.Windows.Forms.TabPage tPageLogo;
        private System.Windows.Forms.TabPage tPageCitas;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNomRepresen;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbDirecc;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDirecc;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNRepre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbTipoCli;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbPeq;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbGra;
        private System.Windows.Forms.TextBox tBComent;
        private System.Windows.Forms.Label lblComen;
        private System.Windows.Forms.Label lblDescu;
        private System.Windows.Forms.NumericUpDown nUdDescuen;
        private System.Windows.Forms.TextBox tbLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DateTimePicker dTPCitas;
        private System.Windows.Forms.MonthCalendar monCalenCitas;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.OpenFileDialog OpFDia;
        private System.Windows.Forms.MaskedTextBox masTBTlf;
        private System.Windows.Forms.MaskedTextBox masTBNIF;
        private System.Windows.Forms.Timer timer;
    }
}