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
        private string user;
        private string clave;
        

        public Usuario() {}

        public Usuario(string user, string clave)
        {
            this.user = user;
            this.clave = clave;
        }
       
        public string PUser
        {
            get { return user; }
            set { user = value; }
        }
        
        public string PClave 
        {
            get { return clave; }
            set { clave = value; }
        }
    }
}
