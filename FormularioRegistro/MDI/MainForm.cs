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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FormularioRegistro.MDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Establecer la propiedad IsMdiContainer en true para hacer de este formulario un MDI parent.
            this.IsMdiContainer = true;
            // Crear y mostrar formularios secundarios dentro del MDI parent.
            CrearFormularioHijo("FormularioHijo1");
            CrearFormularioHijo("FormularioHijo2");
            //AbrirFormulario(new Formulario1());
            //AbrirFormulario(new Formulario2());

        }
        private void CrearFormularioHijo(string nombreFormulario)
        {
            // Crear una nueva instancia del formulario hijo.
            FormularioHijo formularioHijo = new FormularioHijo();
            // Establecer propiedades para el formulario hijo.
            formularioHijo.Text = nombreFormulario;
            formularioHijo.MdiParent = this; 
            // Establecer el MDI parent a este formulario.
            // Mostrar el formulario hijo.
            formularioHijo.Show();
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
                Console.WriteLine($"Nombre del formulario: {form.Name}, Texto del formulario: { form.Text}");
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
