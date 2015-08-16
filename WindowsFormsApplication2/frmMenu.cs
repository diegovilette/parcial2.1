
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmRegistrarVenta regVenta = new frmRegistrarVenta();
            regVenta.ShowDialog();
            
        }

        private void btnConsulteStock_Click(object sender, EventArgs e)
        {
            frmConsultarStock consStock = new frmConsultarStock();
            consStock.ShowDialog();
        }
        
        private void btnActualizaStock_Click(object sender, EventArgs e)
        {
            frmAdministrar adm = new frmAdministrar();
            adm.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmPedido ped = new frmPedido();
            ped.ShowDialog();
        }

        private void btnAnularVentas_Click(object sender, EventArgs e)
        {
            frmRemito rem = new frmRemito();
            rem.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmDetallesVenta dtV = new frmDetallesVenta();
            dtV.ShowDialog();
        }

      
    }
}
