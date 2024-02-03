using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro.MDI
{
    public partial class FormOrigen : Form
    {
        public FormOrigen()
        {
            InitializeComponent();
        }
        private void buttonAbrirDestino_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario destino y pasar parámetros al  constructor.
            FormDestino formularioDestino = new FormDestino("Hola desde el formulario origen. Parámetros");

            // Establecer valores de las propiedades públicas en el formulario destino.
            formularioDestino.Mensaje = "Hola desde el formulario origen. Propiedad pública";


            formularioDestino.Show();
        }
    }
}
