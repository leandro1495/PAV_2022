using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS
{
    public partial class frmLogin : Form
    {
        //private string usuario="admin";
        //private string clave="1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("INGRESE USUARIO");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == String.Empty)
            {
                MessageBox.Show("Ingrese contraseña");
                txtClave.Focus();
                return;
            }

            Usuario oUsuario = new Usuario();
            oUsuario.Nombre = txtUsuario.Text;
            oUsuario.Password = txtClave.Text;

            if (oUsuario.validar())
            {
                MessageBox.Show("Login OK",
                    "Ingreso al sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Usuario y/o contraseña incerrectos",
                    "Validación de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        //private bool validar()
        //{
        //    if (txtUsuario.Text == this.usuario && txtClave.Text == this.clave)
        //        return true;
        //    else
        //        return false;
        //}
    }
}

