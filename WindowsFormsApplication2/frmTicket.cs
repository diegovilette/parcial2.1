using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace WindowsFormsApplication2
{
    public partial class frmTicket : Form
    {
        public frmTicket(List<Producto> lista, int num, string cliente,string tipo)
        {
            InitializeComponent();
            lpr = lista;
            this.cliente = cliente;
            numeroBoleta = num;
            tipoF = tipo;
        }
        string cliente;
        List<Producto> lpr;
        int numeroBoleta;
        string tipoF;
        private void frmTicket_Load(object sender, EventArgs e)
        {
            

            
        }

        private void frmTicket_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Producto", typeof(String));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio Unitario", typeof(double));
            dt.Columns.Add("Total", typeof(double));

            double total = 0;
            foreach (Producto p in lpr)
            {
                dt.Rows.Add(p.Descripcion, p.Stock,p.PrecioCosto, p.PrecioCosto);
                total += p.PrecioCosto *(1 +  p.CoefUtil) * p.Stock;

            }

            if (tipoF == "A")
            {
                string iva = "21";
                crFactura cr = new crFactura();
                cr.SetDataSource(dt);
                cr.SetParameterValue("CuitCliente", "12312");
                cr.SetParameterValue("parNombreCliente", cliente);
                cr.SetParameterValue("idFactura", "2");
                cr.SetParameterValue("TotalIVA", total);
                cr.SetParameterValue("IVA", iva);
                crFacturaA.ReportSource = cr;
                
                
            }
            else 
            {
                crFacturaB cr = new crFacturaB();
                crFacturaA.ReportSource = cr;
                cr.SetDataSource(dt);
            }
            
        }


    }
}
