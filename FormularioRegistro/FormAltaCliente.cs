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
            tbNIF.Clear();
            // tipoCliente;
            nUdDescuen.ResetText();
            tBComent.Clear();
            tbLogo.Clear();
            tbTlf.Clear();
            dTPCitas.ResetText();
            monCalenCitas.ResetText();

        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            //nombre
            if(string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.BackColor = Color.Red;
            }
            //Direcc
            else if (string.IsNullOrWhiteSpace(tbDirecc.Text))
            {
                tbDirecc.BackColor = Color.Red;
            }
            //Ciudad
            else if (string.IsNullOrWhiteSpace(tbCiudad.Text))
            {
                tbCiudad.BackColor = Color.Red;
            }
            //Pais
            else if (string.IsNullOrWhiteSpace(cbPais.Text))
            {
                cbPais.BackColor = Color.Red;
            }
            //Nombre representante
            else if (string.IsNullOrWhiteSpace(tbNomRepresen.Text))
            {
                tbNomRepresen.BackColor = Color.Red;
            }
            //correo
            else if (!new EmailAddressAttribute().IsValid(tbCorreo.Text))
            {
                tbCorreo.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, Ej.: loquesea@sea.sea");
            }
            //nif

            //TipoCliente

            //descuento

            //comentarios

            //logo
            else if (string.IsNullOrWhiteSpace(tbLogo.Text))
            {
                tbLogo.BackColor = Color.Red;
            }
            //tlf
            else if (string.IsNullOrWhiteSpace(tbTlf.Text))
            {
                tbTlf.BackColor = Color.Red;
            }
            //citas

            //calendariocitas




            else
            {
                tbNombre.BackColor = Color.White;
                ///todos campos a blanco

                crear = true;
            }
            if (crear)
            {

                Cliente cli = new Cliente(dniTB.Text, nombreTB.Text, ape1TB.Text, ape2TB.Text, puestoComBox.Text,
                                        correoTB.Text, comentsTB.Text, int.Parse(numTelTB.Text), long.Parse(numSSTB.Text),
                                        Convert.ToDateTime(fechaNacDTPicker.Value));


                ControladorEmpleados.listaEmpleados.Add(emple);
                tbNombre.BackColor = Color.White;
                ///todos campos a blanco
                MessageBox.Show("Cliente creado con éxito");
                
            }
        }

        
        private void FormAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Quieres guardar los nuevos clientes?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ControladorClientes.escribirBinario();
            }
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
