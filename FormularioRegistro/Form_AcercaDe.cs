using FormularioRegistro.Controladores;
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
    public partial class Form_AcercaDe : Form
    {
        public Form_AcercaDe()
        {
            InitializeComponent();
        }

        private void Form_AcercaDe_Load(object sender, EventArgs e)
        {
            ControladorClientes.escribirBinario();
            document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
        }

        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();

        private void imprimirPreliminarStripMenuItem1_Click(object sender,EventArgs e)
        {
            //inicializa el printpreviewdialog
            PrintPreviewDialog1 = new PrintPreviewDialog();
            //Set the size, location, and name.
            PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
            //establece el documento a imprimir
            document.DocumentName = "Previsualización";
            PrintPreviewDialog1.Document = document;
            //muestra el printpreviewdialog
            PrintPreviewDialog1.ShowDialog();
        }

        // En el evento printpage generamos el documento leyendo la lista de alumnos
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0;
            int contador = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Arial", 10);
            // imprime todos los clientes
            yPos = topMargin + (contador * (font.Size + 4));
            e.Graphics.DrawString("LISTADO DE CLIENTES", font, Brushes.Black, leftMargin, yPos, new StringFormat());
            contador++;
            List<Cliente> lista = ControladorClientes.listaClientes;
            lista.ForEach(cliente =>
            {
                yPos = topMargin + (contador * font.Size);
                e.Graphics.DrawString(cliente.ToString(), font, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                contador++;
            });
        }
    }
}
