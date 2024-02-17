using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class FormPrueba : Form
    {
        public FormPrueba()
        {
            InitializeComponent();
        }

        private void FormPrueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sampleDatabaseDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sampleDatabaseDataSet1.Clientes);

        }
    }
}
