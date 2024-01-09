using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace FormularioRegistro.Controladores
{
    public class ControladorProyectos
    {

        public static List<Proyecto> listaProyectos = new List<Proyecto>();

        //Constructor vacío
        public static void leerProyectosJSON() 
        { 
            try
            {
                if (File.Exists("proyectos.json"))
                {
                    string jsonString = File.ReadAllText("proyectos.json");
                    listaProyectos = JsonSerializer.Deserialize<List<Proyecto>>(jsonString);
                }
            } catch(Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }                 

        }
        public static void escribirProyectosJSON()
        {
            try
            {
                if (File.Exists("proyectos.json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaProyectos);
                    File.WriteAllText("proyectos.json", jsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo json " + e.Message);
            }
        }
        
    }
}
