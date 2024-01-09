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
    public partial class FormListaEmpleados : Form
    {
        public FormListaEmpleados()
        {
            InitializeComponent();
        }

        private void FormListaEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleadosLista(ControladorEmpleados.listaEmpleados);
        }
        private void mostrarEmpleadosLista(List<Empleado> lista)
        {
            this.contadorNombres = 1; // Parámetro del
            this.posicionInicial = 40;
            foreach (Empleado e in lista)
            {
                
                crearEtiquetaLista(e.Id.ToString() + "\t" + string12Caracteres(e.Nombre) + "\t" + string12Caracteres(e.Apellido1) + "\t" +
                                   string12Caracteres(e.Apellido2) + "\t" + string12Caracteres(e.Dni) + "\t" + string12Caracteres(e.NumSS.ToString()) + "\t" +
                                   string12Caracteres(e.Puesto) + "\t" + string12Caracteres(e.FechaNacimiento.ToString("dd/MM/yy")));
               
            }
        }
        private int posicionInicial;
        private int contadorNombres;
        void crearEtiquetaLista(string nombre)
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
            GrupoLbl.Text = nombre;
            listBoxEmpleados.Controls.Add(GrupoLbl);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
        
        private void ordenarNomt_Check(object sender, EventArgs e)
        {
            this.listBoxEmpleados.Controls.Clear();
            ControladorEmpleados.listaEmpleados.Sort((e1, e2) => e1.Nombre.CompareTo(e2.Nombre));
            mostrarEmpleadosLista(ControladorEmpleados.listaEmpleados);
        }

        private void ordenarFechaNacimiento_Check(object sender, EventArgs e)
        {
            this.listBoxEmpleados.Controls.Clear();
            //listaProyectos.Sort((x, y) => x.FechaInicio.CompareTo(y.FechaInicio));
            ControladorEmpleados.listaEmpleados.Sort((e1, e2) => DateTime.Compare(e1.FechaNacimiento, e2.FechaNacimiento));
            mostrarEmpleadosLista(ControladorEmpleados.listaEmpleados);
        }

        private void ordenarDni_Check(object sender, EventArgs e)
        {
            this.listBoxEmpleados.Controls.Clear();
            ControladorEmpleados.listaEmpleados.Sort((e1, e2) => e1.Dni.CompareTo(e2.Dni));
            mostrarEmpleadosLista(ControladorEmpleados.listaEmpleados);
        }

        private void filtrarJefe_Check(object sender, EventArgs e)
        {
            this.listBoxEmpleados.Controls.Clear();
            List<Empleado> listaProgramadores = new List<Empleado>();
            foreach (Empleado em in ControladorEmpleados.listaEmpleados)
            {
                if (em.Puesto.Equals("Jefe proyecto"))
                {
                    listaProgramadores.Add(em);
                }
            }
            mostrarEmpleadosLista(listaProgramadores);


        }
        private void filtrarProgramadores_Check(object sender, EventArgs e)
        {
            this.listBoxEmpleados.Controls.Clear();
            List<Empleado> listaProgramadores = new List<Empleado>();
            foreach (Empleado em in ControladorEmpleados.listaEmpleados)
            {
                if (em.Puesto.Equals("Programador"))
                {
                    listaProgramadores.Add(em);
                }
            }
            mostrarEmpleadosLista(listaProgramadores);

        }
        private void filtrarJovenes_Check(object sender, EventArgs e)
        {
            this.listBoxEmpleados.Controls.Clear();
            List<Empleado> listaJovenes = new List<Empleado>();
            foreach (Empleado em in ControladorEmpleados.listaEmpleados)
            {
                if ((calcularEdad(em.FechaNacimiento) > 19) && (calcularEdad(em.FechaNacimiento) < 31))
                {
                    listaJovenes.Add(em);
                }
            }
            mostrarEmpleadosLista(listaJovenes);
        }

        private int calcularEdad(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Today;

            return fechaActual.Year - fecha.Year; ;
        }
        //Devuelve una cadena de caracteres de longitud 10
        public static String string12Caracteres(String palabra)
        {

            int tamanioCampo = 12;
            String str = "";
            int tamanioPalabra = palabra.Length;

            if (tamanioPalabra <= tamanioCampo)
            {
                for (int i = tamanioPalabra; i < tamanioCampo; i++)
                {
                    palabra += " ";
                }
                str = palabra;
            }
            else if (tamanioPalabra >= tamanioCampo)
            {
                str = palabra.Substring(0, tamanioCampo);
            }
            else
                str = palabra;

            return str;
        }

    }
}
