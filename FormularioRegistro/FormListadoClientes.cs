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
    public partial class FormListadoClientes : Form
    {
        public FormListadoClientes()
        {
            InitializeComponent();

        }

        private void FormListadoClientes_Load(object sender, EventArgs e)
        {
            ControladorClientes.leerBinario();

            dataGridViewClientes.DataSource = ControladorClientes.listaClientes;


            //Permite edición de celdas
            dataGridViewClientes.ReadOnly = false;
            // Cambiar el color de fondo de las celdas seleccionadas
            dataGridViewClientes.DefaultCellStyle.SelectionBackColor = Color.LightGray;


            /*
            // Agregar una columna programáticamente
            DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
            nuevaColumna.HeaderText = "Nueva Columna";
            dataGridView1.Columns.Add(nuevaColumna);
            */
            /*
            // Seleccionar una celda
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            dataGridView1.Rows[0].Selected = true;
            */
            /*
            // Establecer el estilo de una celda condicionalmente
            if (Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) > 100)
            {
                dataGridView1.Rows[0].Cells[1].Style.BackColor = Color.Red;
            }
            */
       
            /*
            dataGridView1.Rows // es un array de las filas del datagrid
            dataGridView1.SelectedRows // es un array de las filas seleccionadas
            dataGridViewClientes.SelectedColumns // es un array de las columnas seleccionadas
            */
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar clic en una celda
            // Si cambia valor guardar en lista, validar o escribir en XML
        }





        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Validar el valor de la celda antes de aceptarlo
        }
    }

}   
    
/*
   dataGridView1.DataSource = ControladorUsuarios.RecuperarUsuarios();

   dataGridView1.Rows // es un array de las filas del datagrid
   dataGridView1.SelectedRows // es un array de las filas seleccionadas
   dataGridView1.SelectedColumns // es un array de las columnas seleccionadas

   dataGridView1.Columns[0].Nombre  
 */
