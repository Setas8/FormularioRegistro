using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace FormularioRegistro
{
    public class Empleado
    {
      
        private int id = idIncrementado;
        static  private int idIncrementado = 1;
        private string dni, nombre, apellido1, apellido2, puesto, correo, comentarios;
        private int telefono;
        private long numSS;
        private DateTime fechaNacimiento;

        

        public Empleado() { }
        
        public Empleado(string dni, string nombre, string apellido1, string apellido2, string puesto, string correo,
                        string comentarios, int telefono, long numSS, DateTime fechaNacimiento)
        {
            this.Id = idIncrementado;
            idIncrementado++;
            this.Dni             = dni;
            this.Nombre          = nombre;
            this.Apellido1       = apellido1;
            this.Apellido2       = apellido2;
            this.Puesto          = puesto;
            this.Correo          = correo;
            this.Comentarios     = comentarios;
            this.Telefono        = telefono;
            this.NumSS           = numSS;
            this.FechaNacimiento = fechaNacimiento;
        }
        public Empleado(string dni, string nombre, string apellido1, string apellido2, string puesto, int numSS)
        {
            this.Id = idIncrementado;
            idIncrementado++;
            this.Dni       = dni;
            this.Nombre    = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Puesto    = puesto;
            this.NumSS     = numSS;
        }

        public Empleado(string dni, string nombre, int numSS)
        {
            this.Id = idIncrementado;
            idIncrementado++;
            this.Dni    = dni;
            this.Nombre = nombre;
            this.NumSS  = numSS;
        }

        public int Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public long NumSS { get => numSS; set => numSS = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public bool esJefe()
        {           
            return this.Puesto.Equals("Jefe proyecto", StringComparison.OrdinalIgnoreCase);
        }

        public void cambiarComentarios(string comentario)
        {
            this.comentarios = comentario;
        }
    }
}
