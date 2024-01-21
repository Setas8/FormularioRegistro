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
            mostrarEmpleados(ControladorEmpleados.listaEmpleados);
            mostrarProyectos();
        }

        private int posicionInicial;
        private int contadorNombres;
        private void mostrarEmpleados(List<Empleado> lista)
        {
            liBxEmpleados.Items.Clear();

            this.contadorNombres = 1;
            this.posicionInicial = 15;

            foreach (Empleado emp in ControladorEmpleados.listaEmpleados)
            {
                liBxEmpleados.Items.Add(emp.Nombre + "\t\t" + emp.Id + "\t\t" + emp.Dni);
                liBxEmpleados.Tag = emp.Id;
                //crearEtiquetaLista(emp);
            }

            liBxEmpleados.Show();
            
        }
        void crearEtiquetaLista(Empleado emp)
        {
            RadioButton rb = new RadioButton();
            rb.AutoSize = true;
            rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            rb.Location = new System.Drawing.Point(40, this.posicionInicial);
            rb.Name = "lblProductos" + this.contadorNombres;
            rb.Size = new System.Drawing.Size(291, 20);
            rb.TabIndex = 1;
            rb.Text = emp.Nombre + "\t\t" + emp.Id + "\t\t" + emp.Dni;
            rb.Tag = emp;
            rb.CheckedChanged += RadioButton_CheckedChanged;
            liBxEmpleados.Controls.Add(rb);
            this.posicionInicial += 20;
            this.contadorNombres++;


        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Obtiene el objeto asociado al RadioButton
                Empleado emp = (Empleado)radioButton.Tag;

                tBIdEmp.Text = emp.Id.ToString();
              
            }
        }
        private void btnAddEmple_Click(object sender, EventArgs e)
        {
            if (liBxEmpleados.SelectedItem != null)
            {

                if (liBxEmpleados.SelectedItem is Empleado emp)
                {
                    //tBIdEmp.Text = emp.Id.ToString();
                    tBIdEmp.Text = tBIdEmp.Tag.ToString();
                }
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
