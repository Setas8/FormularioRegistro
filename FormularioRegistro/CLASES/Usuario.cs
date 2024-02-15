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
        private String user;
        private String clave;
        

        public Usuario() {}

        public Usuario(string user, string clave)
        {
            this.user = user;
            this.clave = clave;
        }
       
        public String PUser
        {
            get { return user; }
            set { user = value; }
        }
        
        public String PClave 
        {
            get { return clave; }
            set { clave = value; }
        }
    }
}
