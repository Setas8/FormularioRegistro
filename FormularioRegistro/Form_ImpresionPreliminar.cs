using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormularioRegistro
{
    public partial class Form_ImpresionPreliminar : Form
    {
        public Form_ImpresionPreliminar()
        {
            InitializeComponent();
            
        }

        private void Form_AcercaDe_Load(object sender, EventArgs e)
        {
            ControladorClientes.escribirBinario();
           
            
           
            document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
            toolStripMenuItem1.Click += new EventHandler(imprimirPreliminarStripMenuItem1_Click);
        }

        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();

        private void imprimirPreliminarStripMenuItem1_Click(object sender,EventArgs e)
        {
            //inicializa el printpreviewdialog
            PrintPreviewDialog1 = new PrintPreviewDialog();
            //Set the size, location, and name.
            PrintPreviewDialog1.ClientSize = new System.Drawing.Size(1000, 800);
            PrintPreviewDialog1.Location = new System.Drawing.Point(40, 40);
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
            PrintPreviewDialog1.Document = document;
            //establece el documento a imprimir
            document.DocumentName = "Previsualización";
                 
            //muestra el printpreviewdialog
            PrintPreviewDialog1.ShowDialog();


            printPreviewControl1.Document = document;

        }

        // En el evento printpage generamos el documento leyendo la lista de alumnos
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printPreviewControl1.Show();        
            float yPos = 0;
            int contador = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Arial", 20);      
            // imprime todos los clientes
            yPos = topMargin + (contador * (font.Size + 4));
            e.Graphics.DrawString("LISTADO DE CLIENTES", font, Brushes.Black, leftMargin, yPos, new StringFormat());
            contador += 2;
            List<Cliente> lista = ControladorClientes.listaClientes;
            
            lista.ForEach(cliente =>
            {
                
                yPos = topMargin + (contador * font.Size);
                e.Graphics.DrawString(cliente.Nombre + " " + cliente.Nif + " " + cliente.Correo, font, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                contador += 3;
            });
            /*
            string datos = "";
            foreach (DataGridViewRow d in dataGridView1.Rows)
            {

                if (!d.IsNewRow)
                {
                    datos = d.Cells[0].Value.ToString() + " " + d.Cells[1].Value.ToString()
                        + " " + d.Cells[2].Value.ToString() + " " + d.Cells[3].Value.ToString();
                    yPos = topMargin + (contador * font.Size);
                    e.Graphics.DrawString(datos, font, Brushes.Black,
                    leftMargin, yPos, new StringFormat());
                    contador += 3;
                }


            }
            */
        }
    }
}
