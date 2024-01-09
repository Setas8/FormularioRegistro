using FormularioRegistro.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class FormAltaUsuarios : Form
    {
        public FormAltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string usuario = tbUser.Text;
                string pswd = tbPswd.Text;
                Usuario usu = new Usuario(usuario,pswd);

                ControladorUsuarios.listaUsuarios.Add(usu);
                
                tbUser.BackColor = Color.White;
                tbPswd.BackColor = Color.White;
                tbUser.Clear();
                tbPswd.Clear();
            }
        }
        private bool validarCampos()
        {
            bool correcto = false;

            if (string.IsNullOrEmpty(tbUser.Text))
            {
                tbUser.BackColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(tbPswd.Text))
            {
                tbPswd.BackColor = Color.Red;
            }
            else if (tbUser.Text.Length > 10)
            {
                tbUser.BackColor = Color.Red;
                MessageBox.Show("El id debe tener menos de 10 caracteres");
            }
            else if (tbPswd.Text.Length > 10)
            {
                tbPswd.BackColor = Color.Red;
                MessageBox.Show("La contraseña debe tener menos de 10 caracteres");
            }
            else
            {
                tbUser.BackColor = Color.White;
                tbPswd.BackColor = Color.White;
                correcto = true;
            }

                return correcto;
        }
        ErrorProvider errorProvider1 = new ErrorProvider();
        ErrorProvider errorProvider2 = new ErrorProvider();
        private void user_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUser.Text))
            {
                errorProvider1.SetError(tbUser, "El campo nuevo usuario se debe rellenar");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void pswd_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPswd.Text))
            {
                errorProvider2.SetError(tbPswd, "El campo contraseña se debe rellenar");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void formularioAltaUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Quieres guardar los nuevos usuarios?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ControladorUsuarios.escribirUsuariosXML();
            }
        }
    }
}
