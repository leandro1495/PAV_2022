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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin oFL = new frmLogin();
            oFL.ShowDialog(); //Muestra una ventana hasta que se cierra
            oFL.Dispose(); //Destruye la instancia del objeto, para liberar la memoria
        }
    }
}
