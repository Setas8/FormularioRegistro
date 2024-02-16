using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class Form_ListProyBBDDcodigo : Form
    {
        private BindingSource bindingSourceProyectos;
        private List<Proyecto> listaProyectos;
        public Form_ListProyBBDDcodigo()
        {
            InitializeComponent();
            // Inicializa la lista de clientes (puedes obtenerla de tu origen de datos)
            listaProyectos = ObtenerClientesDesdeOrigenDeDatos();
            // Crea un BindingSource y asigna la lista de clientes como DataSource
            bindingSourceProyectos = new BindingSource();
            bindingSourceProyectos.DataSource = listaProyectos;
            // Asigna el BindingSource como DataSource del DataGridView
            datGrProyectos.DataSource = bindingSourceProyectos;
        }
        private List<Proyecto> ObtenerClientesDesdeOrigenDeDatos()
        {
            // Implementa la lógica para obtener tus datos desde tu origen de datos
            ControladorProyectos.leerProyectosJSON();

         
            return ControladorProyectos.listaProyectos;
          
        }

        private void Form_ListProyBBDDcodigo_Load(object sender, EventArgs e)
        {

        }
    }

}

