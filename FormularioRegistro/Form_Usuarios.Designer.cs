namespace FormularioRegistro
{
    partial class Form_Usuarios
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPswd = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tBxPswd = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.btnSelec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.comBxUsers = new System.Windows.Forms.ComboBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(47, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Nuevo usuario: ";
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Location = new System.Drawing.Point(47, 137);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(71, 13);
            this.lblPswd.TabIndex = 1;
            this.lblPswd.Text = "Nueva clave:";
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(164, 80);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(100, 20);
            this.tbxUser.TabIndex = 2;
            // 
            // tBxPswd
            // 
            this.tBxPswd.Location = new System.Drawing.Point(164, 130);
            this.tBxPswd.Name = "tBxPswd";
            this.tBxPswd.PasswordChar = '*';
            this.tBxPswd.Size = new System.Drawing.Size(100, 20);
            this.tBxPswd.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(164, 195);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "INSERTAR";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // split1
            // 
            this.split1.Location = new System.Drawing.Point(28, 37);
            this.split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.lblUser);
            this.split1.Panel1.Controls.Add(this.btnInsert);
            this.split1.Panel1.Controls.Add(this.lblPswd);
            this.split1.Panel1.Controls.Add(this.tBxPswd);
            this.split1.Panel1.Controls.Add(this.tbxUser);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.Controls.Add(this.btnSelec);
            this.split1.Panel2.Controls.Add(this.button2);
            this.split1.Panel2.Controls.Add(this.dataGridUsers);
            this.split1.Size = new System.Drawing.Size(877, 402);
            this.split1.SplitterDistance = 292;
            this.split1.TabIndex = 5;
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(71, 77);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 5;
            this.btnSelec.Text = "SELECT";
            this.btnSelec.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(191, 20);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(376, 260);
            this.dataGridUsers.TabIndex = 0;
            // 
            // comBxUsers
            // 
            this.comBxUsers.FormattingEnabled = true;
            this.comBxUsers.Location = new System.Drawing.Point(316, 489);
            this.comBxUsers.Name = "comBxUsers";
            this.comBxUsers.Size = new System.Drawing.Size(204, 21);
            this.comBxUsers.TabIndex = 6;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(216, 497);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(51, 13);
            this.lblUsuarios.TabIndex = 7;
            this.lblUsuarios.Text = "Usuarios:";
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 582);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.comBxUsers);
            this.Controls.Add(this.split1);
            this.Name = "Form_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de usuarios";
            this.Load += new System.EventHandler(this.Form_Usuarios_Load);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel1.PerformLayout();
            this.split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tBxPswd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comBxUsers;
        private System.Windows.Forms.Label lblUsuarios;
    }
}