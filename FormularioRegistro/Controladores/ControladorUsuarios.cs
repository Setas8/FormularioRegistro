using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormularioRegistro.Controladores
{
    public class ControladorUsuarios
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        //Leer de un archivo XML
        public static void leerUsuariosXML()
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaUsuarios.GetType());
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }
        //Escribir a un archivo XML
        public static void escribirUsuariosXML()
        {
            try
            {
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaUsuarios.GetType());
                    serializer.Serialize(writer, listaUsuarios, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml " + e.Message);
            }
        }
    }
}
