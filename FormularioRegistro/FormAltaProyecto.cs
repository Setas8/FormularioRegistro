using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormularioRegistro
{
    public partial class FormAltaProyecto : Form
    {
        public FormAltaProyecto()
        {
            InitializeComponent();

        }

        private void borrarDatos_Click(object sender, EventArgs e)
        {
            descripTextBox.Clear();
            fechaInicioDTPick.ResetText();                           
            fechaFinalDTPick.ResetText();
            presupNumUD.Value = 1000;    
            codigoClienteTextBox.Clear();
            codigoClienteTextBox.BackColor = Color.White;
            descripTextBox.BackColor = Color.White;

        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {


            bool crear = false;
            int codigoCliente = 0;
            int i;//Comprobar si valor de string se puede parsear

            if (string.IsNullOrWhiteSpace(descripTextBox.Text)) 
            {
                descripTextBox.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(codigoClienteTextBox.Text))
            {
                codigoClienteTextBox.BackColor = Color.Red;
            }
            else if (presupNumUD.Text == null)
            {
                presupNumUD.BackColor = Color.Red;
            }
            else if (!int.TryParse(codigoClienteTextBox.Text, out i))
            {
                codigoClienteTextBox.BackColor = Color.Red;
                MessageBox.Show("El código del cliente debe ser un número");
            }
            else
            {
                codigoClienteTextBox.BackColor = Color.White;
                descripTextBox.BackColor       = Color.White;
                presupNumUD.BackColor          = Color.White;
                codigoCliente = int.Parse(codigoClienteTextBox.Text.ToString());
                crear = true;
            }
            
            
            if (crear)
            {
                
                Proyecto p = new Proyecto(descripTextBox.Text, Convert.ToDateTime(fechaInicioDTPick.Value),
                                         Convert.ToDateTime(fechaFinalDTPick.Value), int.Parse(presupNumUD.Value.ToString()),
                                         int.Parse(presupNumUD.Value.ToString()), false,
                                         codigoCliente, estado.INICIO);


                ControladorProyectos.listaProyectos.Add(p);
                descripTextBox.Clear();
                fechaInicioDTPick.ResetText();
                fechaFinalDTPick.ResetText();
                presupNumUD.ResetText();
                codigoClienteTextBox.Clear();
                MessageBox.Show("Proyecto creado con éxito");
            }           
        }
        private void formularioAltaProyecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Quieres guardar los nuevos proyectos?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                ControladorProyectos.escribirProyectosJSON();
            }
        }

        private void FormAltaProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
