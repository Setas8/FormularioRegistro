using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FormularioRegistro
{
    public class Usuario
    {
        private String id;
        private String clave;
        

        public Usuario() {}

        public Usuario(string id, string clave)
        {
            this.id = id;
            this.clave = clave;
        }
       
        public String PId
        {
            get { return id; }
            set { id = value; }
        }
        
        public String PClave 
        {
            get { return clave; }
            set { clave = value; }
        }
    }
}
