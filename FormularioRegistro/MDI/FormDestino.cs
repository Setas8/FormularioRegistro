using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro.MDI
{
    public partial class FormDestino : Form
    {
        private string mensaje;
        // Propiedad pública para almacenar el mensaje.
        public string Mensaje { get; set; }
        public FormDestino(string mensa)
        {
            InitializeComponent();
            // Hacer algo con el parámetro recibido, como mostrarlo en un control TextBox.
            textBoxMensaje1.Text = mensa;
        }
        private void FormularioDestino_Load(object sender, EventArgs e)
        {
            // Hacer algo con el valor de la propiedad, como mostrarlo en un control TextBox.
            textBoxMensaje2.Text = Mensaje;
        }

    }
}
