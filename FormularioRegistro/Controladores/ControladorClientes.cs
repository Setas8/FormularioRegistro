using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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
    }
}
