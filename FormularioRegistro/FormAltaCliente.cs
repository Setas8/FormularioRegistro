using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            domUDDescu.ResetText();
            richtbComent.Clear();
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
            //Pais
            else if (string.IsNullOrWhiteSpace(cbPais.Text))
            {
                MessageBox.Show("Selecciona un país");
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
                MessageBox.Show("El logo debe ser seleccionado");
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
                if (string.IsNullOrWhiteSpace(richtbComent.Text))
                {
                    richtbComent.Text = "Sin información";                 
                }
                //Descuento
                if (string.IsNullOrWhiteSpace(domUDDescu.Text))
                {
                    domUDDescu.Text = "0";                
                }

                string tipoCli = tipoCliente();
               

                Cliente cli = new Cliente(tbNombre.Text, tbDirecc.Text, tbCiudad.Text, cbPais.Text, tbNomRepresen.Text,
                                          tbCorreo.Text, masTBNIF.Text, tipoCli, int.Parse(domUDDescu.Text.ToString()),
                                          richtbComent.Text, tbLogo.Text, masTBTlf.Text, DateTime.Today,
                                          monCalenCitas.TodayDate, Convert.ToDateTime(dTPCitas.Value));

                MessageBox.Show(cli.Nombre + " " + cli.Direccion + " " + cli.Ciudad + " " + cli.Pais
                       + " " + cli.NombreRepresentante + " " + cli.Correo + " " + cli.Nif + " " + cli.TipoCliente
                       + " " + cli.Descuento + " " + cli.Comentarios + " " + cli.Logo + " " + cli.Telefono
                       + " " + cli.FechaAlta.Date + " " + cli.ProximaCita + " " + cli.UltimaCita);
                ControladorClientes.listaClientes.Add(cli);
                tbNombre.BackColor = Color.White;
                ///todos campos a blanco
                MessageBox.Show("Cliente creado con éxito");
                tbNombre.Clear();
                tbDirecc.Clear();
                tbCiudad.Clear();
                cbPais.ResetText();
                tbNomRepresen.Clear();
                tbCorreo.Clear();
                masTBNIF.ResetText();
                domUDDescu.ResetText();
                richtbComent.Clear();
                tbLogo.Clear();
                masTBTlf.Clear();
                dTPCitas.ResetText();
                monCalenCitas.ResetText();

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
         
            
            OpFDia.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            OpFDia.Title = "Seleccionar archivo de imagen";          
            
            


            DialogResult result = OpFDia.ShowDialog();

            // Procesa el resultado del cuadro de diálogo
            if (result == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string rutaOrigen = OpFDia.FileName;

                // Guarda la imagen en una nueva ubicación
                guardarImagen(rutaOrigen);
            }


        }
        private void guardarImagen(string rutaOrigen)
        {
            // Configura el SaveFileDialog para seleccionar la nueva ubicación y nombre del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            saveFileDialog.Title = "Guardar imagen en un nuevo directorio";

            // Muestra el cuadro de diálogo
            DialogResult result = saveFileDialog.ShowDialog();

            // Procesa el resultado del cuadro de diálogo
            if (result == DialogResult.OK)
            {
                // Obtiene la nueva ruta donde se guardará la imagen
                string nuevaRuta = saveFileDialog.FileName;

                // Copia la imagen desde la ruta de origen a la nueva ubicación
                try
                {
                    File.Copy(rutaOrigen, nuevaRuta, true);
                    MessageBox.Show("Imagen guardada exitosamente en: " + nuevaRuta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                    tbLogo.Text = OpFDia.SafeFileName;
                    prgBar.Value = progresoActual;
                    timer.Start();
                    timer.Tick += Timer_Tick;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }     
        private void Timer_Tick(object sender, EventArgs e)
        {                     
            progresoActual += 10;
            prgBar.PerformStep();
            prgBar.Value = progresoActual;
           
            // Si llega al máximo se para el timer
            if (progresoActual >= prgBar.Maximum)
            {
                picBox.ImageLocation = OpFDia.FileName;
                timer.Stop();               
                progresoActual = 0;
                timer.Tick -= Timer_Tick;
            }          
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

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richtbComent.SelectionColor = colorDialog1.Color;              
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {            
                richtbComent.SelectionFont = fontDialog1.Font;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var rutaAArchivo = string.Empty;
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        richtbComent.SaveFile(saveFileDialog1.FileName);
                        MessageBox.Show("Datos exportados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Datos NO exportados");
                    }
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richtbComent.SelectionColor = colorDialog1.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richtbComent.SelectionFont = fontDialog1.Font;
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rutaAArchivo = string.Empty;
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        richtbComent.SaveFile(saveFileDialog1.FileName);
                        MessageBox.Show("Datos exportados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Datos NO exportados");
                    }
                }
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
