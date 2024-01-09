using FormularioRegistro.Controladores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class Form_Registro : Form
    {
        public Form_Registro()
        {
            InitializeComponent();
        }
       

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            //cargarUsuariosLista();
           
            ControladorUsuarios.leerUsuariosXML();
        }
        const int INTENTOS = 3;
        int cont = 1;
        
        private void acepBoton_Click(object sender, EventArgs e)
        {
            //cargarUsuarios();
            //cargarUsuariosMatriz();
            //cargarUsuariosArrayArray();
            
            if (cont < INTENTOS)
            {
                //validarLogin -> Array de Strings
                //validarLoginArrayArray -> Array de Arrays
                if (!validarLoginLista(usuBox.Text, pswBox.Text))
                {
                    MessageBox.Show("Datos incorrectos");
                    usuBox.Clear();
                    pswBox.Clear();
                    usuBox.Focus();
                    cont++;                  
                    return;
                }
                
                else
                {                  
                    usuBox.Clear();
                    pswBox.Clear();
                    Form_Principal principal = new Form_Principal();
                    principal.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Se acabaron los intentos");
                Application.Exit();
            }        
        }
        private bool validarLoginLista(String usuario, String clave)
        {

            int posicion = ControladorUsuarios.listaUsuarios.FindIndex(x => x.PId == usuario.ToLower());

            return ((posicion != -1) && (ControladorUsuarios.listaUsuarios[posicion].PClave == clave)) ? true : false;

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormAltaUsuarios usu = new FormAltaUsuarios();
            usu.ShowDialog();
        }
        //private string[] listaUsuariosNombre = new string[6];
        //private string[] listaUsuariosClave  = new string[6];
        /*
        private void cargarUsuariosLista()
        {
            Usuario.listaUsuarios.Add(new Usuario("root"  , "1234"));
            Usuario.listaUsuarios.Add(new Usuario("juan"  , "4321"));
            Usuario.listaUsuarios.Add(new Usuario("jaime" , "4444"));
            Usuario.listaUsuarios.Add(new Usuario("jose"  , "1111"));
            Usuario.listaUsuarios.Add(new Usuario("javier", "2222"));
            Usuario.listaUsuarios.Add(new Usuario("jorge" , "3333"));

            Usuario.escribirUsuariosXML();
        }

       //Matriz de Strings
       private string[,] matrizUsuarios = new string[6, 2];
       private void cargarUsuariosMatriz()
       {
           matrizUsuarios[0, 0] = "root";
           matrizUsuarios[1, 0] = "juan";
           matrizUsuarios[2, 0] = "jaime";
           matrizUsuarios[3, 0] = "jose";
           matrizUsuarios[4, 0] = "javier";
           matrizUsuarios[5, 0] = "jorge";
           matrizUsuarios[0, 1] = "1234";
           matrizUsuarios[1, 1] = "4321";
           matrizUsuarios[2, 1] = "4444";
           matrizUsuarios[3, 1] = "1111";
           matrizUsuarios[4, 1] = "2222";
           matrizUsuarios[5, 1] = "3333";
       }
       bool validarLoginMatriz(string usuario, string clave)
       {
           for (int i = 0; i <= matrizUsuarios.GetUpperBound(0); i++)
           // el método GetUpperBound devuelve la última posición
           // ocupada de una dimensión, en este caso quiero la primera,
           // es decir la 0 y devolverá 5
           {
               if (matrizUsuarios[i, 0] == usuario.ToLower())
               {
                   if (matrizUsuarios[i, 1] == clave)
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               }
           }
           return false;
       }

       //Array de Arrays
       private string[][] arrayUsuarios = new string[6][];
       private void cargarUsuariosArrayArray()
       {
           arrayUsuarios[0][0] = "root";
           arrayUsuarios[1][0] = "juan";
           arrayUsuarios[2][0] = "jaime";
           arrayUsuarios[3][0] = "jose";
           arrayUsuarios[4][0] = "javier";
           arrayUsuarios[5][0] = "jorge";
           arrayUsuarios[0][1] = "1234";
           arrayUsuarios[1][1] = "4321";
           arrayUsuarios[2][1] = "4444";
           arrayUsuarios[3][1] = "1111";
           arrayUsuarios[4][1] = "2222";
           arrayUsuarios[5][1] = "3333";
       }
       bool validarLoginArrayArray(string usuario, string clave)
       {
           for (int i = 0; i <= arrayUsuarios.Length ; i++) 
           {
               if (arrayUsuarios[i][0] == usuario.ToLower())
               {
                   if (arrayUsuarios[i][1] == clave)
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               }
           }
           return false;
       }

       //Array de Strings
       private void cargarUsuarios()
       {
           listaUsuariosNombre[0] = "root";
           listaUsuariosNombre[1] = "juan";
           listaUsuariosNombre[2] = "jaime";
           listaUsuariosNombre[3] = "jose";
           listaUsuariosNombre[4] = "javier";
           listaUsuariosNombre[5] = "jorge";
           listaUsuariosClave[0] = "1234";
           listaUsuariosClave[1] = "4321";
           listaUsuariosClave[2] = "4444";
           listaUsuariosClave[3] = "1111";
           listaUsuariosClave[4] = "2222";
           listaUsuariosClave[5] = "3333";
       }
       private bool validarLogin(string usuario, string clave)
       {
           int i;
           bool encontrado = false;
           for (i = 0; !encontrado && i < listaUsuariosNombre.Length; i++)
           {
               if (listaUsuariosNombre[i] == usuario.ToLower())
               {
                   encontrado = true;
               }
           }
           if (encontrado)
           {
               if (listaUsuariosClave[i - 1] == clave)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else return false;
       }
    */
    }
}
