using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace FormularioRegistro
{
    public enum estado
    {
        INICIO,
        PLANIFICACION,
        EJECUCION,
        SUPERVISION,
        CIERRE
    }
    public class Proyecto
    {
        private double presupuestoInicial;
        private double presupuestoActual;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int    codigo;
        private int    codigoCliente;
        private string descripcion;
		private bool   cambios;
        private estado estadoProyecto;
        static private int codigoIncrementado = 1;

        //public static List<Proyecto> listaProyectos = new List<Proyecto>();
        
        //Constructor vacío para xml y/o JSON
        public Proyecto() { }

        /*
        //Leer de un archivo XML
        public static void leerProyectosXML()
        {
            try
            {
                string xml = File.ReadAllText("proyectos.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaProyectos.GetType());
                    listaProyectos = (List<Proyecto>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }
        //Escribir a un archivo XML
        public static void escribirProyectosXML()
        {
            try
            {
                using (var writer = new StreamWriter("proyectos.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaProyectos.GetType());
                    serializer.Serialize(writer, listaProyectos, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml " + e.Message);
            }
        }
        */
        public Proyecto(string descripcion, DateTime fechaInicio, DateTime fechaFin, 
                        double presupuestoInicial, double presupuestoActual, bool cambios, int codigoCliente, estado e)
        {
            this.presupuestoInicial = presupuestoInicial;
            this.presupuestoActual  = presupuestoActual;
            this.descripcion        = descripcion;
            this.fechaInicio        = fechaInicio;
            this.fechaFin           = fechaFin;
            this.codigo             = codigoIncrementado;
            this.cambios            = cambios;
            this.codigoCliente      = codigoCliente;
            this.estadoProyecto = e;
            codigoIncrementado++;
        }
        public Proyecto (string descripcion)
        {
            this.descripcion = descripcion;
        }


        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public double PresupuestoInicial { get => presupuestoInicial; set => presupuestoInicial = value; }
        public double PresupuestoActual { get => presupuestoActual; set => presupuestoActual = value; }
        public bool Cambios { get => cambios; set => cambios = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }

        public override bool Equals(object obj)
        {
            return obj is Proyecto proyecto &&
                   Codigo == proyecto.Codigo &&
                   Descripcion == proyecto.Descripcion &&
                   FechaInicio == proyecto.FechaInicio &&
                   FechaFin == proyecto.FechaFin &&
                   PresupuestoInicial == proyecto.PresupuestoInicial &&
                   PresupuestoActual == proyecto.PresupuestoActual &&
                   Cambios == proyecto.Cambios &&
                   CodigoCliente == proyecto.CodigoCliente;
        }    
    }
}
