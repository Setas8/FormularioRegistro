using FormularioRegistro.Controladores;
using FormularioRegistro.MDI;
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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

            //cargarProyectosLista();
            //cargarEmpleadosLista();


            notifyIconSeta.Visible = true;
            toolStripStatusLblDate.Text = DateTime.Today.Date.ToShortDateString();
            ControladorEmpleados.leerEmpleadosXML();          
            ControladorProyectos.leerProyectosJSON();
            ControladorClientes.leerBinario();
            ControladorUsuarios.leerUsuariosXML();

        }
        
        private void altaProyectoMenu_Click(object sender, EventArgs e)
        {
            FormAltaProyecto formuAlta = new FormAltaProyecto();
            formuAlta.ShowDialog();
        }

        private void listadosProyectosMenu_Click(object sender, EventArgs e)
        {
            formularioListado listado = new formularioListado();
            listado.ShowDialog();
        }

        private void altaEmpleadoMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaEmpleados altaEmple = new FormAltaEmpleados();
            altaEmple.ShowDialog();
        }

        private void listaEmpleadosMenuItem_Click(object sender, EventArgs e)
        {
            FormListaEmpleados listaEmpleados = new FormListaEmpleados();
            listaEmpleados.ShowDialog();
        }
        private void altaClienteMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaCliente client = new FormAltaCliente();
            client.ShowDialog();
        }
        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Estás seguro de cerrar?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void FormularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void verLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creación de un objeto FolderBrowserDialog:
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = ".";
            // Mostrar el cuadro de diálogo para seleccionar un directorio
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FormLogs logs = new FormLogs();
                //propiedad pública del formulario log
                FormLogs.directorio = folderBrowserDialog.SelectedPath;

                logs.Show();

            }

        }

        private void componenteProyectoMenu_Click(object sender, EventArgs e)
        {
            FormComponentesProyectos compo = new FormComponentesProyectos();
            compo.ShowDialog();
        }

        private void btnToolPro_Click(object sender, EventArgs e)
        {
            FormAltaProyecto formuAlta = new FormAltaProyecto();
            formuAlta.ShowDialog();
        }

        private void btnToolEmp_Click(object sender, EventArgs e)
        {
            FormAltaEmpleados altaEmple = new FormAltaEmpleados();
            altaEmple.ShowDialog();
        }

        private void btnToolCli_Click(object sender, EventArgs e)
        {
            FormAltaCliente client = new FormAltaCliente();
            client.ShowDialog();
        }

        private void btnToolSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoClientesTSMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoClientes listClientes = new FormListadoClientes();
            listClientes.ShowDialog();
        }

        private void YstMImpresPrelimi_Click(object sender, EventArgs e)
        {
            Form_ImpresionPreliminar acerca = new Form_ImpresionPreliminar();
            acerca.ShowDialog();
        }
     
        private void mDIParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mdi = new MainForm();
            mdi.ShowDialog();
        }

        private void openFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm openf = new OpenForm();
            openf.ShowDialog();
        }

        private void activeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrigen fOrigen = new FormOrigen();
            fOrigen.ShowDialog();
        }
    }
}
/*
        private void cargarProyectosLista()
        {

            ControladorProyectos.listaProyectos.Add(new Proyecto("Web 1.0 para Técnicas Reunidas", new DateTime(2023, 10, 11, 0, 0, 0),
                               new DateTime(2024, 10, 01, 0, 0, 0), 2000, 1500, false, 428, estado.INICIO));
            ControladorProyectos.listaProyectos.Add(new Proyecto("Aplicación móvil de facturación para AXA", new DateTime(2023, 10, 10, 0, 0, 0),
                               new DateTime(2024, 02, 15, 0, 0, 0), 6000, 1500, false, 15, estado.EJECUCION));
            ControladorProyectos.listaProyectos.Add(new Proyecto("Refactorización de código aplicación interna ASZ 3.2", new DateTime(2023, 10, 08, 0, 0, 0),
                               new DateTime(2025, 09, 30, 0, 0, 0), 200, 150, false, 122, estado.PLANIFICACION));
            ControladorProyectos.listaProyectos.Add(new Proyecto("Pruebas End-2-End para INDRA", new DateTime(2023, 10, 05, 0, 0, 0),
                               new DateTime(2025, 05, 05, 0, 0, 0), 150, 300, false, 546, estado.INICIO));
            ControladorProyectos.listaProyectos.Add(new Proyecto("Web 2.0 para Lufthansa", new DateTime(2023, 10, 18, 0, 0, 0),
                               new DateTime(2023, 12, 31, 0, 0, 0), 10000, 10000, false, 666, estado.SUPERVISION));

            ControladorProyectos.escribirProyectosJSON();

        }
        private void cargarEmpleadosLista()
        {
            
            Empleado.listaEmpleados.Add(new Empleado("11111111A", "Ricardo", "López", "Martínez", "Analista", "a@a.com",
                                                     "comentarios", 666800428, 086545789556, new DateTime(1980, 10, 01, 0, 0, 0)));
            Empleado.listaEmpleados.Add(new Empleado("222222222B", "Raquel", "Pérez", "Valcarcel", "Programador", "b@b.com",
                                                     "comentarios", 657895623, 081236544589, new DateTime(1988, 12, 14, 0, 0, 0)));
            Empleado.listaEmpleados.Add(new Empleado("444444444D", "Luis", "Norman", "Gallego", "Ventas", "d@d.com",
                                                     "comentarios", 636528945, 125895625475, new DateTime(1978, 04, 23, 0, 0, 0)));
            Empleado.listaEmpleados.Add(new Empleado("333333333C", "Cristina", "Fiol", "Muñoz", "Jefe proyecto", "c@c.com",
                                                     "comentarios", 647856985, 087595654895, new DateTime(1999, 01, 02, 0, 0, 0)));
            Empleado.listaEmpleados.Add(new Empleado("555555555E", "Ernesto", "Gonzalez", "Gonzalez", "R.R.H.H", "e@e.com",
                                                     "comentarios", 659632235, 084579269585, new DateTime(1986, 11, 08, 0, 0, 0)));

            foreach (Empleado em in Empleado.listaEmpleados)
            {
                if (em.esJefe())
                {
                    Empleado.listaJefes.Add(em);
                }
            }

            Empleado.escribirEmpleadosXML();
        }
        */