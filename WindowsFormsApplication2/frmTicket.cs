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
        public frmTicket(List<Producto> lista, int num, Cliente cliente,Factura tipo)
        {
            InitializeComponent();
            lpr = lista;
            this.cliente = cliente;
            numeroBoleta = num;
            factura = tipo;
            
        }
        Cliente cliente;
        Factura factura;
        List<Producto> lpr;
        int numeroBoleta;
        
        
        private void frmTicket_Load(object sender, EventArgs e)
        {
            

            
        }

        private void frmTicket_Load_1(object sender, EventArgs e)
        {
            String nombreCompleto = string.Empty;
            nombreCompleto = cliente.Apellido + " " + cliente.Nombre;
            DataTable dt = new DataTable();
            dt.Columns.Add("Producto", typeof(String));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio Unitario", typeof(double));
            dt.Columns.Add("Total", typeof(double));

            double total = 0;
            foreach (Producto p in lpr)
            {
                dt.Rows.Add(p.Descripcion, p.Stock, p.PrecioCosto * (1 + p.CoefUtil), p.PrecioCosto * (1 + p.CoefUtil) * p.Stock);
                total += p.PrecioCosto *(1 +  p.CoefUtil) * p.Stock;

            }

            
            if (cliente.Tipo == 1)
            {
                double ivainscripto= (total * factura.Iva)/100;
                total = total - ivainscripto;

                crFactura cr = new crFactura();
                cr.SetDataSource(dt);
                cr.SetParameterValue("CuitCliente", cliente.Cuit);
                cr.SetParameterValue("nombreCliente", nombreCompleto);
                cr.SetParameterValue("domicilioCLiente", cliente.Domicilio);
                cr.SetParameterValue("ivaInscripto", ivainscripto);
                cr.SetParameterValue("idFactura", factura.Id);
                cr.SetParameterValue("TotalIVA", total);
                cr.SetParameterValue("IVA", factura.Iva.ToString());
                crFacturaA.ReportSource = cr;
                
                
            }
            else 
            {
                crFacturaB cr = new crFacturaB();
                cr.SetDataSource(dt);
                cr.SetParameterValue("CuitCliente", cliente.Cuit);
                cr.SetParameterValue("nombreCliente", nombreCompleto);
                cr.SetParameterValue("domicilioCLiente", cliente.Domicilio);
                cr.SetParameterValue("idFactura", factura.Id);
                crFacturaA.ReportSource = cr;
                
            }
            
        }


    }
}
