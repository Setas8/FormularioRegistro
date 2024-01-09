using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FormularioRegistro.Controladores;

namespace FormularioRegistro
{
    public partial class FormAltaEmpleados : Form
    {
        public FormAltaEmpleados()
        {
            InitializeComponent();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            nombreTB.Clear();
            ape1TB.Clear();
            ape2TB.Clear();
            dniTB.Clear();
            correoTB.Clear();   
            fechaNacDTPicker.ResetText();
            numSSTB.Clear();
            numTelTB.Clear();
            puestoComBox.ResetText();
            comentsTB.Clear();
            
        }
        //mensajes de error
        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            bool crear = false;
            int i;//Comprobar si valor de string se puede parsear

            //Validar nombre
            if (string.IsNullOrWhiteSpace(nombreTB.Text))
            {
                nombreTB.BackColor = Color.Red;
            }
            //Validar apellido1
            else if (string.IsNullOrWhiteSpace(ape1TB.Text))
            {
                ape1TB.BackColor = Color.Red;             
            }
            //Validar dni 
            else if (string.IsNullOrWhiteSpace(dniTB.Text))
            {
                dniTB.BackColor = Color.Red;
            }
            //Falta comprobar último caracter si fuera número
            else if (((dniTB.Text.Length < 8) || (dniTB.Text.Length > 9)))
            {
                dniTB.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, debe tener 8 caracteres");
            }           
            //Validar correo probar evento text change
            else if (string.IsNullOrWhiteSpace(correoTB.Text))
            {
                correoTB.BackColor = Color.Red;
            }
            else if (!new EmailAddressAttribute().IsValid(correoTB.Text))
            {
                correoTB.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, Ej.: loquesea@sea.sea");
            }
            //Validar número SS
            else if (((numSSTB.Text.Length < 9) || (numSSTB.Text.Length > 10)))
            {
                numSSTB.BackColor = Color.Red;
                MessageBox.Show("NºSS no válido, debe tener 9 caracteres");
            }
            else if (!int.TryParse(numSSTB.Text, out i))
            {
                numSSTB.BackColor = Color.Red;
                MessageBox.Show("El NºSS sólo debe tener caracteres numéricos");
            }
            //Validar teléfono           
            else if (!int.TryParse(numTelTB.Text, out i))
            {
                numTelTB.BackColor = Color.Red;
                MessageBox.Show("El teléfono sólo debe tener caracteres numéricos");
            }
            else if (((numTelTB.Text.Length < 9) || (numTelTB.Text.Length > 10)))
            {
                numTelTB.BackColor = Color.Red;
                MessageBox.Show("NºTeléfono no válido, debe tener 9 caracteres");
            }
            else
            {
                nombreTB.BackColor = Color.White;
                ape1TB.BackColor   = Color.White;
                dniTB.BackColor    = Color.White;
                correoTB.BackColor = Color.White;
                numSSTB.BackColor  = Color.White;
                numTelTB.BackColor = Color.White;
                
                crear = true;
            }
            //Validar puesto en caso de enum    

            if (crear)
            {

                Empleado emple = new Empleado(dniTB.Text, nombreTB.Text, ape1TB.Text, ape2TB.Text, puestoComBox.Text,
                                        correoTB.Text, comentsTB.Text, int.Parse(numTelTB.Text), long.Parse(numSSTB.Text),
                                        Convert.ToDateTime(fechaNacDTPicker.Value));
             

                ControladorEmpleados.listaEmpleados.Add(emple);
                nombreTB.Clear();
                ape1TB.Clear();
                ape2TB.Clear();
                dniTB.Clear();
                correoTB.Clear();
                fechaNacDTPicker.ResetText();
                numSSTB.Clear();
                numTelTB.Clear();
                puestoComBox.ResetText();
                comentsTB.Clear();
                MessageBox.Show("Empleado creado con éxito");
                if (emple.esJefe())
                {
                    ControladorEmpleados.listaJefes.Add(emple);
                }
            }

        }


        private void FormAltaEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Quieres guardar los nuevos empleados?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ControladorEmpleados.escribirEmpleadosXML();              
            }
        }
    }
}
