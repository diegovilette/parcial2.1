using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmAdministrar : Form
    {
        public frmAdministrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProveedor pro = new frmProveedor();
            pro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProducto prod = new frmProducto();
            prod.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmClienteNuevo clienN = new frmClienteNuevo();
            clienN.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEditarCliente editC = new frmEditarCliente();
            editC.ShowDialog();
        }

        private void btnCreaUser_Click(object sender, EventArgs e)
        {
            frmModificarProducto modif = new frmModificarProducto();
            modif.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abmProducto aux = new abmProducto();
            aux.ShowDialog();
        }
    }
}
