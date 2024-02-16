using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormularioRegistro
{
    public partial class Form_modificarClientes : Form
    {
        public Form_modificarClientes()
        {
            InitializeComponent();

            tbWeb.Enter += tbWeb_Enter;

            tbWeb.Leave += tbWeb_Leave;

            tbWeb_Leave(null, null);
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            webBrow.Navigate(tbWeb.Text);
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            webBrow.GoBack();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            webBrow.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrow.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrow.GoHome();
        }
        
           
        private void tbWeb_Enter(object sender, EventArgs e)
        {
            // Elimina el marcador de posición cuando el TextBox recibe el foco
            if (tbWeb.Text == "https://www.monos.com/")
            {
                tbWeb.Text = "";
                tbWeb.ForeColor = System.Drawing.SystemColors.WindowText; 
            }
        }

        private void tbWeb_Leave(object sender, EventArgs e)
        {
            // Establece el marcador de posición si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(tbWeb.Text))
            {
                tbWeb.Text = "https://www.monos.com";
                tbWeb.ForeColor = System.Drawing.SystemColors.GrayText; 
            }
        }
   
    }
}
