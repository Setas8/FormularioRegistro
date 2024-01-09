using FormularioRegistro.Controladores;
using System;
using System.Collections;
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
    public partial class FormListadoProyectos : Form
    {
        public FormListadoProyectos()
        {
            InitializeComponent();
        }
        //private String[] ArrayProyectos = new String[5];
        //private List<Proyecto> listaProyectos = new List<Proyecto>();

        private void FormularioProyectos_Load(object sender, EventArgs e)
        {
            //cargarProyectosLista();
            mostrarProyectosLista(ControladorProyectos.listaProyectos);

        }
        
        private void mostrarProyectosLista(List<Proyecto> lista)
        {
            this.contadorNombres = 1; // Parámetro del
            this.posicionInicial = 40;
            foreach (Proyecto p in lista)
            {
                crearEtiquetaLista(p.Descripcion + "      " + p.FechaInicio.ToString("dd/MM/yy") + "   " +
                                   p.FechaFin.ToString("dd/MM/yy") + "    " + p.PresupuestoInicial + "€");
            }
        }
        private int posicionInicial;
        private int contadorNombres;
        void crearEtiquetaLista(string proyecto)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;          
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            GrupoLbl.Location = new System.Drawing.Point(1, this.posicionInicial);
            GrupoLbl.Name = "lblProyecto" + this.contadorNombres;
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = proyecto;
            proyectosGroupBox.Controls.Add(GrupoLbl);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
                 
        private void ordenarDescBot_Click(object sender, EventArgs e)
        {
            this.proyectosGroupBox.Controls.Clear();
            ControladorProyectos.listaProyectos.Sort((p1, p2) => p1.Descripcion.CompareTo(p2.Descripcion));
            mostrarProyectosLista(ControladorProyectos.listaProyectos);
        }
        
        private void ordenarFechaInicioBot_Click(object sender, EventArgs e)
        {
            this.proyectosGroupBox.Controls.Clear();
            //listaProyectos.Sort((x, y) => x.FechaInicio.CompareTo(y.FechaInicio));
            ControladorProyectos.listaProyectos.Sort((p1, p2) => DateTime.Compare(p1.FechaInicio, p2.FechaInicio));
            mostrarProyectosLista(ControladorProyectos.listaProyectos);
        }

        private void ordenarFechaFinalBot_Click(object sender, EventArgs e)
        {
            this.proyectosGroupBox.Controls.Clear();
            //listaProyectos.Sort((x, y) => x.FechaFin.CompareTo(y.FechaFin));
            ControladorProyectos.listaProyectos.Sort((p1, p2) => DateTime.Compare(p1.FechaFin, p2.FechaFin));    
            mostrarProyectosLista(ControladorProyectos.listaProyectos);
        }

        private void ordenarPresupuestoInicialBot_Click(object sender, EventArgs e)
        {
            this.proyectosGroupBox.Controls.Clear();
            ControladorProyectos.listaProyectos.Sort((p1, p2) => p1.PresupuestoInicial.CompareTo(p2.PresupuestoInicial));
            mostrarProyectosLista(ControladorProyectos.listaProyectos);
        }
        /*
         private void cargarProyectosLista()
        {
            Proyecto.listaProyectos.Add(new Proyecto("Web 1.0 para Técnicas Reunidas", new DateTime(2023,10,11,0,0,0),
                               new DateTime(2024,10,01,0,0,0), 2000, 1500, false, 428, estado.INICIO));
            Proyecto.listaProyectos.Add(new Proyecto("Aplicación móvil de facturación para AXA", new DateTime(2023,10,10,0,0,0),
                               new DateTime(2024,02,15,0,0,0), 6000, 1500, false, 15, estado.EJECUCION));
            Proyecto.listaProyectos.Add(new Proyecto("Refactorización de código aplicación interna ASZ 3.2", new DateTime(2023,10,08,0,0,0),
                               new DateTime(2025,09,30,0,0,0), 200, 150, false, 122, estado.PLANIFICACION));
            Proyecto.listaProyectos.Add(new Proyecto("Pruebas End-2-End para INDRA", new DateTime(2023,10,05,0,0,0),
                               new DateTime(2025,05,05,0,0,0), 150, 300, false, 546, estado.INICIO));
            Proyecto.listaProyectos.Add(new Proyecto("Web 2.0 para Lufthansa", new DateTime(2023,10,18,0,0,0),
                               new DateTime(2023,12,31,0,0,0), 10000, 10000, false, 666, estado.SUPERVISION));

        }
         
         
        */
    }
}
