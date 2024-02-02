using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
