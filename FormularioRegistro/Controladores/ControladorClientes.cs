using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormularioRegistro.Controladores
{
    public class ControladorClientes
    {
        public static List<Cliente> listaClientes = new List<Cliente>();

        public static void leerBinario()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("clientes.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                listaClientes = (List<Cliente>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo binario " + e.Message);
            }
        }


        public static void escribirBinario()
        {
            try
            {
                Stream SaveFileStream = File.Create("clientes.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, listaClientes);
                SaveFileStream.Close();
                //return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo binario " + e.Message);
            }
        }

        private int posicionInicial;
        private int contadorNombres;
        void crearEtiquetaLista(Cliente c, Control cnt)
        {

            CheckBox chBox1 = new System.Windows.Forms.CheckBox();
            chBox1.AutoSize = true;
            chBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chBox1.Location = new System.Drawing.Point(40, this.posicionInicial);
            chBox1.Name = "lblProyecto" + this.contadorNombres;
            chBox1.Size = new System.Drawing.Size(291, 20);
            chBox1.TabIndex = 1;
            chBox1.Text = c.Nombre;
            chBox1.Tag = c;
            cnt.Controls.Add(chBox1);
            this.posicionInicial += 20;
            this.contadorNombres++;

        }
        private void mostrarProyectosLista(List<Cliente> lista, Control cnt)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Cliente c in lista)
            {
                crearEtiquetaLista(c, cnt);
            }
        }
        private string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "baseDatosGestiona.mdf");
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={ databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }
        private void insertarCliente(Usuario u)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Proyectos (Nombre, Direccion, Ciudad, Pais, NombreRepresentante, Correo," +
                       " Nif, TipoCliente, Descuento, Comentarios) VALUES(@Nombre, @FechaInicio, @FechaFin, @Estado," +
                     " @PresupuestoInicial,@PresupuestoActual, @Cambios, @CodigoCliente)";
            // Valores para los parámetros
            string descripcion = u.PId
            string fechaInicio = 
          
            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    // No se añade a la inserción el campo código proyecto porque es autonumérico,
                    // aunque se puede configurar para poder // insertarlo a la fuerza.
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@PresupuestoInicial",
                    presupuestoInicial);
                    command.Parameters.AddWithValue("@PresupuestoActual",
                    presupuestoFinal);
                    command.Parameters.AddWithValue("@Cambios", cambios);
                    command.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros
                        afectados: { registrosAfectados}
                        ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }

        }
            }
