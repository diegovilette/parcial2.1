using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGraficas g = new frmGraficas();
            g.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetallesVenta detalle = new frmDetallesVenta();
            detalle.ShowDialog();
        }
    }
}
