using FormularioRegistro.CLASES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormularioRegistro.Controladores
{
    public class ControladorComponentesProyectos
    {
        public static List<ComponentesProyecto> listaComponentesProyect = new List<ComponentesProyecto>();

        public static void leerComponentesXML()
        {
            try
            {
                string xml = File.ReadAllText("componentesProyecto.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaComponentesProyect.GetType());
                    listaComponentesProyect = (List<ComponentesProyecto>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }
        //Escribir a un archivo XML
        public static void escribirComponentesXML()
        {
            try
            {
                using (var writer = new StreamWriter("componentesProyecto.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaComponentesProyect.GetType());
                    serializer.Serialize(writer, listaComponentesProyect, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml " + e.Message);
            }
        }


    }
}
