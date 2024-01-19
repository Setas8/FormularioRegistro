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
    public partial class FormComponentesProyectos : Form
    {
        public FormComponentesProyectos()
        {
            InitializeComponent();
        }

        

        private void FormComponentesProyectos_Load(object sender, EventArgs e)
        {
            ControladorProyectos.leerProyectosJSON();
            ControladorEmpleados.leerEmpleadosXML();
            mostrarEmpleados();
            mostrarProyectos();
        }
        private void mostrarEmpleados()
        {
            liBxEmpleados.Items.Clear();

            foreach (Empleado emp in ControladorEmpleados.listaEmpleados)
            {
                liBxEmpleados.Items.Add(emp.Nombre + "\t\t" + emp.Apellido1 + "\t\t" + emp.Dni);
            }

            liBxEmpleados.Show();
        }
        private void mostrarProyectos()
        {
            cmBxProyectos.Items.Clear();

            foreach (Proyecto p in ControladorProyectos.listaProyectos)
            {
                cmBxProyectos.Items.Add(p.Descripcion);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
