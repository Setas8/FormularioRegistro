using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
            CargarDatosEnComboBox();
        }

        
        private bool validarUsuario()
        {
            bool crear = false;
            if (string.IsNullOrWhiteSpace(tbxUser.Text))
            {
                tbxUser.BackColor = Color.Red;
                crear = false;
            }        
            else if (string.IsNullOrWhiteSpace(tBxPswd.Text))
            {
                tBxPswd.BackColor = Color.Red;
                crear = false;
            }
            else
            {
                tbxUser.BackColor= Color.White;
                tBxPswd.BackColor = Color.White;            
                crear = true;
            }
            return crear;
                     
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (validarUsuario())
            {
                Usuario u = new Usuario(tbxUser.Text, tBxPswd.Text);
                ControladorUsuarios.insertarUsuario(u);
                tbxUser.Clear();
                tBxPswd.Clear();
            }
            else
            {
                MessageBox.Show("Usuario no se ha podido insertar");
            }
        }


        
        private void CargarDatosEnDataGridView()
        {
            
            string connectionString = ControladorUsuarios.construirCadenaConexión();

            string query = "SELECT id_user, clave FROM Usuarios";

            dataGridUsers.Columns.Clear();
            dataGridUsers.Columns.Add("id_user", "id_user");
            //dataGridUsers.Columns.Add("user", "user");
            dataGridUsers.Columns.Add("clave", "clave");



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con los campos usuario
                                dataGridUsers.Rows.Add(reader["id_user"].ToString(), reader["clave"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }
        private void CargarDatosEnComboBox()
        {


            string connectionString = ControladorUsuarios.construirCadenaConexión();           
            string query = "SELECT clave FROM Usuarios";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar cada campo al ComboBox
                                comBxUsers.Items.Add(reader["clave"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ ex.StackTrace}");
                }
            }
        }

        
    }
}
