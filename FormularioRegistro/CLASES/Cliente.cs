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

        private string nombre;
        private string direccion;
        private string ciudad;
        private string pais;
        private string nombreRepresentante;
        private string correo;
        private string NIF;
        private string tipoCliente;
        private int descuento;
        private string comentarios;
        private string logo;
        private int telefono;
        private DateTime fechaAlta;
        private DateTime proximaCita;
        private DateTime ultimaCita;

        public Cliente() { }

        public Cliente(string nombre, string direccion, string ciudad, string pais, string nombreRepresentante,
                       string correo, string nIF, string tipoCliente, int descuento, string comentarios, string logo, 
                       int telefono, DateTime fechaAlta, DateTime proximaCita, DateTime ultimaCita)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.pais = pais;
            this.nombreRepresentante = nombreRepresentante;
            this.correo = correo;
            NIF = nIF;
            this.tipoCliente = tipoCliente;
            this.descuento = descuento;
            this.comentarios = comentarios;
            this.logo = logo;
            this.telefono = telefono;
            this.fechaAlta = fechaAlta;
            this.proximaCita = proximaCita;
            this.ultimaCita = ultimaCita;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Pais { get => pais; set => pais = value; }
        public string NombreRepresentante { get => nombreRepresentante; set => nombreRepresentante = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NIF1 { get => NIF; set => NIF = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public string Logo { get => logo; set => logo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime ProximaCita { get => proximaCita; set => proximaCita = value; }
        public DateTime UltimaCita { get => ultimaCita; set => ultimaCita = value; }
    }
}
