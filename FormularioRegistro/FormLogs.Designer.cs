namespace FormularioRegistro
{
    partial class FormLogs
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
            this.treeVLogs = new System.Windows.Forms.TreeView();
            this.richTBLogs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeVLogs
            // 
            this.treeVLogs.Location = new System.Drawing.Point(437, 60);
            this.treeVLogs.Name = "treeVLogs";
            this.treeVLogs.Size = new System.Drawing.Size(274, 313);
            this.treeVLogs.TabIndex = 0;
            this.treeVLogs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // richTBLogs
            // 
            this.richTBLogs.Location = new System.Drawing.Point(52, 60);
            this.richTBLogs.Name = "richTBLogs";
            this.richTBLogs.Size = new System.Drawing.Size(286, 313);
            this.richTBLogs.TabIndex = 1;
            this.richTBLogs.Text = "";
            // 
            // FormLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTBLogs);
            this.Controls.Add(this.treeVLogs);
            this.Name = "FormLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeVLogs;
        private System.Windows.Forms.RichTextBox richTBLogs;
    }
}