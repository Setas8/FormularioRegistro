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

            cmBxProyectos.DataSource = ControladorProyectos.listaProyectos;
            cmBxProyectos.DisplayMember = "Descripcion";
            cmBxProyectos.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (liBxEmpleados.SelectedItems.Count != 0)
            {
                int indice = liBxEmpleados.SelectedIndex;
                tBIdEmp.Text = ControladorEmpleados.listaEmpleados[indice].Id.ToString();
                tBCodPro.Text = ((Proyecto)cmBxProyectos.SelectedItem).Codigo.ToString();

            }
            else
            {
                MessageBox.Show("Debes seleccionar un empleado");
            }
        }

        private void btnResetCompo_Click(object sender, EventArgs e)
        {

            tBCodPro.Clear();
            tBIdEmp.Clear();
            puestoComBox.ResetText();
            tBDedica.Clear();
            tBExtras.Clear();

        }

       
    }
}
