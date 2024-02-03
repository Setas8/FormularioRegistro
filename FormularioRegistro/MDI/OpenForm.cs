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
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            // Abrir algunos formularios cuando se carga el formulario principal.

            //AbrirFormulario(new Formulario1());
            //AbrirFormulario(new Formulario2());
        }
        private void AbrirFormulario(Form formulario)
        {
            // Mostrar el formulario y agregarlo a la colección de formularios abiertos.
            formulario.Show();
        }

        private void MostrarFormulariosAbiertos()
        {
            // Iterar a través de los formularios abiertos y mostrar información.
            foreach (Form form in Application.OpenForms)
            {
                Console.WriteLine($"Nombre del formulario: {form.Name}, Texto del formulario: {form.Text}");
            }
        }
        private void buttonMostrarFormularios_Click(object sender, EventArgs e)
        {
            // Llamar a la función para mostrar formularios abiertos.
            MostrarFormulariosAbiertos();
        }
    }
    /*
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
            this.Text = "Formulario 1";
        }
    }
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
            this.Text = "Formulario 2";
        }
    }
    */
}
