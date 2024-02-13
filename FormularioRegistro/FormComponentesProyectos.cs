using FormularioRegistro.CLASES;
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
            tBCodPro.BackColor = Color.White;
            tBIdEmp.BackColor = Color.White;
            puestoComBox.BackColor = Color.White;
            tBDedica.BackColor = Color.White;
            tBExtras.BackColor = Color.White;

        }

        private void btnAddCompo_Click(object sender, EventArgs e)
        {
            bool crear = false;
            float f;
            int i;
            decimal m;
               

            if (string.IsNullOrWhiteSpace(puestoComBox.Text))
            {
                puestoComBox.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(tBDedica.Text))
            {
                tBDedica.BackColor = Color.Red;
            }
            else if (!float.TryParse(tBDedica.Text, out f))
            {
                tBDedica.BackColor = Color.Red;
                MessageBox.Show("El porcentaje sólo debe tener caracteres numéricos");
            }
            else if ((float.Parse(tBDedica.Text) > 100) || (float.Parse(tBDedica.Text) < 0))
            {
                tBDedica.BackColor = Color.Red;
                MessageBox.Show("El porcentaje debe ser de 0-100");
            }
            else if (string.IsNullOrWhiteSpace(tBExtras.Text))
            {
                tBExtras.BackColor = Color.Red;
            }
            else if (!decimal.TryParse(tBExtras.Text, out m))
            {
                tBExtras.BackColor = Color.Red;
                MessageBox.Show("Los extras sólo deben tener caracteres numéricos");
            }
            else if (decimal.Parse(tBExtras.Text) < 0)
            {
                tBExtras.BackColor = Color.Red;
                MessageBox.Show("Los extras no deben ser negativos");
            }
            else
            {
                tBCodPro.BackColor = Color.White;
                tBIdEmp.BackColor = Color.White;
                puestoComBox.BackColor = Color.White;
                tBDedica.BackColor = Color.White;
                tBExtras.BackColor = Color.White;         

                crear = true;
            }
            if (crear)
            {
                ComponentesProyecto cp = new ComponentesProyecto(int.Parse(tBCodPro.Text),int.Parse(tBIdEmp.Text), puestoComBox.Text,
                                                         float.Parse(tBDedica.Text), decimal.Parse(tBExtras.Text));


                ///Comprobar que un empleado no está asignado ya a ese proyecto
                if (existeComponente(cp))
                {
                    tBIdEmp.Clear();
                    puestoComBox.ResetText();
                    tBDedica.Clear();
                    tBExtras.Clear();
                    MessageBox.Show("El empleado ya está asignado a ese proyecto");

                }
                else
                {
                    ControladorComponentesProyectos.listaComponentesProyect.Add(cp);
                    tBCodPro.Clear();
                    tBIdEmp.Clear();
                    puestoComBox.ResetText();
                    tBDedica.Clear();
                    tBExtras.Clear();
                    MessageBox.Show("Componente creado con éxito");                   
                }
           
            }

        }
        private bool existeComponente(ComponentesProyecto cp)
        {
            bool existe = false;

            foreach (ComponentesProyecto c in ControladorComponentesProyectos.listaComponentesProyect)
            {
                if ((cp.CodigoProyecto.Equals(c.CodigoProyecto)) && (cp.IdEmpleado.Equals(c.IdEmpleado)))
                {
                    existe = true;
                }
            }


            return existe;
        }
        private void FormComponentesProyectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Quieres guardar los nuevos componentes?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                ControladorComponentesProyectos.escribirComponentesXML();
            }
        }
    }
}

