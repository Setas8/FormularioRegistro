namespace FormularioRegistro
{
    partial class Form_ListClientesBBDD
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
            this.datGrClientes = new System.Windows.Forms.DataGridView();
            this.sampleDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSet = new FormularioRegistro.SampleDatabaseDataSet();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.cBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sampleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datGrClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // datGrClientes
            // 
            this.datGrClientes.AutoGenerateColumns = false;
            this.datGrClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGrClientes.DataSource = this.sampleDatabaseDataSetBindingSource2;
            this.datGrClientes.Location = new System.Drawing.Point(70, 57);
            this.datGrClientes.Name = "datGrClientes";
            this.datGrClientes.Size = new System.Drawing.Size(519, 233);
            this.datGrClientes.TabIndex = 0;
            // 
            // sampleDatabaseDataSetBindingSource1
            // 
            this.sampleDatabaseDataSetBindingSource1.DataSource = this.sampleDatabaseDataSet;
            this.sampleDatabaseDataSetBindingSource1.Position = 0;
            // 
            // sampleDatabaseDataSet
            // 
            this.sampleDatabaseDataSet.DataSetName = "SampleDatabaseDataSet";
            this.sampleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Location = new System.Drawing.Point(271, 338);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(247, 21);
            this.cBox1.TabIndex = 1;
            // 
            // cBox2
            // 
            this.cBox2.FormattingEnabled = true;
            this.cBox2.Location = new System.Drawing.Point(271, 392);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(247, 21);
            this.cBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // sampleDatabaseDataSetBindingSource
            // 
            this.sampleDatabaseDataSetBindingSource.DataSource = this.sampleDatabaseDataSet;
            this.sampleDatabaseDataSetBindingSource.Position = 0;
            // 
            // sampleDatabaseDataSetBindingSource2
            // 
            this.sampleDatabaseDataSetBindingSource2.DataSource = this.sampleDatabaseDataSet;
            this.sampleDatabaseDataSetBindingSource2.Position = 0;
            // 
            // Form_ListClientesBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox2);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.datGrClientes);
            this.Name = "Form_ListClientesBBDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de clientes con BBDD";
            ((System.ComponentModel.ISupportInitialize)(this.datGrClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datGrClientes;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.ComboBox cBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSetBindingSource;
        private SampleDatabaseDataSet sampleDatabaseDataSet;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSetBindingSource1;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSetBindingSource2;
    }
}