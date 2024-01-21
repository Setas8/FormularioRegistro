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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FormularioRegistro
{
    public partial class formularioListado : Form
    {
        public formularioListado()
        {
            InitializeComponent();           
        }      
        private void formularioListado_Load(object sender, EventArgs e)
        {         
            mostrarProyectosLista(ControladorProyectos.listaProyectos); 
        }
        private int posicionInicial;
        private int contadorNombres;

        void crearEtiquetaLista(Proyecto p)
        {

            CheckBox chBox1 = new System.Windows.Forms.CheckBox();
            chBox1.AutoSize = true;
            chBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            chBox1.Location = new System.Drawing.Point(40, this.posicionInicial);
            chBox1.Name = "lblProyecto" + this.contadorNombres;
            chBox1.Size = new System.Drawing.Size(291, 20);
            chBox1.TabIndex = 1;
            chBox1.Text = p.Descripcion;
            chBox1.Tag = p;
            groupBoxProyectos.Controls.Add(chBox1);
            this.posicionInicial += 20;
            this.contadorNombres++;

        }

        private void mostrarProyectosLista(List<Proyecto> lista)
        {
            this.contadorNombres = 1; 
            this.posicionInicial = 15;
            foreach (Proyecto p in lista)
            {
                crearEtiquetaLista(p);
            }
        }

        private void ordenarBot_Click(object sender, EventArgs e)
        {
            FormListadoProyectos proyectoForm = new FormListadoProyectos();
            proyectoForm.ShowDialog();
        }
        private void eliminarBoton_Click(object sender, EventArgs e)
        {
            
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (CheckBox item in groupBoxProyectos.Controls)
            {
                
                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorProyectos.listaProyectos.FindIndex(p => p == item.Tag);
                    ControladorProyectos.listaProyectos.RemoveAt(indice);
                                       
                }
            }
            //Borrar elementos y cargarlos con los modificados
            groupBoxProyectos.Controls.Clear();
            mostrarProyectosLista(ControladorProyectos.listaProyectos);
        }       
        /*
        private void cargarProyectos()
        {
            ArrayProyectos[0] = "PROYECTO 1";
            ArrayProyectos[1] = "PROYECTO 2";
            ArrayProyectos[2] = "PROYECTO 4";
            ArrayProyectos[3] = "PROYECTO 3";
            ArrayProyectos[4] = "PROYECTO 5";
        }
        
            void crearEtiqueta(string proyecto, int posicion, int contadorNombre)
        {
              
                Label LblProyecto = new System.Windows.Forms.Label();
                LblProyecto.AutoSize = true;
                LblProyecto.Font = new System.Drawing.Font("Opus Chords Std", 12F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
                LblProyecto.Location = new System.Drawing.Point(75, posicion);
                LblProyecto.Name = "lblProyecto" + contadorNombre;
                LblProyecto.Size = new System.Drawing.Size(291, 20);
                LblProyecto.TabIndex = 1;
                LblProyecto.Text = proyecto;               
                groupBoxProyectos.Controls.Add(LblProyecto);                     
        }
        private void mostrarProyectos()
        {
            int cont = 0;
            int posicion = 30;
            foreach (String p in ArrayProyectos)
            {
                crearEtiqueta(p, posicion, cont);
                posicion+=30;
                cont++;              
            }          
        }

       */
    }
}
