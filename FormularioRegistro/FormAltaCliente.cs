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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            masTBNIF.ResetText();
            // tipoCliente;
            nUdDescuen.ResetText();
            tBComent.Clear();
            tbLogo.Clear();
            masTBTlf.Clear();
            dTPCitas.ResetText();
            monCalenCitas.ResetText();
            /// todo a blanco

        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            bool crear = false;
                 
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
            //Pais
            else if (string.IsNullOrWhiteSpace(cbPais.Text))
            {
                cbPais.BackColor = Color.Red;
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
            else if (string.IsNullOrWhiteSpace(masTBNIF.Text))
            {
                masTBNIF.BackColor = Color.Red;
                crear = false;
            }
            else if (masTBNIF.Text.Length != 10)
            {
                masTBNIF.BackColor = Color.Red;
                MessageBox.Show("El NIF debe tener 9 caracteres");
                crear = false;
            }
            //tlf         
            else if (string.IsNullOrWhiteSpace(masTBTlf.Text))
            {
                masTBTlf.BackColor = Color.Red;
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
                masTBNIF.BackColor = Color.White;
                tbLogo.BackColor = Color.White;
                masTBTlf.BackColor = Color.White;

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
                                          tbCorreo.Text, masTBNIF.Text, tipoCli, int.Parse(nUdDescuen.Value.ToString()),
                                          tBComent.Text, tbLogo.Text, masTBTlf.Text, DateTime.Today,
                                          monCalenCitas.TodayDate, Convert.ToDateTime(dTPCitas.Value));

                MessageBox.Show(cli.Nombre + " " + cli.Direccion + " " + cli.Ciudad + " " + cli.Pais
                       + " " + cli.NombreRepresentante + " " + cli.Correo + " " + cli.Nif + " " + cli.TipoCliente
                       + " " + cli.Descuento + " " + cli.Comentarios + " " + cli.Logo + " " + cli.Telefono
                       + " " + cli.FechaAlta.Date + " " + cli.ProximaCita + " " + cli.UltimaCita);
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

        int progresoActual = 0;
        private void btnFileDialog_Click(object sender, EventArgs e)
        {
         
            OpFDia.ShowDialog();
            OpFDia.Filter = "Archivos JPEG|*.jpg";
            OpFDia.Title = "Seleccionar archivo JPEG";
            OpFDia.Tag = OpFDia.FileName;
            tbLogo.Text = OpFDia.SafeFileName;
            picBox.ImageLocation = OpFDia.FileName;





        }
        private void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Este evento se desencadena antes de que el cuadro de diálogo se cierre
            // Puedes realizar validaciones adicionales aquí
            prgBar.Value = progresoActual;
            timer.Start();
            timer.Tick += Timer_Tick;
                     
            if (!archivoCorrecto(OpFDia.FileName))
            {
                MessageBox.Show("El archivo no cumple con los criterios requeridos");
                e.Cancel = true; // Cancela la operación de apertura del archivo
            }

        }         
        private void Timer_Tick(object sender, EventArgs e)
        {                     
            progresoActual += 100; 

            prgBar.Value = progresoActual;

            // Si llega al máximo se para el timer
            if (progresoActual >= prgBar.Maximum)
            {              
                timer.Stop();               
                progresoActual = 0;
                timer.Tick -= Timer_Tick;
            }          
        }
        private bool archivoCorrecto(string filePath)
        {

            return filePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase);
        }
        private void ShowAWeeksVacationOneMonthFromToday()
        {
            DateTime today = this.monCalenCitas.TodayDate;
            DateTime vacationStart = today.AddMonths(1);
            DateTime vacationEnd = vacationStart.AddDays(7);
            // Select the week using SelectionStart and SelectionEnd.
            this.monCalenCitas.SelectionStart = vacationStart.AddDays(-1);
            this.monCalenCitas.SelectionEnd = vacationEnd.AddDays(-1);
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            ShowAWeeksVacationOneMonthFromToday();
            monCalenCitas.AddBoldedDate(new DateTime(2024, 10, 1));
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
