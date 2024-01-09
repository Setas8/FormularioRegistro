using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRegistro

{
    [Serializable]
    public class Cliente
    {

        private string dni, nombre, apellido1, apellido2, mail;
        private int telefono;
        private DateTime fechaNacimiento;

        public Cliente() { }

        public Cliente(string dni, string nombre, string apellido1, string apellido2, string mail, int telefono, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.mail = mail;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        
    }
}
