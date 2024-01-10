using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {

            tbNombre.Clear();
            tbDirecc.Clear();
            tbCiudad.Clear();
            cbPais.ResetText();
            tbNomRepresen.Clear();
            tbCorreo.Clear();
            tbNIF.ResetText();
            // tipoCliente;
            nUdDescuen.ResetText();
            tBComent.Clear();
            tbLogo.Clear();
            tbTlf.Clear();
            dTPCitas.ResetText();
            monCalenCitas.ResetText();
            /// todo a blanco

        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            int i;         

            //nombre
            if(string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.BackColor = Color.Red;
                crear = false;
            }
            //Direcc
            else if (string.IsNullOrWhiteSpace(tbDirecc.Text))
            {
                tbDirecc.BackColor = Color.Red;
                crear = false;
            }
            //Ciudad
            else if (string.IsNullOrWhiteSpace(tbCiudad.Text))
            {
                tbCiudad.BackColor = Color.Red;
                crear = false;
            }          
            //Nombre representante
            else if (string.IsNullOrWhiteSpace(tbNomRepresen.Text))
            {
                tbNomRepresen.BackColor = Color.Red;
                crear = false;
            }
            //correo
            else if (!new EmailAddressAttribute().IsValid(tbCorreo.Text))
            {
                tbCorreo.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, Ej.: loquesea@sea.sea");
                crear = false;
            }
            //nif
            else if (string.IsNullOrWhiteSpace(tbNIF.Text))
            {
                tbNIF.BackColor = Color.Red;
                crear = false;
            }
            else if (tbNIF.Text.Length != 9)
            {
                tbNIF.BackColor = Color.Red;
                MessageBox.Show("El NIF debe tener 9 caracteres");
                crear = false;
            }
            //tlf
            else if (!int.TryParse(tbTlf.Text, out i))
            {
               
                tbTlf.BackColor = Color.Red;
                MessageBox.Show("El teléfono sólo debe tener caracteres numéricos");
                crear = false;
            }
            else if (string.IsNullOrWhiteSpace(tbTlf.Text))
            {
                tbTlf.BackColor = Color.Red;
                crear = false;
            }
            else if (tbTlf.Text.Length != 9)
            {
                tbTlf.BackColor = Color.Red;
                MessageBox.Show("El teléfono debe tener 9 caracteres");
                crear = false;
            }
            //TipoCliente
            else if (!comprobarRadioButton())
            {
                MessageBox.Show("El tipo de cliente debe ser seleccionado");
                crear = false;
            }
    
            //logo
            else if (string.IsNullOrWhiteSpace(tbLogo.Text))
            {
                tbLogo.BackColor = Color.Red;
                crear = false;
            }
            
            //citas

            //calendariocitas

            else
            {
                tbNombre.BackColor = Color.White;
                tbDirecc.BackColor = Color.White;
                tbCiudad.BackColor = Color.White;
                tbNomRepresen.BackColor = Color.White;
                tbCorreo.BackColor = Color.White;
                tbNIF.BackColor = Color.White;
                tbLogo.BackColor = Color.White;
                tbTlf.BackColor = Color.White;

                ///todos campos a blanco

                crear = true;
            }
            if (crear)
            {

                //comentarios
                if (string.IsNullOrWhiteSpace(tBComent.Text))
                {
                    tBComent.Text = "Sin información";                 
                }

                string tipoCli = tipoCliente();


                Cliente cli = new Cliente(tbNombre.Text, tbDirecc.Text, tbCiudad.Text, cbPais.Text, tbNomRepresen.Text,
                                          tbCorreo.Text, tbNIF.Text, tipoCli, int.Parse(nUdDescuen.Value.ToString()),
                                          tBComent.Text, tbLogo.Text, int.Parse(tbTlf.Text), DateTime.Today,
                                          monCalenCitas.TodayDate, Convert.ToDateTime(dTPCitas.Value));


                ControladorClientes.listaClientes.Add(cli);
                tbNombre.BackColor = Color.White;
                ///todos campos a blanco
                MessageBox.Show("Cliente creado con éxito");
                
            }
        }
        public bool comprobarRadioButton()
        {
            bool estadoRadio = false;

            foreach (Control c in gbTipoCli.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;

                    // Verifica si el RadioButton está seleccionado
                    if (radioButton.Checked)
                    {
                        estadoRadio = true;
                    }
                }
            }
            return estadoRadio;
        }
        public string tipoCliente()
        {
            string tipoC = "";
            foreach (Control c in gbTipoCli.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    
                    if (radioButton.Checked)
                    {
                        tipoC = radioButton.Text;
                    }
                }
            }
            return tipoC;
        }
        
        private void FormAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Quieres guardar los nuevos clientes?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                ControladorClientes.escribirBinario();
            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
           

            OpFDia.ShowDialog();
            OpFDia.Filter = "Archivos JPEG|*.jpg;*.jpeg|Todos los archivos|*.*";
            OpFDia.Title = "Seleccionar archivo JPEG";
            OpFDia.AddExtension = true;
            OpFDia.FileName = ".jpg";
            tbLogo.Text = OpFDia.FileName;
            

        }
        /*      
ErrorProvider errorProvider1 = new ErrorProvider();
ErrorProvider errorProvider2 = new ErrorProvider();
private void user_Validating(object sender, CancelEventArgs e)
{
   if (String.IsNullOrWhiteSpace(tbUser.Text))
   {
       errorProvider1.SetError(tbUser, "El campo nuevo usuario se debe rellenar");
   }
   else
   {
       errorProvider1.Clear();
   }
}
private void pswd_Validating(object sender, CancelEventArgs e)
{
   if (String.IsNullOrWhiteSpace(tbPswd.Text))
   {
       errorProvider2.SetError(tbPswd, "El campo contraseña se debe rellenar");
   }
   else
   {
       errorProvider2.Clear();
   }
}              
*/
    }
}
