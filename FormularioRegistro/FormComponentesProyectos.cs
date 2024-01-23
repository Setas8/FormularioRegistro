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
                liBxEmpleados.Tag = emp.Id;
               
            }

            liBxEmpleados.Show();
            
        }
       
        private void btnAddEmple_Click(object sender, EventArgs e)
        {
           
            
            if (liBxEmpleados.SelectedItem != null)
            {
                tBIdEmp.Text = liBxEmpleados.Tag.ToString();                          
            }
            else
            {
                MessageBox.Show("Debes seleccionar un empleado");
            }
        }

        private void btnEliminarEmple_Click(object sender, EventArgs e)
        {

        }
        private void mostrarProyectos()
        {
            cmBxProyectos.Items.Clear();

            foreach (Proyecto p in ControladorProyectos.listaProyectos)
            {
                cmBxProyectos.Items.Add(p.Descripcion);
                cmBxProyectos.Tag = p.Codigo;
            }

        }   

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            if (cmBxProyectos.SelectedIndex == -1)
            {
                tBCodPro.Text = cmBxProyectos.Tag.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un proyecto");
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
